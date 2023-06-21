using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWebFrameworkCore.Vendor.ConfigurationTypedClasses
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
