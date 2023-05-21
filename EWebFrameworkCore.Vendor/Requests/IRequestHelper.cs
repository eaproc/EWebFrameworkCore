using EWebFrameworkCore.Vendor.Utils;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Dynamic;

namespace EWebFrameworkCore.Vendor.Requests
{
    public interface IRequestHelper : IArrayable, IJsonable
    {
        string RequestBodyContent { get; }

        Dictionary<string, object> RequestVariables { get; }

        Dictionary<string, object> ProcessedRequestVariables { get; }

        /// <summary>
        /// like /auth/me
        /// </summary>
        /// <returns></returns>
        string UrlPath();

        /// <summary>
        /// like http://localhost:26090 it includes the port if different from normal.
        /// </summary>
        /// <returns></returns>
        string UrlHost();

        /// <summary>
        /// like "http://localhost:26090/instructor/class-evaluations/evaluate-group/fetch-grid" without params
        /// </summary>
        /// <returns></returns>
        string Url();

        HttpRequest Request { get; }
        IServiceProvider ServiceProvider { get; }

        bool ContainsKey(string paramName);

        T? Input<T>(string ParamName, object? DefaultValue = null);

        T? Objectify<T>(string ParamName) where T : class;

        object? Get(string paramName);

        object? Get(string paramName, bool pIsNullable);

        bool HasFile(string paramName);

        IFormFile? File(string paramName);

        dynamic ToDynamicObject();

        ExpandoObject ToPackagableForJson();

        bool IsQueryStringNullDefinition(object v);
    }
}