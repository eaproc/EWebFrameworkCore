using EWebFrameworkCore.Vendor;
using Serilog.Events;
using Serilog.Formatting;
using System.Text.Json;

namespace EWebFrameworkCore.Vendor.Logging
{
    public class SerilogPrettyJsonFormatter : ITextFormatter
    {
        public void Format(LogEvent logEvent, TextWriter output)
        {
            try
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                var data = new
                {
                    Timestamp = logEvent.Timestamp.UtcDateTime,
                    Level = logEvent.Level.ToString(),
                    Message = logEvent.RenderMessage(),
                    Exception = logEvent.Exception?.ToString(),
                    Properties = logEvent.Properties.ToDictionary(p => p.Key, p => p.Value.ToString())
                };

                string json = JsonSerializer.Serialize(data, options);
                output.WriteLine(json);
            }
            catch (Exception ex)
            {
                // If you catch an exception here, it might help diagnose the problem
                output.WriteLine($"Error formatting log: {ex.Message}");
            }
        }
    }

}
