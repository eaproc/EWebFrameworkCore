namespace EWebFrameworkCore.Vendor.Configurations
{
    public class LoggingOption
    {
        public SlackOption? Slack { get; set; } = null;

        public class SlackOption
        {
            public bool Enabled { get; set; } = false;
            public string Url { get; set; } = string.Empty;
            public string Channel { get; set; } = string.Empty;
        }

    }
}
