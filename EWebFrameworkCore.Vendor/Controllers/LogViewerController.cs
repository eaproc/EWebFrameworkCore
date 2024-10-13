using EWebFrameworkCore.Vendor.Services.LogViewer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Text;

namespace EWebFrameworkCore.Vendor.Controllers
{
    [Route("log-viewer")]
    public class LogViewerController : Controller
    {
        private readonly string logDirectory = PathHandlers.AppLogStore("");
        private readonly LogViewerService _logService;
        private readonly string Username;
        private readonly string Password;

        public LogViewerController(IServiceProvider provider, IConfiguration configuration) : base(provider)
        {
            _logService = new LogViewerService();

            // Load the credentials from appsettings.json
            Username = configuration["Logging:LogViewer:Username"]!;
            Password = configuration["Logging:LogViewer:Password"]!;
        }

        // Authentication method for Basic Authentication
        private bool AuthenticateUser(HttpRequest request)
        {
            if (request.Headers.ContainsKey("Authorization"))
            {
                var authHeader = request.Headers["Authorization"].ToString();
                string? encodedCredentials = authHeader.Split(' ')[1]?.Trim();
                string decodedCredentials = Encoding.UTF8.GetString(Convert.FromBase64String(encodedCredentials??string.Empty));
                var userPass = decodedCredentials.Split(':');
                string username = userPass.First();
                string password = userPass.Last();

                return username == Username && password == Password;
            }
            return false;
        }

        // Method to challenge if authentication fails
        private IActionResult ChallengeBasicAuth()
        {
            Response.Headers["WWW-Authenticate"] = "Basic realm=\"LogViewer\"";
            return Unauthorized("Invalid credentials");
        }

        // Secure the Log Viewer endpoint with Basic Authentication
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            if (!AuthenticateUser(Request))
            {
                return ChallengeBasicAuth();
            }

            return PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "log-viewer.html"), "text/html");
        }

        // List all log files
        [HttpGet]
        [Route("list-files")]
        public IActionResult ListLogFiles()
        {
            if (!AuthenticateUser(Request))
            {
                return ChallengeBasicAuth();
            }

            if (!Directory.Exists(logDirectory))
            {
                return NotFound("Log directory not found.");
            }

            var logFiles = Directory.GetFiles(logDirectory, "*.log")
                                    .OrderByDescending(file => System.IO.File.GetLastWriteTime(file)) // Order by last modified date
                                    .Select(file => new
                                    {
                                        FileName = Path.GetFileName(file),
                                        FileSize = LogViewerService.FormatFileSize(new FileInfo(file).Length) // Get file size
                                    })
                                    .ToList();

            return new JsonResult(logFiles);
        }

        // View log file content
        [HttpGet]
        [Route("view-file")]
        public IActionResult GetLogFileContent([FromQuery] string fileName, [FromQuery] string level = "ALL", [FromQuery] int page = 1, [FromQuery] int size = 20)
        {
            if (!AuthenticateUser(Request))
            {
                return ChallengeBasicAuth();
            }

            var logFilePath = Path.Combine(logDirectory, fileName);

            if (!System.IO.File.Exists(logFilePath))
            {
                return NotFound("Log file not found.");
            }

            Dictionary<string, int> levelSummary; // Overall summary
            int filteredTotal; // Filtered total

            var parsedLogs = _logService.ParseLogFile(logFilePath, level, page, size, out levelSummary, out filteredTotal);

            return Ok(new
            {
                totalEntries = levelSummary, // Overall summary
                filteredTotal = filteredTotal, // Filtered total
                currentPage = page,
                pageSize = size,
                logs = parsedLogs
            });
        }
    }
}
