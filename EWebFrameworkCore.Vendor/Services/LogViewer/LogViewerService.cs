using System.Text.RegularExpressions;

namespace EWebFrameworkCore.Vendor.Services.LogViewer
{

    public class LogViewerService
    {
        public List<LogEntry> ParseLogFile(string logFilePath, string levelFilter, int page, int size, out Dictionary<string, int> levelSummary)
        {
            var parsedLogs = new List<LogEntry>();
            levelSummary = new Dictionary<string, int>
            {
                { "Error", 0 },
                { "Warning", 0 },
                { "Info", 0 },
                { "Debug", 0 },
                { "Unknown", 0 }
            };

            var logContent = System.IO.File.ReadAllLines(logFilePath);
            string currentLog = string.Empty;

            foreach (var line in logContent)
            {
                if (Regex.IsMatch(line, @"^\d{4}-\d{2}-\d{2}")) // Matches lines starting with timestamp
                {
                    if (!string.IsNullOrEmpty(currentLog))
                    {
                        var logEntry = ParseLogEntry(currentLog);
                        if (logEntry != null)
                        {
                            if (levelFilter == "ALL" || logEntry.Level.Equals(levelFilter, StringComparison.OrdinalIgnoreCase))
                            {
                                parsedLogs.Add(logEntry);
                            }

                            // Update the level summary
                            if (levelSummary.ContainsKey(logEntry.Level))
                            {
                                levelSummary[logEntry.Level]++;
                            }
                            else
                            {
                                levelSummary["Unknown"]++;
                            }
                        }
                    }
                    currentLog = line; // Start a new log entry
                }
                else
                {
                    // Append multiline logs to the current log entry
                    currentLog += "\n" + line;
                }
            }

            // Handle the last entry
            if (!string.IsNullOrEmpty(currentLog))
            {
                var logEntry = ParseLogEntry(currentLog);
                if (logEntry != null)
                {
                    if (levelFilter == "ALL" || logEntry.Level.Equals(levelFilter, StringComparison.OrdinalIgnoreCase))
                    {
                        parsedLogs.Add(logEntry);
                    }
                    if (levelSummary.ContainsKey(logEntry.Level))
                    {
                        levelSummary[logEntry.Level]++;
                    }
                    else
                    {
                        levelSummary["Unknown"]++;
                    }
                }
            }

            // Apply pagination
            return parsedLogs.Skip((page - 1) * size).Take(size).ToList();
        }

        private static LogEntry ParseLogEntry(string log)
        {
            var logParts = Regex.Match(log, @"^(\d{4}-\d{2}-\d{2}.*? \[\w{3}\])\s(.*)$");
            var time = logParts.Success ? logParts.Groups[1].Value : "Unknown Time";
            var level = logParts.Success ? Regex.Match(logParts.Groups[1].Value, @"\[(.*?)\]").Groups[1].Value : "Unknown";
            var message = logParts.Success ? logParts.Groups[2].Value : log;

            return new LogEntry(time, level, message);
        }
    }
    public record LogEntry(string Time, string Level, string RawMessage);

}
