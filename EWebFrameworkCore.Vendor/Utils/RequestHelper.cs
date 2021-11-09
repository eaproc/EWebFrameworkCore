using static EWebFrameworkCore.Vendor.PathHandlers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using ELibrary.Standard.VB.Objects;

namespace EWebFrameworkCore.Vendor.Utils
{
    /// <summary>
    /// Request Helper helps to get request posted
    /// </summary>
    public partial class RequestHelper : IJsonable, IRequestHelper
    {
        /// <summary>
        /// Current HttpRequest Object
        /// </summary>
        public HttpRequest OriginalRequest { private set; get; }

        public bool IsJsonRequest { private set; get; }


        /// <summary>
        /// The string body of the post as string
        /// </summary>
        public string RequestBodyContent { private set; get; }


        /// <summary>
        /// The variables sent
        /// </summary>
        public Dictionary<string, object> RequestVariables { private set; get; }


        public RequestHelper(IServiceProvider provider)
        {
            this.OriginalRequest = provider.GetService<IHttpContextAccessor>().HttpContext.Request;

            this.IsJsonRequest = this.OriginalRequest.HasJsonContentType();
            this.RequestVariables = new Dictionary<string, object>();

            this.SetBodyContent();

            this.LoadData();

        }


        /// <summary>
        /// This can be done only once
        /// </summary>
        private void SetBodyContent()
        {
            Stream req = this.OriginalRequest.BodyReader.AsStream(true);
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
                if( this.OriginalRequest.Query.Count > 0 )
                {
                    foreach (var p in this.OriginalRequest.Query.ToDictionary((x) => x.Key, (x) => (object)x.Value))
                        RecursiveAddJson(p);

                    // Process Arrays in Querys
                    foreach ( var v in  QueryArrayParam.ProcessArraysInQuery(this.RequestVariables.Select(x => new KeyValuePair<string, string>(x.Key, x.Value==null? string.Empty: x.Value.ToString() ) ) ) )
                        this.RequestVariables.Add(v.ParamKey, v);
                }


                //foreach (var p in request.Params)
                //{
                //    if (p == null)
                //    {
                //        // Parameter is null but there is value.
                //        // That occurs when you send like &value
                //        // Instead of &value=something or atleast with =
                //        // or like this $value=
                //        //Logger.Print("p is null");
                //        // We don't accept that parameter so it won't be regarded
                //        continue;
                //    }
                //    RecursiveAddJson(new KeyValuePair<string, object>(p.ToString(), request[p.ToString()]));
                //}



                //// Only supports object not array, with array, this lines will crash
                //if (this.IsJsonRequest)
                //{
                //    string content = RequestBodyContent;
                //    if (content != null && content.Trim().StartsWith("{"))
                //    {
                //        var d = JsonDeserializer.deserializeToDictionary(content);
                //        if (d != null)
                //        {
                //            foreach (KeyValuePair<String, Object> p in d)
                //                RecursiveAddJson(p);

                //        }
                //    }
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
     

        private void RecursiveAddJson(KeyValuePair<String, Object> p, String AppendKeyName = "")
        {
            if (p.Value != null && p.Value.GetType() == typeof(Dictionary<String, Object>))
            {
                foreach (KeyValuePair<String, Object> pChild in (Dictionary<String, Object>)p.Value)
                    RecursiveAddJson(pChild, AppendKeyName + p.Key + ".");
            }
            else
            {
                if (!this.RequestVariables.ContainsKey(p.Key))
                    this.RequestVariables.Add(AppendKeyName + p.Key, p.Value);
            }
        }



        /// <summary>
        /// TODO: Checks if a key exists in the request sent
        /// </summary>
        /// <param name="paramName"></param>
        /// <returns></returns>
        public bool ContainsKey(string paramName)
        {
            return this.RequestVariables.ContainsKey(paramName);
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
        /// Only downside here is, if the request param is nullable and the value sent is "null", it will be seen as null
        /// </summary>
        /// <param name="paramName"></param>
        /// <param name="pIsNullable"></param>
        /// <returns></returns>
        public object Get(string paramName, bool pIsNullable)
        {
            if (!this.RequestVariables.ContainsKey(paramName) && this.GetArrayableParameters().Where(x => x.Value.Has(paramName)).Count()==0)
                throw new KeyNotFoundException(String.Format("The parameter name [ {0} ] is not found!", paramName));

            //if (this.IsJsonRequest) return this.RequestVariables[paramName];

            if (this.RequestVariables.ContainsKey(paramName)) return this.RequestVariables[paramName];
            return this.GetArrayableParameters().Where(x => x.Value.Has(paramName)).Select(x=> x.Value.FindContainer(paramName)).FirstOrDefault().GetStringOrQueryArray(paramName);

            ///***
            //* Solution here is make the string non-nullable for formdata and send empty string
            //* or make it nullable if you are sure user aren't suppose to enter "null" for the parameter
            //**/
            //String s = EStrings.valueOf(this.RequestVariables[paramName]);
            //if (pIsNullable && IsQueryStringNullDefinition(s)) s = null;

            //return s;
        }

        public KeyValuePair<string, QueryArrayParam>[] GetArrayableParameters()
        {
            return this.RequestVariables.Where(x => x.Value is QueryArrayParam).Select( x => new KeyValuePair<string, QueryArrayParam>(x.Key, (QueryArrayParam)x.Value) ).ToArray();
        }

        /// <summary>
        /// Get unprocessed raw value of a parameter
        /// </summary>
        /// <param name="paramName"></param>
        /// <returns></returns>
        public object GetOriginalSentValueOf(string paramName)
        {
            if (!this.RequestVariables.ContainsKey(paramName)) throw new KeyNotFoundException(String.Format("The parameter name [ {0} ] is not found!", paramName));

            return this.RequestVariables[paramName];
        }

        /// <summary>
        /// Checks if a file exists in the post
        /// </summary>
        /// <param name="paramName"></param>
        /// <returns></returns>
        public bool HasFile(string paramName)
        {
            return this.OriginalRequest.HasFormContentType 
                && this.OriginalRequest.Form.ContainsKey(paramName) 
                && this.OriginalRequest.Form.Files.Where(x=> x.Name == paramName).Count()==1;
        }

        /// <summary>
        /// Return Content Length in Bytes
        /// </summary>
        /// <param name="paramName"></param>
        /// <returns></returns>
        public long FileSize(string paramName)
        {
            return this.OriginalRequest.Form.Files[paramName].Length;
        }

        /// <summary>
        /// It is only true if the object is string and the value=null or undefined
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static bool IsQueryStringNullDefinition(object v)
        {
            if (v == null || !(v is string)) return false;
            return (v.ToString() == "null" || v.ToString() == "undefined");
        }








        /// <summary>
        /// Returns headers as object but preferrable if you access as dictionary
        /// ExpandoObject
        /// </summary>
        /// <returns></returns>
        public IHeaderDictionary HeadersObject()
        {
            return this.OriginalRequest.Headers;
        }

        /// <summary>
        /// Returns headers as JSON
        /// </summary>
        /// <returns></returns>
        public string HeadersJson()
        {
            return JsonConvert.SerializeObject(this.HeadersObject());
        }





        /// <summary>
        /// Return Variables as Object
        /// ExpandoObject == > Dictionary
        /// </summary>
        /// <returns></returns>
        public dynamic ToObject()
        {

            dynamic pairs = new System.Dynamic.ExpandoObject();

            var x = pairs as IDictionary<string, Object>;

            foreach (var v in this.RequestVariables)
                x.Add(v);

            return pairs;

        }



        /// <summary>
        /// Returns as JSON
        /// </summary>
        /// <returns></returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this.ToObject());
        }


    }
}