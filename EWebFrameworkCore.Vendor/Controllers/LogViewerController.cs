﻿using EWebFrameworkCore.Vendor.Services.LogViewer;
using Microsoft.AspNetCore.Mvc;

namespace EWebFrameworkCore.Vendor.Controllers
{
    [Route("log-viewer")]
    public class LogViewerController : Controller
    {
        private readonly string logDirectory = PathHandlers.AppLogStore("");
        private readonly LogViewerService _logService;

        public LogViewerController(IServiceProvider provider) : base(provider) {
            _logService = new LogViewerService();
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "log-viewer.html"), "text/html");
        }

        [HttpGet]
        [Route("list-files")]
        public IActionResult ListLogFiles()
        {
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


        [HttpGet]
        [Route("view-file")]
        public IActionResult GetLogFileContent([FromQuery] string fileName, [FromQuery] string level = "ALL", [FromQuery] int page = 1, [FromQuery] int size = 20)
        {
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
