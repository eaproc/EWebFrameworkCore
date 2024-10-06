using System;
using System.Collections.Generic;
using System.Linq;

using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using static EWebFrameworkCore.Vendor.PathHandlers;
using ELibrary.Standard.VB.Objects;
using ELibrary.Standard.VB.InputsParsing;
using EWebFrameworkCore.Vendor.Services.DataTablesNET;
using ELibrary.Standard.VB;
using EWebFrameworkCore.Vendor.ConfigurationTypedClasses;
using System.Data.SqlTypes;
using EWebFrameworkCore.Vendor.Utils.DataExports.Excel;
using Microsoft.AspNetCore.Http;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;

namespace EWebFrameworkCore.Vendor.Requests
{
    public partial class RequestValidator
    {
        public RequestHelper RequestHelper { private set; get; }
        public EWebFrameworkCoreENV ENV { get; }

        private readonly Dictionary<String, Rule> ValidatedRules;

        public SortedList<string, string> errors;

        public RequestValidator(RequestHelper helper)
        {
            this.errors = new SortedList<string, string>();
            this.ValidatedRules = new Dictionary<string, Rule>();
            this.RequestHelper = helper;
            this.ENV = new EWebFrameworkCoreENV(helper.ServiceProvider);
        }


        public static bool IsValidJson(string strInput)
        {
            strInput = strInput.Trim();
            if ((strInput.StartsWith("{") && strInput.EndsWith("}")) || //For object
                (strInput.StartsWith("[") && strInput.EndsWith("]"))) //For array
            {
                try
                {
                    var obj = JToken.Parse(strInput);
                    return true;
                }
                catch (JsonReaderException jex)
                {
                    //Exception in parsing json
                    Console.WriteLine(jex.Message);
                    return false;
                }
                catch (Exception ex) //some other exception
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool IsValidEmail(string email)
        {
            return TextParsing.IsValidEmail(email);
        }

        public static bool IsValidInternationalPhoneNumber(string phone)
        {
            // don't add the / / in regex for starting and ending. It will add it, itself else it won't work.
            return Regex.IsMatch(phone, "[+][0-9]{8,15}", RegexOptions.IgnoreCase);
        }

        private void Check( Rule r)
        {
            // Logger.Print(r.paramName);
            if (r.isRequired && (
                     (!RequestHelper.ContainsKey(r.paramName) && !RequestHelper.HasFile(r.paramName))
                        ||
                        (RequestHelper.ContainsKey(r.paramName) && EStrings.ValueOf(RequestHelper.Get(r.paramName)) == string.Empty)
                    )
                )
            {
                this.errors.Add(r.paramName, r.paramName.Replace("_", " ") + " is required must be of type " + r.paramType.ToString());
                return;
            }


            //
            // Test for NULL
            //
            if (RequestHelper.ContainsKey(r.paramName))
            {
                string t = EStrings.ValueOf(RequestHelper.Get(r.paramName));
                if ((RequestHelper.IsQueryStringNullDefinition(t) || t == string.Empty) && r.IsNullable) return;
            }


            switch (r.paramType)
            {
                case Rule.ParamTypes.UNESCAPED_STRING:
                case Rule.ParamTypes.STRING:
                    if (RequestHelper.ContainsKey(r.paramName))
                    {
                        var s = EStrings.ValueOf(RequestHelper.Get(r.paramName));
                        if(r.paramType== Rule.ParamTypes.UNESCAPED_STRING) s = Uri.UnescapeDataString(s);

                        if (s.Length > r.paramMaxSize || s.Length < r.paramMinSize)
                            this.errors.Add(r.paramName, string.Format("The size of  {0} must be minimum of {1} and maximum of {2}",
                                r.paramName, r.paramMinSize, r.paramMaxSize)
                                );

                        return;
                    }
                    break;
                case Rule.ParamTypes.EMAIL:
                    if (RequestHelper.ContainsKey(r.paramName))
                    {
                        var s = EStrings.ValueOf(RequestHelper.Get(r.paramName));
                        if (s.Length > r.paramMaxSize || s.Length < r.paramMinSize)
                            this.errors.Add(r.paramName, string.Format("The size of  {0} must be minimum of {1} and maximum of {2}",
                                r.paramName, r.paramMinSize, r.paramMaxSize)
                                );
                        
                        if (!IsValidEmail( s) )
                            this.errors.Add(r.paramName, string.Format("The value of {0} must be a valid Email Address", r.paramName));
                        return;
                    }
                    break;         
                case Rule.ParamTypes.INTERNATIONAL_PHONE_NUMBER:
                    if (RequestHelper.ContainsKey(r.paramName))
                    {
                        var s = EStrings.ValueOf(RequestHelper.Get(r.paramName));
                        if (s.Length > r.paramMaxSize || s.Length < r.paramMinSize)
                            this.errors.Add(r.paramName, string.Format("The size of  {0} must be minimum of {1} and maximum of {2}",
                                r.paramName, r.paramMinSize, r.paramMaxSize)
                                );
                        
                        if (!IsValidInternationalPhoneNumber( s) )
                            this.errors.Add(r.paramName, string.Format("The value of {0} must be a valid International Phone Number like +23411112222 with minimum of 8 and max of 15 characters", r.paramName));
                        return;
                    }
                    break;
                case Rule.ParamTypes.NUMERIC_STRING:
                    // 
                    // Acts as string but makes sure the content is all number
                    //
                    if (RequestHelper.ContainsKey(r.paramName))
                    {
                        var s = EStrings.ValueOf(RequestHelper.Get(r.paramName));
                        if (s.Length > r.paramMaxSize || s.Length < r.paramMinSize)
                            this.errors.Add(r.paramName, string.Format("The size of  {0} must be minimum of {1} and maximum of {2}",
                                r.paramName, r.paramMinSize, r.paramMaxSize)
                                );

                        if (s.Where(x => !TextParsing.IsNumber(x)).Any())
                            this.errors.Add(r.paramName, string.Format("The content  {0} must be numbers only [0 to 9]", r.paramName) );

                        return;
                    }
                    break;
                case Rule.ParamTypes.BOOLEAN:
                    if (RequestHelper.ContainsKey(r.paramName))
                    {
                        var s = EStrings.ValueOf(RequestHelper.Get(r.paramName));
                        if (s.Length == 0 ||
                            (s != "1" && s != "0" && s.ToLower() != "true" && s.ToLower() != "false")
                            )
                        {
                            this.errors.Add(r.paramName, string.Format("Invalid value passed in for {0}. It must be a [1 or 0] or [true or false].", r.paramName)
                                );
                            return;
                        }

                    }

                    break;
                case Rule.ParamTypes.DECIMAL:
                    if (RequestHelper.ContainsKey(r.paramName))
                    {
                        var s = EStrings.ValueOf(RequestHelper.Get(r.paramName));

                        if ((s == "null" || s == string.Empty) && r.IsNullable) return;

                        decimal p = 0;

                        if (
                            (r.paramMinSize != 0 && (s.Length == 0 || !Decimal.TryParse(s, out p))))
                        {
                            this.errors.Add(r.paramName, string.Format("Invalid value passed in for {0}. It must be a valid decimal.", r.paramName)
                                );
                            return;
                        }
                        //decimal p = EDecimal.ValueOf(s);
                        if (p < r.paramMinSize || p > r.paramMaxSize)
                        {
                            this.errors.Add(r.paramName, string.Format("The size of  {0} must be minimum of {1} and maximum of {2}",
                              r.paramName, r.paramMinSize, r.paramMaxSize)
                              );
                        }

                    }
                    break;
                case Rule.ParamTypes.FILE:
                    if (RequestHelper.ContainsKey(r.paramName))
                    {
                        //Logger.Print(EStrings.ValueOf(RequestHelper.Get(r.paramName)));
                        this.errors.Add(r.paramName, string.Format("Invalid value passed in for {0}. It must be file.", r.paramName)
                               );
                        return;
                    }
#pragma warning disable CS8602 // Dereference of a possibly null reference. It already checked if it has file
                    if (RequestHelper.HasFile(r.paramName) && RequestHelper.File(r.paramName).Length > (r.paramMaxSize * 1024))
                    {
                        this.errors.Add(r.paramName, string.Format("The size of  {0} must be maximum of {2}kb. You uploaded {1}!",
                            r.paramName, EMaths.getReadableByteValue(RequestHelper.File(r.paramName).Length), r.paramMaxSize)
                            );
                    }
#pragma warning restore CS8602 // Dereference of a possibly null reference.


                    break;
                case Rule.ParamTypes.INTEGER:
                    if (RequestHelper.ContainsKey(r.paramName))
                    {
                        var s = EStrings.ValueOf(RequestHelper.Get(r.paramName));

                        if (
                            (r.paramMinSize != 0 && s.Length == 0) || TextParsing.parseOutIntegers(s).Length != s.Length)
                        {
                            this.errors.Add(r.paramName, string.Format("Invalid value passed in for {0}. It must be a valid Integer.", r.paramName)
                                );
                            return;
                        }
                        int p = EInt.ValueOf(s);
                        if (p < r.paramMinSize || p > r.paramMaxSize)
                        {
                            this.errors.Add(r.paramName, string.Format("The size of  {0} must be minimum of {1} and maximum of {2}",
                              r.paramName, r.paramMinSize, r.paramMaxSize)
                              );
                        }

                    }

                    break;


                case Rule.ParamTypes.JSON:
                    if (RequestHelper.ContainsKey(r.paramName))
                    {
                        var s = EStrings.ValueOf(RequestHelper.Get(r.paramName));
                        if (!IsValidJson(s))
                            this.errors.Add(r.paramName, string.Format("The value of  {0} must be a valid json!", r.paramName)
                                );

                        return;
                    }
                    break;


                case Rule.ParamTypes.DATE:
                    if (RequestHelper.ContainsKey(r.paramName))
                    {
                        var s = EStrings.ValueOf(RequestHelper.Get(r.paramName));
                        if (DataTableRequestFields.ParseDate(s) == null)
                        {
                            this.errors.Add(r.paramName, string.Format("Invalid value passed in for {0}. It must be a valid date with format (yyyy-MM-dd).", r.paramName)
                                );
                            return;
                        }

                    }

                    break;

                case Rule.ParamTypes.TIME:
                    if (RequestHelper.ContainsKey(r.paramName))
                    {
                        var s = EStrings.ValueOf(RequestHelper.Get(r.paramName));
                        if (DataTableRequestFields.ParseTime(s) == null)
                        {
                            this.errors.Add(r.paramName, string.Format("Invalid value passed in for {0}. It must be a valid time with format ({1}).",
                                r.paramName, DataTableRequestFields.TIME_FORMAT)
                                );
                            return;
                        }

                    }
                    break;

                case Rule.ParamTypes.DATE_TIME:
                    if (RequestHelper.ContainsKey(r.paramName))
                    {
                        var s = EStrings.ValueOf(RequestHelper.Get(r.paramName));
                        if (!
                            DateTime.TryParseExact(
                             s: s,
                                    format: DATE_TIME_FORMAT,
                                    provider: System.Globalization.CultureInfo.InvariantCulture, // Culture info
                                    style: System.Globalization.DateTimeStyles.None, // No special parsing styles
                                    result: out DateTime dateTimeResult // Output variable
                          ))
                        {
                            errors.Add(r.paramName, $"Invalid value passed in for {r.paramName}. It must be a valid date with format ({DATE_TIME_FORMAT}).");
                            return;
                        }
                    }
                    break;
            }
        }


        public bool ValidateRulesQuitely(params Rule[] rules)
        {

            this.errors.Clear();

            foreach (Rule r in rules)
            {
                Check( r);
                this.ValidatedRules.Add(r.paramName, r);
            }

            return this.errors.Count == 0;
        }


        /// <summary>
        /// Throws exception if validation fails
        /// </summary>
        /// <param name="rules"></param>
        /// <returns></returns>
        /// <exception cref="InputValidationFailedException"></exception>
        public bool ValidateRules(params Rule[] rules)
        {
            if (!this.ValidateRulesQuitely(rules))
                throw new InputValidationFailedException(this.OutputErrors());
            return true;
        }


        /// <summary>
        /// it checks if it is APP_DEBUG mode, it shows detail error in English else just simple error in Selected language
        /// </summary>
        /// <returns></returns>
        public Dictionary<String, String> OutputErrors()
        {
            return this.errors.ToDictionary(x => x.Key, x => x.Value);

            //if (ENV.APP_DEBUG)
            //    return this.errors.ToDictionary(x => x.Key, x => x.Value);

            //Dictionary<String, String> r = new Dictionary<string, string>
            //{
            //    { "error", "Fill the required fields!" }
            //};

            //return r;

        }

        /// <summary>
        /// Note that this is not validating, it is only reading the values based on the rules
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pParamName"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public T? GetNullableValue<T>(string pParamName) where T:struct {
            if(!ValidatedRules.ContainsKey(key: pParamName)) return default;

            Rule r = ValidatedRules[key: pParamName];

            if (!RequestHelper.ContainsKey(pParamName) && !RequestHelper.HasFile(paramName: pParamName) ) return null;

            string? s = r.paramType != Rule.ParamTypes.FILE ?  EStrings.ValueOf(RequestHelper.Get(pParamName)) : null;
            if (s == null) return null;

            if (
                s == null
                ||
                (r.IsNullable && s == string.Empty)
                ||
                (r.IsNullable && RequestHelper.IsQueryStringNullDefinition(s))
            )
            {
                //it is null
                return null;
            }

            switch (r.paramType)
            {
                case Rule.ParamTypes.BOOLEAN:
                    return (T)(object)EBoolean.ValueOf(s);

                case Rule.ParamTypes.DECIMAL:
                    return (T)(object)EDecimal.ValueOf(s);

               
                case Rule.ParamTypes.INTEGER:
                    return (T)(object)EInt.ValueOf(s);

                case Rule.ParamTypes.DATE:
                    DateTime? v = DataTableRequestFields.ParseDate(s);
                    return v == null ? null : (T)(object)v.Value;     
                
                case Rule.ParamTypes.DATE_TIME:
                   bool parsed = DateTime.TryParseExact(
                           s: s,
                                  format: DATE_TIME_FORMAT,
                                  provider: System.Globalization.CultureInfo.InvariantCulture, // Culture info
                                  style: System.Globalization.DateTimeStyles.None, // No special parsing styles
                                  result: out DateTime dateTimeResult // Output variable
                        );
                    return parsed? (T)(object)dateTimeResult : null;

                case Rule.ParamTypes.TIME:
                    DateTime? t = DataTableRequestFields.ParseTime(s);
                    return  t == null ? null : (T)(object)t.Value;
            }

            throw new NotImplementedException("This type [" + r.paramType.ToString() + "] is not yet supported!");
        }
        /// <summary>
        /// Note that this is not validating, it is only reading the values based on the rules
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pParamName"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public T? GetNullableClassValue<T>(string pParamName) where T : class
        {
            if (!ValidatedRules.ContainsKey(key: pParamName)) return default;

            Rule r = ValidatedRules[key: pParamName];

            if (!RequestHelper.ContainsKey(pParamName) && !RequestHelper.HasFile(paramName: pParamName)) return null;

            string? s = r.paramType != Rule.ParamTypes.FILE ? EStrings.ValueOf(RequestHelper.Get(pParamName)) : null;
            if (s == null && r.paramType != Rule.ParamTypes.FILE) return null;

            if( r.paramType != Rule.ParamTypes.FILE )
            {
                if (
                       s == null
                       ||
                       (r.IsNullable && s == string.Empty)
                       ||
                       (r.IsNullable && RequestHelper.IsQueryStringNullDefinition(s))
                       )
                {
                    //it is null
                    return null;
                }
            }

            switch (r.paramType)
            {
                case Rule.ParamTypes.INTERNATIONAL_PHONE_NUMBER:
                case Rule.ParamTypes.EMAIL:
                case Rule.ParamTypes.UNESCAPED_STRING:
                case Rule.ParamTypes.STRING:
                    if (s == null) return null;// just for syntax check sake. It is already covered above

                    //// this is wrong because we are getting nullable here
                    ////it is empty string not null
                    //if (!r.IsNullable && RequestHelper.IsQueryStringNullDefinition(s))
                    //    return (T)(object)string.Empty;

                    if (r.paramType == Rule.ParamTypes.UNESCAPED_STRING) return (T)(object)Uri.UnescapeDataString(s);

                    return (T)(object)s;

                case Rule.ParamTypes.NUMERIC_STRING:
                    if (s == null) return null;// just for syntax check sake. It is already covered above
                    return s == null ? null : (T)(object)s;
                
                case Rule.ParamTypes.JSON:
                    if (s == null) return null;// just for syntax check sake. It is already covered above
                    return (T)(object)s;

                case Rule.ParamTypes.FILE:
                    // it won't reach here if it is not nullable
                    if (r.IsNullable && !RequestHelper.HasFile(paramName: pParamName)) return null;
                    IFormFile? f = RequestHelper.File(pParamName);
                    return f == null ? null : (T)(object)f;
                
                default:
                    if (typeof(T) == typeof(object)) 
                        return (T?)(object?)s;
                    break;
            }


            throw new NotImplementedException("This type [" + r.paramType.ToString() + "] is not yet supported!");
        }

        /// <summary>
        /// Using this means you need a default value if null is found
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pParamName"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public T GetValue<T>(string pParamName) where T: notnull
        {
            // https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/constraints-on-type-parameters
            if (!this.ValidatedRules.ContainsKey(key: pParamName)) throw new InvalidOperationException($"Param {pParamName} does not exists in rules!"); ;

            Rule r = this.ValidatedRules[key: pParamName];
            try
            {
                switch (r.paramType)
                {
                    case Rule.ParamTypes.EMAIL:
                    case Rule.ParamTypes.INTERNATIONAL_PHONE_NUMBER:
                    case Rule.ParamTypes.UNESCAPED_STRING:
                    case Rule.ParamTypes.STRING:
                    case Rule.ParamTypes.NUMERIC_STRING:
                    case Rule.ParamTypes.JSON:
                        string? s = GetNullableClassValue<string>(pParamName);
                        return s == null ? (T)(object)string.Empty : (T)(object)s;

                    case Rule.ParamTypes.BOOLEAN:
                        bool? b = GetNullableValue<bool>(pParamName);
                        return (T)(object)(b == null ? false : b);

                    case Rule.ParamTypes.DECIMAL:
                        decimal? d = GetNullableValue<decimal>(pParamName);
                        return (T)(object)(d == null ? 0 : d);

                    case Rule.ParamTypes.INTEGER:
                        int? i = GetNullableValue<int>(pParamName);
                        return (T)(object)(i == null ? 0 : i);

                    case Rule.ParamTypes.DATE:
                    case Rule.ParamTypes.DATE_TIME:
                    case Rule.ParamTypes.TIME:
                        return (T)(object)(GetNullableValue<DateTime>(pParamName) ?? throw new InvalidOperationException($"There is no default value for Dates, please use GetNullableValue function for parameter {pParamName}"));
                    case Rule.ParamTypes.FILE:
                        return (T)(object)(GetNullableClassValue<IFormFile>(pParamName) ?? throw new InvalidOperationException($"There is no default value for IFormFile, please use GetNullableClassValue function for parameter {pParamName}"));
                }
            }
            catch (System.InvalidCastException ex)
            {

                throw new InvalidProgramException($"Param Setting is wrong. Validation Rule and Get Type are different for [ {pParamName} ]. {ex.Message}");
            }

            throw new NotImplementedException("This type [" + r.paramType.ToString() + "] is not yet supported!");


            //if (!this.ValidatedRules.ContainsKey(key: pParamName)) return default(T);

            //Rule r = this.ValidatedRules[key: pParamName];

            //if (!RequestHelper.ContainsKey(pParamName) && !RequestHelper.HasFile(paramName: pParamName)) return default(T);


            //string? s = r.paramType != Rule.ParamTypes.FILE ? EStrings.ValueOf(RequestHelper.Get(pParamName)) : null;

            //switch (r.paramType)
            //{
            //    case Rule.ParamTypes.EMAIL:
            //    case Rule.ParamTypes.UNESCAPED_STRING:
            //    case Rule.ParamTypes.STRING:
            //        if (r.IsNullable && s == string.Empty)
            //        {
            //            //it is empty string not null
            //            if (!RequestHelper.IsQueryStringNullDefinition(s))
            //                return (T)(object)string.Empty;

            //            //it is null
            //            return (T)(object)(String)null;
            //        }

            //        if (r.paramType == Rule.ParamTypes.UNESCAPED_STRING) return (T)(object)Uri.UnescapeDataString(s);
            //        return (T)(object)s;

            //    case Rule.ParamTypes.NUMERIC_STRING:
            //        if (r.IsNullable && s == string.Empty) return (T)(object)(String)null;
            //        return (T)(object)s;

            //    case Rule.ParamTypes.BOOLEAN:
            //        if (r.IsNullable && s == string.Empty) return default; // literally you control the output regarding null.
            //        return (T)(object)EBoolean.ValueOf(s);

            //    case Rule.ParamTypes.DECIMAL:
            //        if (r.IsNullable && s == string.Empty) return default(T);
            //        return (T)(object)EDecimal.ValueOf(s);


            //    case Rule.ParamTypes.INTEGER:
            //        if (r.IsNullable && s == string.Empty) return default(T);
            //        return (T)(object)EInt.ValueOf(s);

            //    case Rule.ParamTypes.DATE:
            //        if (r.IsNullable && s == string.Empty) return default(T);
            //        return (T)(object)DataTableRequestFields.ParseDate(s).Value;

            //    case Rule.ParamTypes.TIME:
            //        if (r.IsNullable && s == string.Empty) return default(T);
            //        return (T)(object)DataTableRequestFields.ParseTime(s).Value;

            //    case Rule.ParamTypes.JSON:
            //        if (r.IsNullable && s == string.Empty) return default(T);
            //        return (T)(object)s;

            //    case Rule.ParamTypes.FILE:
            //        // it won't reach here if it is not nullable
            //        if (r.IsNullable && !RequestHelper.HasFile(paramName: pParamName)) return default(T);
            //        return (T)(object)RequestHelper.File(pParamName);
            //}


            //throw new NotImplementedException("This type [" + r.paramType.ToString() + "] is not yet supported!");

        }
    }
}