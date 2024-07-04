using EEntityCore.DB.Exceptions;
using System.Net;

namespace EWebFrameworkCore.Vendor.JsonReplies
{
    public class FailedResult : ResponseMessage
    {
        public FailedResult(Exception exception) : this(pData: new { message = exception is SQLCodeException ? "Error occurred while processing your request on server! Please, contact support!" : exception.Message })
        {
            if(exception is SQLCodeException)
                StatusCode = (int)HttpStatusCode.InternalServerError;
        }

        public FailedResult(String pMessage = "FAILED", object? pData = null) : base(pSuccess: false, pMessage: pMessage, pData: pData)
        {
            this.StatusCode = (int)HttpStatusCode.PreconditionFailed;
        }
    }
}