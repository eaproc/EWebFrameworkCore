﻿using EWebFrameworkCore.Vendor.Utils;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using System.Net.Mime;
using System.Text;

namespace EWebFrameworkCore.Vendor.JsonReplies
{
    public class ResponseMessage : IActionResult, IJsonable
    {
        /// <summary>
        ///  Major change in latter version will eliminate all properties and send just data
        /// </summary>
        public string? message;
        public bool success;
        public object? data;


        public ResponseMessage(bool pSuccess=true, string? pMessage = null, object? pData = null )
        {

            this.success = pSuccess;
            this.message = pMessage;
            this.data = pData;

            this.StatusCode = (int)HttpStatusCode.OK;
        }

        protected int StatusCode { get; set; }

        public Task ExecuteResultAsync(ActionContext context)
        {
            // Without this line, it throws error 
            // asp-net-core-synchronous-operations-are-disallowed-call-writeasync-or-set-all
            // https://stackoverflow.com/questions/47735133/asp-net-core-synchronous-operations-are-disallowed-call-writeasync-or-set-all
            var syncIOFeature = context.HttpContext.Features.Get<IHttpBodyControlFeature>();
            if (syncIOFeature != null)
            {
                syncIOFeature.AllowSynchronousIO = true;
            }
            // ------------------------

            var Response = context.HttpContext.Response;
            Response.StatusCode = this.StatusCode;
            Response.Headers["Content-Type"] = MediaTypeNames.Application.Json + "; charset=utf-8";

            // Use StreamWriter with UTF8 encoding without BOM
            using (var sw = new StreamWriter(Response.Body, new UTF8Encoding(false)))
            {
                sw.Write(this.ToJson());
                // this generates error if the response is huge around 200KB
                // The stream is currently in use by a previous operation on the stream .net core
                // sw.WriteAsync(this.ToJson());
            }
            return Task.CompletedTask;
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
            return JsonConvert.SerializeObject(this); // contains /r/n
            // return JsonConvert.SerializeObject(this, Formatting.None);
        }



    }
}