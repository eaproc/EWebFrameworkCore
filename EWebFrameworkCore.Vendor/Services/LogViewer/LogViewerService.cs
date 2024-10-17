using System.Globalization;

namespace EWebFrameworkCore.Vendor.Services.LogViewer
{
    public class LogViewerService
    {

    public List<LogEntry> ParseLogFile(string logFilePath, string levelFilter, int page, int size, out Dictionary<string, int> levelSummary, out int filteredTotal)
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

            List<LogEntry> totalFilteredLogs = new List<LogEntry>(); // Store logs matching the filter
            string currentLog = string.Empty;

        // Open the log file in shared read mode to avoid locking issues
        using (var fileStream = new FileStream(logFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
        using (var reader = new StreamReader(fileStream))
        {
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                if (IsTimestampedLine(line)) // New log entry starts here
                {
                    if (!string.IsNullOrEmpty(currentLog))
                    {
                        var logEntry = ParseLogEntry(currentLog);
                        if (logEntry != null)
                        {
                            // Update overall summary for all logs (unfiltered)
                            UpdateLevelSummary(levelSummary, logEntry);

                            // Apply filter and collect filtered logs
                            if (levelFilter == "ALL" || logEntry.Level.Equals(levelFilter, StringComparison.OrdinalIgnoreCase))
                            {
                                totalFilteredLogs.Add(logEntry); // Collect only the filtered logs
                            }
                        }
                    }
                    currentLog = line; // Start a new log entry
                }
                else
                {
                    // Append multiline content to the current log entry
                    currentLog += "\n" + line;
                }
            }

            // Handle the last log entry
            if (!string.IsNullOrEmpty(currentLog))
            {
                var logEntry = ParseLogEntry(currentLog);
                if (logEntry != null)
                {
                    // Update overall summary for all logs (unfiltered)
                    UpdateLevelSummary(levelSummary, logEntry);

                    // Apply filter and collect filtered logs
                    if (levelFilter == "ALL" || logEntry.Level.Equals(levelFilter, StringComparison.OrdinalIgnoreCase))
                    {
                        totalFilteredLogs.Add(logEntry); // Collect only the filtered logs
                    }
                }
            }
        }

        // Set the total filtered count for pagination
        filteredTotal = totalFilteredLogs.Count;

            // Return only the logs matching the filter and apply pagination
            // Change the order before skipping, show latest entries first
            totalFilteredLogs.Reverse(); 

        return totalFilteredLogs
                .Skip((page - 1) * size)
                .Take(size)
                .ToList();
    }

    private static bool IsTimestampedLine(string line)
        {
            // Detect if the line starts with a timestamp in the format "yyyy-MM-dd HH:mm:ss"
            DateTime timestamp;
            if (line.Length < 24) return false;
            return DateTime.TryParseExact(line.Substring(0, 23), "yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture, DateTimeStyles.None, out timestamp);
        }

        private static void UpdateLevelSummary(Dictionary<string, int> levelSummary, LogEntry logEntry)
        {
            // Normalize level and update the overall summary
            var normalizedLevel = NormalizeLogLevel(logEntry.Level);
            if (levelSummary.ContainsKey(normalizedLevel))
            {
                levelSummary[normalizedLevel]++;
            }
            else
            {
                levelSummary["Unknown"]++;
            }
        }

        private static LogEntry? ParseLogEntry(string log)
        {
            // Split the log into time, level, and message by checking the first timestamp and level brackets
            var timestampEndIndex = log.IndexOf(" [");
            if (timestampEndIndex == -1)
            {
                return null; // Prevent empty logs with no time or level
            }

            var levelStartIndex = log.IndexOf("[", timestampEndIndex) + 1;
            var levelEndIndex = log.IndexOf("]", levelStartIndex);

            if (levelStartIndex == -1 || levelEndIndex == -1)
            {
                return null; // Prevent logs with missing level
            }

            var time = log.Substring(0, timestampEndIndex).Trim();
            var level = log.Substring(levelStartIndex, levelEndIndex - levelStartIndex).Trim();
            var message = log.Substring(levelEndIndex + 1).Trim();

            // Return null if message is empty
            if (string.IsNullOrWhiteSpace(message))
            {
                return null;
            }

            return new LogEntry(time, NormalizeLogLevel(level), message);
        }

        // Normalize log level (e.g., INF -> info, ERR -> error)
        private static string NormalizeLogLevel(string level)
        {
            switch (level.ToUpper())
            {
                case "INF":
                    return "Info";
                case "ERR":
                    return "Error";
                case "WRN":
                    return "Warning";
                case "DBG":
                    return "Debug";
                default:
                    return level;
            }
        }

        // Helper method to format file size into human-readable form
        public static string FormatFileSize(long bytes)
        {
            if (bytes >= 1024 * 1024)
                return $"{(bytes / 1024f / 1024f):0.##} MB";
            else if (bytes >= 1024)
                return $"{(bytes / 1024f):0.##} KB";
            else
                return $"{bytes} bytes";
        }
    }

    // LogEntry as a record
    public record LogEntry(string Time, string Level, string RawMessage);
}
