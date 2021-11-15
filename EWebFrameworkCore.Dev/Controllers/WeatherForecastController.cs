using EWebFrameworkCore.Vendor.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace EWebFrameworkCore.Dev.Controllers
{
    [Route("[controller]")]
    public class WeatherForecastController : EWebFrameworkCore.Vendor.Controller
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, IServiceProvider provider):base(provider)
        {
            _logger = logger;
        }

        [HttpGet]
        public JsonResult Get()
        {

            //ISpeaker speaker = (ISpeaker)HttpContext.RequestServices.GetService(typeof(ISpeaker));
            //speaker.Speak();
            //var l = this._RequestHelper.Objectify<float[]>("Arrayable");
            try
            {
                throw new Exception("Testing Serilog");
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Let's see");
                //Log.Error(ex, "Let's see");
            }
            return new JsonResult(this.RequestInputs.ToPackagableForJson());

            //var rng = new Random();
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = rng.Next(-20, 55),
            //    Summary = Summaries[rng.Next(Summaries.Length)]
            //})
            //.ToArray();
        }

      

        [HttpPost]
        public JsonResult Post()
        {
            //QueryHelpers.;
            return new JsonResult(this.RequestInputs.ToPackagableForJson());
        }

    }
}
