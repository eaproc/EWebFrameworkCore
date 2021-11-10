using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace EWebFrameworkCore.Vendor.Utils
{
    public interface IRequestHelper
    {
        string RequestBodyContent { get; }

        Dictionary<string, object> RequestVariables { get; }

        Dictionary<string, object> ProcessedRequestVariables { get; }

        HttpRequest Request { get; }

        bool ContainsKey(string paramName);

        object Get(string paramName);

        object Get(string paramName, bool pIsNullable);

        bool HasFile(string paramName);

        IFormFile File(string paramName);

        dynamic ToDynamicObject();

        string ToJson();
        bool IsQueryStringNullDefinition(object v);
        T Input<T>(string ParamName, object DefaultValue = null);
    }
}