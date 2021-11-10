using EWebFrameworkCore.Vendor.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace EWebFrameworkCore.Dev.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IRequestHelper _RequestHelper;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IRequestHelper requestHelper)
        {
            _logger = logger;
            _RequestHelper = requestHelper;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {

            //ISpeaker speaker = (ISpeaker)HttpContext.RequestServices.GetService(typeof(ISpeaker));
            //speaker.Speak();
            //var l = this._RequestHelper.Objectify<float[]>("Arrayable");

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }


        [HttpPost]
        public JsonResult Post()
        {
            return new JsonResult(this._RequestHelper.ToPackagableForJson());
        }

    }
}
