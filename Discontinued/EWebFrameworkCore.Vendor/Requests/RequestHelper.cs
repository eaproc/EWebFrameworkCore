﻿using ELibrary.Standard.VB.Objects;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;

namespace EWebFrameworkCore.Vendor.Requests
{
    /// <summary>
    /// Request Helper helps to get request posted
    /// </summary>
    public partial class RequestHelper : IRequestHelper
    {
        /// <summary>
        /// Current HttpRequest Object
        /// </summary>
        public HttpRequest Request { private set; get; }
        public IServiceProvider ServiceProvider { get; private set; }
        public bool IsJsonRequest { private set; get; }


        /// <summary>
        /// The string body of the post as string
        /// </summary>
        public string RequestBodyContent { private set; get; }

        public string Id { private set; get; }


        /// <summary>
        /// The variables sent
        /// </summary>
        public Dictionary<string, object> RequestVariables { private set; get; }
        public Dictionary<string, object> ProcessedRequestVariables { private set; get; }


        public RequestHelper(IServiceProvider provider)
        {
            this.Id = Guid.NewGuid().ToString();
            this.Request = provider.GetService<IHttpContextAccessor>().HttpContext.Request;

            this.ServiceProvider = provider;

            this.IsJsonRequest = this.Request.HasJsonContentType();
            this.RequestVariables = new Dictionary<string, object>();
            this.ProcessedRequestVariables = new Dictionary<string, object>();

            if( this.IsJsonRequest ) this.SetBodyContent();

            this.LoadData();

        }


        /// <summary>
        /// This can be done only once
        /// </summary>
        private void SetBodyContent()
        {
            Stream req = this.Request.BodyReader.AsStream(true);
             this.RequestBodyContent = new StreamReader(req, Encoding.UTF8, true, 1024, true).ReadToEnd();
        }


