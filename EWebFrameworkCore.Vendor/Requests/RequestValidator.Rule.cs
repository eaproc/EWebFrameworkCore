namespace EWebFrameworkCore.Vendor.Requests
{
    public partial class RequestValidator
    {

        /// <summary>
        /// "yyyy-MM-dd HH:mm"
        /// </summary>
       public const string DATE_TIME_FORMAT = "yyyy-MM-dd HH:mm";

        public struct Rule
        {
            public string paramName;
            public bool isRequired;
            public long paramMinSize;
            public long paramMaxSize;
            public ParamTypes paramType;
            public bool IsNullable;

            public enum ParamTypes
            {
                STRING, UNESCAPED_STRING, NUMERIC_STRING,  EMAIL, INTERNATIONAL_PHONE_NUMBER,
                FILE, INTEGER, DECIMAL, BOOLEAN, JSON,

                /// <summary>
                /// yyyy-MM-dd
                /// </summary>
                DATE,

                /// <summary>
                /// yyyy-MM-dd HH:mm
                /// </summary>
                DATE_TIME,

                /// <summary>
                /// HH:mm
                /// </summary>
                TIME
            }

            public Rule(string pName, bool pIsRequired, long pParamMinSize = 1, long pParamMaxSize = 50, ParamTypes pParamType = ParamTypes.STRING, bool pIsNullable = false)
            {
                this.paramName = pName;
                this.isRequired = pIsRequired;
                this.paramMinSize = pParamMinSize;
                this.paramMaxSize = pParamMaxSize;
                this.paramType = pParamType;
                this.IsNullable = pIsNullable;
            }

        }


    }
}