namespace EWebFrameworkCore.Vendor.Utils
{
    public interface IRequestHelper
    {
        bool ContainsKey(string paramName);

        object Get(string paramName);
        object Get(string paramName, bool pIsNullable);

        string ToJson();
  
    }
}