using Microsoft.AspNetCore.Mvc;

namespace EWebFrameworkCore.Vendor.Controllers
{
    [Route("log-viewer")]
    public class LogsController : Controller
    {
        private readonly string logDirectory = PathHandlers.AppLogStore("");

        public LogsController(IServiceProvider provider) : base(provider) { }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "log-viewer.html"), "text/html");
        }

        // List all log files
        [HttpGet]
        [Route("list-files")]
        public IActionResult ListLogFiles()
        {
            if (!Directory.Exists(logDirectory))
            {
                return NotFound("Log directory not found.");
            }

            var logFiles = Directory.GetFiles(logDirectory, "*.log");
            var fileNames = new List<string>();

            foreach (var file in logFiles)
            {
                fileNames.Add(Path.GetFileName(file));
            }

            return new JsonResult(fileNames);
        }

        // Get content of a selected log file
        [HttpGet]
        [Route("view-file")]
        public IActionResult GetLogFileContent([FromQuery] string fileName)
        {
            var logFilePath = Path.Combine(logDirectory, fileName);

            if (!System.IO.File.Exists(logFilePath))
            {
                return NotFound("Log file not found.");
            }

            var logContent = System.IO.File.ReadAllText(logFilePath);
            return Content(logContent, "text/plain");
        }
    }
}
