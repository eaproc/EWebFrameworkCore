using EWebFrameworkCore.Vendor.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace EWebFrameworkCore.Vendor.Requests
{
    public partial class RequestHelper
    {
        /// <summary>
        /// Handles Query Parameter as Indexable and Arrayable
        /// </summary>
        public class QueryArrayParam : IArrayable, IJsonable
        {
            public string ParamKey { get; private set; }
            public Dictionary<string, string> Objects { get; private set; }
            public Dictionary<string, QueryArrayParam> ArrayObjects { get; private set; }

            public QueryArrayParam( IGrouping<string, KeyValuePair<string, string>> arrayGrps, string ParentKey = "")
            {
                this.ParamKey = ParentKey == "" ? arrayGrps.Key : ParentKey + "." + arrayGrps.Key;
                this.Objects = arrayGrps.Select(
                    x => new KeyValuePair<string, string>( this.CreateFinalKey( x.Key.Substring((arrayGrps.Key + "[").Length) ), x.Value) 
                    ).ToDictionary( (x)=> x.Key, (x)=> x.Value);

                // Process Arrays in Querys
                this.ArrayObjects = new Dictionary<string, QueryArrayParam>();

                foreach (var v in QueryArrayParam.ProcessArraysInQuery(this.Objects, this.ParamKey))
                    this.ArrayObjects.Add( v.ParamKey, v);

                if (this.HasArrayObjects())
                    foreach (string s in this.Objects.Where(x => x.Key.IndexOf('[') >= 0).Select(x => x.Key).ToArray())
                        this.Objects.Remove(s);
            }

            /// <summary>
            /// Converts key to dot notation
            /// </summary>
            /// <param name="SuspectedKey"></param>
            /// <returns></returns>
            private string CreateFinalKey( string SuspectedKey)
            {
                if (SuspectedKey.IndexOf("[") > -1 ) return SuspectedKey;
                //return ParentKey + "." + this.ParamKey + "." + SuspectedKey;
                return this.ParamKey + "." + SuspectedKey;
            }

            /// <summary>
            /// Process Query Arrays
            /// </summary>
            /// <param name="pairs"></param>
            /// <param name="ParentKey"></param>
            /// <returns></returns>
            public static List<QueryArrayParam> ProcessArraysInQuery(IEnumerable<KeyValuePair<string, string>> pairs, string ParentKey = "")
            {
                List<QueryArrayParam> queryArrayParams = new List<QueryArrayParam>();
                var FirstLevel = pairs.Where(x => x.Key.Contains("["))
                    .Select(x => new KeyValuePair<string, string>(x.Key.Replace("]", ""), x.Value.ToString()))
                    .GroupBy(x => x.Key.Split('[').First());

                foreach (var arrayGrps in FirstLevel)
                {
                    var p = new QueryArrayParam(arrayGrps , ParentKey);
                    queryArrayParams.Add(p);
                }
                return queryArrayParams;
            }

            /// <summary>
            /// Get the direct string value
            /// </summary>
            /// <param name="Key"></param>
            /// <returns></returns>
            public string GetStringValue( string Key )
            {
                if (this.Objects.ContainsKey(Key)) return this.Objects[Key];
                throw new KeyNotFoundException();
            }

            /// <summary>
            /// Get expected array container
            /// </summary>
            /// <param name="Key"></param>
            /// <returns></returns>
            public QueryArrayParam GetQueryArray(string Key)
            {
                if (this.ArrayObjects.ContainsKey(Key)) return this.ArrayObjects[Key];

                throw new KeyNotFoundException();

                //QueryArrayParam r = this.ArrayObjects.Where(x => x.Value.Has(Key)).Select(x=> x.Value).FirstOrDefault();
                //QueryArrayParam r = this.ArrayObjects.Where(x => x.Value.FindContainer(Key) != null).Select(x => x.Value).FirstOrDefault();

                //if ( r == null ) throw new KeyNotFoundException();

                //return r;
            }

            /// <summary>
            /// This is just a proxy for calling GetObject Or GetValue
            /// </summary>
            /// <param name="Key"></param>
            /// <returns>String|QueryArrayParam</returns>
            public object GetStringOrQueryArray( string Key)
            {
                if (this.Objects.ContainsKey(Key)) return this.GetStringValue( Key );
                return GetQueryArray(Key);
            }

            /// <summary>
            /// Get expected array container that has the final key needed
            /// </summary>
            /// <param name="Key">Dot notation like Arrayable.0</param>
            /// <returns>Null if not found</returns>
            public QueryArrayParam FindContainer(string Key)
            {
                if (this.Objects.ContainsKey(Key) || this.ArrayObjects.ContainsKey(Key)) return this;

                return this.ArrayObjects.Where(x => x.Value.Has(Key)).Select(x => x.Value.FindContainer(Key)).FirstOrDefault();
                //return this.ArrayObjects.Where(x => x.Value.Has(Key)).Select(x => x.Value.GetObject(Key)).FirstOrDefault();
            }

            /// <summary>
            /// Checks if this container has the key being searched or its decendants contains the key
            /// </summary>
            /// <param name="Key"></param>
            /// <returns></returns>
            public bool Has( string Key )
            {
                return this.Objects.ContainsKey(Key) 
                    || this.ArrayObjects.ContainsKey(Key) 
                    || ArrayObjects.Where(x => x.Value.Has(Key)).Any();
            }

            /// <summary>
            /// Gets Value Collection of both Objects and Array
            /// </summary>
            /// <returns></returns>
            public List<Object> GetValuesOnly()
            {
                List<Object> l = this.Objects.Values.Select(x=> (object) x).ToList();
                if (this.HasArrayObjects())
                    l.AddRange(this.ArrayObjects.Values.Select(x => (object)x).ToList());
                return l;
            }

            /// <summary>
            /// If this object has any array
            /// </summary>
            /// <returns></returns>
            public bool HasArrayObjects()
            {
                return this.ArrayObjects.Count > 0;
            }

            /// <summary>
            /// if this object has any object in list
            /// </summary>
            /// <returns></returns>
            public bool HasObjects()
            {
                return this.Objects.Count > 0;
            }

            /// <summary>
            /// Checks if this object using associated key or just indexed keys
            /// </summary>
            /// <returns></returns>
            public bool HasNumbericObjectKeys()
            {
                return IsAllNumeric(this.Objects.Keys.Select(x => x.Split('.').Last()).ToArray())
                    && this.Objects.Keys.Count > 0
                    && int.Parse(this.Objects.Keys.OrderBy(x => x).First().Split('.').Last()) == 0 ;
            }

            /// <summary>
            /// Checks if the array objects are using associated key or just indexed keys
            /// </summary>
            /// <returns></returns>
            public bool HasNumbericArrayKeys()
            {
                return IsAllNumeric(this.ArrayObjects.Keys.Select(x=> x.Split('.').Last()).ToArray() ) 
                    && this.ArrayObjects.Keys.Count > 0
                    && int.Parse(this.ArrayObjects.Keys.OrderBy(x => x).First().Split('.').Last()) == 0;
            }

            /// <summary>
            /// Allow dynamic access to items like a class
            /// </summary>
            /// <returns></returns>
            public dynamic ToDynamicArray()
            {
                dynamic pairs = ToDynamicObjectsArray();

                var x = pairs as IDictionary<string, Object>;

                foreach (var v in this.ArrayObjects)
                    x.Add(v.Key.Split('.').Last(), v.Value.ToDynamicArray());

                return pairs;
            }

            /// <summary>
            /// Allows dynamic access to Objects in this class
            /// </summary>
            /// <returns>ExpandoObject</returns>
            private dynamic ToDynamicObjectsArray()
            {
                dynamic pairs = new System.Dynamic.ExpandoObject();

                var x = pairs as IDictionary<string, Object>;

                foreach (var v in this.Objects)
                    x.Add(v.Key.Split('.').Last(), v.Value);

                return pairs;
            }

            private List<object> PackArrayObject()
            {
                var x = new List<object>();
                foreach (var v in this.ArrayObjects)
                {
                    var z = (object)v.Value.ToPackagableForJson();
                    x.Add(z);
                }

                return x;
            }

            private ExpandoObject PackArrayObjectForNamedIndex()
            {
                dynamic pairs = new System.Dynamic.ExpandoObject();

                var xx = pairs as IDictionary<string, Object>;

                foreach (var v in this.ArrayObjects)
                {
                    var z = (object)v.Value.ToPackagableForJson();
                    xx.Add(v.Key.Split('.').Last(), z);
                }

                return pairs;
            }

            /// <summary>
            /// Returns ExpandoObject or List of Objects
            /// </summary>
            /// <returns></returns>
            public object ToPackagableForJson()
            {
                var l = new List<object>();

                if (this.HasNumbericObjectKeys())
                    l.AddRange(this.Objects.Values.Select(x => (object)x));
                else if (this.Objects.Count > 0)
                    l.Add(this.ToDynamicObjectsArray());


                if (this.HasNumbericArrayKeys())
                    l.Add(this.PackArrayObject());
                else if (this.HasArrayObjects())
                    l.Add(this.PackArrayObjectForNamedIndex());

                return  ( this.HasArrayObjects() && this.HasObjects() ) || l.Count > 1 ? l : l.FirstOrDefault();
            }

            /// <summary>
            /// TODO:
            /// </summary>
            /// <returns></returns>
            public IEnumerable<object> ToArray(  )
            {
                ExpandoObject z = (ExpandoObject)this.ToDynamicArray();
                return z.Cast<object>();

                //var l = new List<object>();

                //if (this.HasNumbericObjectKeys())
                //    l.AddRange(this.Objects.Values.Select(x => (object)x));
                //else if( this.Objects.Count > 0 )
                //    l.Add(this.ToDynamicObjectsArray());


                //if( this.HasNumbericArrayKeys() )
                //    l.Add(this.PackArrayObject());
                //    //l.AddRange(this.ArrayObjects.AsEnumerable().Select(x => (object)x.Value.ToArray() ));
                //else if( this.HasArrayObjects() )
                //    l.AddRange(this.ArrayObjects.AsEnumerable().Select(x => (object)x.Value.ToDynamicArrayObjectsArray( x.Key )));

                //return l;
            }

            /// <summary>
            /// Converts class to json
            /// </summary>
            /// <returns></returns>
            public string ToJson()
            {
                var v = this.ToPackagableForJson();
                string s = JsonConvert.SerializeObject(v, Formatting.Indented);
                return s;
            }



            #region Utilities
            public static bool IsAllNumeric(string[] vs)
            {
                foreach (string v in vs)
                {
                    if (!IsNumeric(v)) return false;
                }
                return true;
            }

            public static bool IsNumeric(string value)
            {
                return value.All(char.IsNumber);
            }

            #endregion

        }
    }
}