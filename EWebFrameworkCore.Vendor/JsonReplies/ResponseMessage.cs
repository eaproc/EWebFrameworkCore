using EWebFrameworkCore.Vendor.Utils;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace EWebFrameworkCore.Vendor.JsonReplies
{
    public class ResponseMessage : ObjectResult, IJsonable
    {
        /// <summary>
        ///  Major change in latter version will eliminate all properties and send just data
        /// </summary>
        public String message;
        public bool success;
        public object data;


        public ResponseMessage(bool pSuccess=true, String pMessage = null, object pData = null ):base(value: new {
            message = pMessage,
            success= pSuccess,
            data = pData
        })
        {

            this.success = pSuccess;
            this.message = pMessage;
            this.data = pData;

            //this.Value = this;
            this.StatusCode = (int?)HttpStatusCode.OK;
        }



        /// <summary>
        /// Converts the response to JSON with length maximum integer value
        /// </summary>
        /// <returns></returns>
        public string ToJson()
        {
            // OLD .NET
            //var serializer = new JavaScriptSerializer { MaxJsonLength = Int32.MaxValue };
            //return serializer.Serialize(this);

            // NEW .NET
            //return System.Text.Json.JsonSerializer.Serialize(this, new JsonSerializerOptions() { WriteIndented = true } );

            // USING Newtonsoft
            return JsonConvert.SerializeObject(this);
        }



    }
}