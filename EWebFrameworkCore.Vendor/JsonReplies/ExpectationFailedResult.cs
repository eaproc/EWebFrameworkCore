using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace EWebFrameworkCore.Vendor.JsonReplies
{
    public class ExpectationFailedResult : ResponseMessage
    {
        public ExpectationFailedResult(String pMessage = "EXPECTATION FAILED", object? pData = null) 
            : base(pSuccess: false, pMessage: pMessage, pData: pData)
        {
            this.StatusCode = (int)HttpStatusCode.ExpectationFailed;
        }
    }
}