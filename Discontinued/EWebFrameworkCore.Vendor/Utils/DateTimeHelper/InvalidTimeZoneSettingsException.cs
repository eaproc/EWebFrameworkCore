using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EWebFrameworkCore.Vendor.Utils.DateTimeHelper
{
    public class InvalidTimeZoneSettingsException:Exception
    {

        public InvalidTimeZoneSettingsException():base("Invalid TimeZone Settings! Format: [ +/- ] HH:MM. Sample: +03:00")
        {

        }
    }
}