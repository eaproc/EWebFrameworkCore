using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EWebFrameworkCore.Dev.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public HomeController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public OkObjectResult Get()
        {
            return Ok(new { message = "Welcome to EWebFrameworkCore." });
        }
    }
}