        /// <summary>
        /// Done only once
        /// </summary>
        /// <param name="request"></param>
        private void LoadData()
        {

            try
            {
                if( this.Request.Query.Count > 0 )
                {
                    foreach (var p in this.Request.Query.ToDictionary((x) => x.Key, (x) => (object)CleanUpKeyValue(x.Value)))
                        AddToRequestVariables(p);
                }

                if (this.Request.HasFormContentType )
                {
                    foreach (var p in this.Request.Form.ToDictionary((x) => x.Key, (x) => (object)CleanUpKeyValue(x.Value)))
                        AddToRequestVariables(p);
                }


                // Load Json Body
                if (this.IsJsonRequest)
                {
                    InspectAndBuildQuery(this.RequestBodyContent).Select(x => new KeyValuePair<string, object>(x.Key, x.Value)).ToList().ForEach(x => this.AddToRequestVariables(x));
                }



                // Process Arrays in Querys
                foreach (var v in QueryArrayParam.ProcessArraysInQuery(this.RequestVariables.Select(x => new KeyValuePair<string, string>(x.Key, x.Value == null ? string.Empty : x.Value.ToString()))))
                    this.RequestVariables.Add(v.ParamKey, v);

                //Seperate Parsed Variables
                foreach (string s in this.RequestVariables.Where(x => x.Key.IndexOf('[') >= 0).Select(x => x.Key).ToArray())
                {
                    ProcessedRequestVariables.Add(s, this.RequestVariables[s]);
                    this.RequestVariables.Remove(s);
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
     

        private void AddToRequestVariables(KeyValuePair<String, Object> p)
        {
            if (!this.RequestVariables.ContainsKey(p.Key))
                this.RequestVariables.Add(p.Key, p.Value);
        }



        /// <summary>
        /// Checks if a key exists in the request sent. Only check value keys, use HasFile for files
        /// </summary>
        /// <param name="paramName"></param>
        /// <returns></returns>
        public bool ContainsKey(string paramName)
        {
            return this.RequestVariables.ContainsKey(paramName)
                || this.ProcessedRequestVariables.ContainsKey(paramName)
                || this.GetArrayableParameters().Where(x => x.Value.Has(paramName)).Count() > 0;
        }


        /// <summary>
        /// Get an object
        /// </summary>
        /// <param name="paramName"></param>
        /// <returns></returns>
        public object Get(string paramName)
        {
            //return this.requestVariables[paramName];
            return this.Get(paramName, true);
        }

        /// <summary>
        /// TODO: Only downside here is, if the request param is nullable and the value sent is "null", it will be seen as null
        /// </summary>
        /// <param name="paramName"></param>
        /// <param name="pIsNullable"></param>
        /// <returns></returns>
        public object Get(string paramName, bool pIsNullable)
        {
            if (!this.ContainsKey(paramName))
                if (pIsNullable)
                    return null;
                else
                    throw new KeyNotFoundException(String.Format("The parameter name [ {0} ] is not found!", paramName));

            if (this.RequestVariables.ContainsKey(paramName)) return this.RequestVariables[paramName];
            if (this.ProcessedRequestVariables.ContainsKey(paramName)) return this.ProcessedRequestVariables[paramName];

            return this.GetArrayableParameters().Where(x => x.Value.Has(paramName)).Select(x=> x.Value.FindContainer(paramName)).FirstOrDefault().GetStringOrQueryArray(paramName);

            ///***
            //* Solution here is make the string non-nullable for formdata and send empty string
            //* or make it nullable if you are sure user aren't suppose to enter "null" for the parameter
            //**/
            //String s = EStrings.ValueOf(this.RequestVariables[paramName]);
            //if (pIsNullable && IsQueryStringNullDefinition(s)) s = null;

            //return s;
        }

        /// <summary>
        /// Gets the end result as StronglyTyped Input
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ParamName"></param>
        /// <param name="DefaultValue"></param>
        /// <returns></returns>
        public T Input<T>( string ParamName, object DefaultValue = null)
        {
            var b = this.Get(ParamName);
            if (b == null) return (T)DefaultValue;

            if (
                typeof(T) == typeof(string) 
                ||
                (typeof(T) == typeof(decimal) || typeof(T) == typeof(float))
                ||
                (b is string && QueryArrayParam.IsNumeric((string)b))
                )
            {
                return (T)Convert.ChangeType(b, typeof(T));
            }

            return (T)b;
        }

        /// <summary>
        /// Gets the end result as StronglyTyped Input
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ParamName"></param>
        /// <param name="DefaultValue"></param>
        /// <returns></returns>
        public T Objectify<T>(string ParamName) where T: class
        {
            QueryArrayParam b = this.Input<QueryArrayParam>(ParamName);
            if (b == null) return (T)null;

            return JsonConvert.DeserializeObject<T>(b.ToJson());
        }


        /// <summary>
        /// Get all arrayable parameters
        /// </summary>
        /// <returns></returns>
        public KeyValuePair<string, QueryArrayParam>[] GetArrayableParameters()
        {
            return this.RequestVariables.Where(x => x.Value is QueryArrayParam).Select( x => new KeyValuePair<string, QueryArrayParam>(x.Key, (QueryArrayParam)x.Value) ).ToArray();
        }

        ///// <summary>
        ///// Get unprocessed raw value of a parameter
        ///// </summary>
        ///// <param name="paramName"></param>
        ///// <returns></returns>
        //public object GetOriginalSentValueOf(string paramName)
        //{
        //    if (!this.RequestVariables.ContainsKey(paramName)) throw new KeyNotFoundException(String.Format("The parameter name [ {0} ] is not found!", paramName));

        //    return this.RequestVariables[paramName];
        //}

        /// <summary>
        /// Checks if a file exists in the post
        /// </summary>
        /// <param name="paramName"></param>
        /// <returns></returns>
        public bool HasFile(string paramName)
        {
            return this.Request.HasFormContentType 
                && this.Request.Form.Files.Where(x=> x.Name == paramName).Count()==1;
        }

        /// <summary>
        /// Checks if a file exists in the post
        /// </summary>
        /// <param name="paramName"></param>
        /// <returns></returns>
        public IFormFile File(string paramName)
        {
            return this.Request.Form.Files[paramName];
        }

        ///// <summary>
        ///// Return Content Length in Bytes
        ///// </summary>
        ///// <param name="paramName"></param>
        ///// <returns></returns>
        //public long FileSize(string paramName)
        //{
        //    return this.OriginalRequest.Form.Files[paramName].Length;
        //}

        /// <summary>
        /// It is only true if the object is string and the value=null or undefined
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public bool IsQueryStringNullDefinition(object v)
        {
            if (v == null || !(v is string)) return false;
            return (v.ToString() == "null" || v.ToString() == "undefined");
        }


        /// <summary>
        /// Return Variables as Object
        /// ExpandoObject == > Dictionary
        /// </summary>
        /// <returns></returns>
        public dynamic ToDynamicObject()
        {
            dynamic pairs = new System.Dynamic.ExpandoObject();

            var x = pairs as IDictionary<string, Object>;

            foreach (var v in this.RequestVariables)
            {
                if (v.Value is QueryArrayParam)
                    x.Add(v.Key, ((QueryArrayParam)v.Value).ToDynamicArray());
                else
                    x.Add(v.Key, v.Value == null ? null : v.Value.ToString());
            }

            return pairs;

        }

        public ExpandoObject ToPackagableForJson()
        {
            dynamic pairs = new System.Dynamic.ExpandoObject();

            var x = pairs as IDictionary<string, Object>;

            foreach (var v in this.RequestVariables)
            {
                if (v.Value is QueryArrayParam)
                    x.Add(v.Key, ((QueryArrayParam)v.Value).ToPackagableForJson());
                else
                    x.Add(v.Key, v.Value == null ? null : v.Value.ToString());
            }

            return pairs;
        }

        /// <summary>
        /// Returns as JSON
        /// </summary>
        /// <returns></returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this.ToPackagableForJson());
        }

        public IEnumerable<object> ToArray()
        {
            ExpandoObject z = (ExpandoObject)this.ToDynamicObject();
            return z.Cast<object>();
        }



        #region BuildingJson
        private IDictionary<string, string> InspectAndBuildQuery(string jsonString)
        {
            jsonString = jsonString.Trim();
            if (jsonString.StartsWith("{")) return BuildQueryFromJToken(JsonConvert.DeserializeObject<IDictionary<string, object>>(jsonString));
            if (jsonString.StartsWith("["))
            {
                Dictionary<string, string> l = new Dictionary<string, string>();

                List<object> list = JsonConvert.DeserializeObject<List<object>>(jsonString);
                for (int i = 0; i < list.Count; i++)
                {
                    object b = list[i];
                    CreateValuesFromJToken((JToken)b, string.Format("Root[{0}]", i)
                        ).ToList().ForEach(x => l.Add(
                            ToQuerableArrayableKey(x.Key), CleanUpKeyValue(x.Value)));

                }

                return l;
            }
            return new Dictionary<string, string>();
        }

        private  IDictionary<string, string> BuildQueryFromJToken(IDictionary<string, object> v)
        {
            Dictionary<string, string> l = new Dictionary<string, string>();

            foreach (var k in v)
            {
                CreateValuesFromJToken(k).ToList().ForEach(x => l.Add(ToQuerableArrayableKey(x.Key), CleanUpKeyValue(x.Value) ));
            }

            return l;
        }

        private  IDictionary<string, string> CreateValuesFromJToken(JToken k, string ParentPath = "")
        {
            Dictionary<string, string> l = new Dictionary<string, string>();

            foreach (JToken itemInArray in k)
            {
                if (itemInArray is JProperty || itemInArray is JArray || itemInArray is JObject)
                {
                    CreateValuesFromJToken(itemInArray, ParentPath).ToList().ForEach(x => l.Add(x.Key, x.Value));
                }
                else
                {
                    l.Add(ParentPath + "." + itemInArray.Path, (string)Convert.ChangeType(((JValue)itemInArray).Value, typeof(string)));
                }
            }

            return l;
        }

        private  IDictionary<string, string> CreateValuesFromJToken(KeyValuePair<string, object> k)
        {
            Dictionary<string, string> l = new Dictionary<string, string>();

            if (k.Value is JProperty || k.Value is JArray || k.Value is JObject)
            {
                foreach (JToken itemInArray in (JToken)k.Value)
                {
                    if (itemInArray is JValue)
                        l.Add(k.Key + "." + itemInArray.Path, (string)Convert.ChangeType(((JValue)itemInArray).Value, typeof(string)));
                    else
                        CreateValuesFromJToken(itemInArray, k.Key).ToList().ForEach(x => l.Add(x.Key, x.Value));
                }
            }
            else
            {
                l.Add(k.Key, (string)Convert.ChangeType(k.Value, typeof(string)));
            }
            return l;
        }

        private  string ToQuerableArrayableKey(string initialKey)
        {
            string[] chunks = initialKey.Split(".");
            string keyName = chunks.FirstOrDefault();
            if (chunks.Length > 1)
            {
                var s = (
                    from v in chunks.Skip(1)
                    let z = v.StartsWith("[") ? v : "[" + v
                    let y = z.EndsWith("]") ? z : z + "]"
                    select y
                    ).ToArray();
                return keyName + string.Join("", s);
            }

            return keyName;
        }

        private string CleanUpKeyValue( string v )
        {
            if (v == null) return v;
            return v.Trim();
        }
        #endregion
    }
}