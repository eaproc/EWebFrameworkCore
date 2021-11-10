using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Dynamic;

namespace EWebFrameworkCore.Vendor.Utils
{
    public interface IRequestHelper : IArrayable, IJsonable
    {
        string RequestBodyContent { get; }

        Dictionary<string, object> RequestVariables { get; }

        Dictionary<string, object> ProcessedRequestVariables { get; }

        HttpRequest Request { get; }

        bool ContainsKey(string paramName);

        T Input<T>(string ParamName, object DefaultValue = null);

        T Objectify<T>(string ParamName) where T : class;

        object Get(string paramName);

        object Get(string paramName, bool pIsNullable);

        bool HasFile(string paramName);

        IFormFile File(string paramName);

        dynamic ToDynamicObject();

        ExpandoObject ToPackagableForJson();

        bool IsQueryStringNullDefinition(object v);
    }
}