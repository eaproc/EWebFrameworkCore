using ELibrary.Standard.VB;
using EWebFrameworkCore.Vendor;
using EWebFrameworkCore.Vendor.Requests;
using EWebFrameworkCore.Vendor.Utils;
using EWebFrameworkCore.Vendor.JsonReplies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EWebFrameworkCore.Dev.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : Vendor.Controller
    {
        public HomeController(IServiceProvider provider):base(provider)
        {}

        [HttpPost]
        public ObjectResult Post()
        {
            try
            {
                   var v = new RequestValidator(this.RequestInputs);
                if (
                        v.Validate(
                                new RequestValidator.Rule("dzUuid", pIsRequired: true, pParamMaxSize: 10000, pParamType: RequestValidator.Rule.ParamTypes.STRING, pIsNullable: false),
                                new RequestValidator.Rule("dzChunkIndex", pIsRequired: true, pParamMinSize: 0, pParamMaxSize: 10000, pParamType: RequestValidator.Rule.ParamTypes.INTEGER, pIsNullable: false),
                                new RequestValidator.Rule("File__IMPORT", pIsRequired: true, pParamMaxSize: 5000, pParamType: RequestValidator.Rule.ParamTypes.FILE, pIsNullable: false)
                        // Each chunk  can nopt be more than 5MB
                        )
                    )
                {

                    int dzChunkIndex = v.GetValue<int>("dzChunkIndex");
                    string dzUuid = v.GetValue<string>("dzUuid");
                    string StoragePath = string.Format("{0}/{1}.png", PathHandlers.AppFileStore(dzUuid), dzChunkIndex);


                    //IFormFile File__IMPORT = v.GetValue<IFormFile>("File__IMPORT");
                    //File__IMPORT.SaveFormFileAs(StoragePath);


                    return new SuccessResult(pData: this.RequestInputs.ToPackagableForJson());
                }
                else
                {
                    return new ExpectationFailedResult(pData: v.OutputErrors());
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error");
                throw;
            }
        }

        [HttpGet]
        public OkObjectResult Get()
        {
            return Ok(new { message = "Welcome to EWebFrameworkCore." });
        }
    }
}
