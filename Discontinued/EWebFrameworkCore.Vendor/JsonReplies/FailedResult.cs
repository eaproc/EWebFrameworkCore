using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace EWebFrameworkCore.Vendor.JsonReplies
{
    public class FailedResult : ResponseMessage
    {

        public FailedResult(String pMessage = "FAILED", object pData = null) : base(pSuccess: false, pMessage: pMessage, pData: pData)
        {
            this.StatusCode = (int?)HttpStatusCode.PreconditionFailed;
        }
    }
}