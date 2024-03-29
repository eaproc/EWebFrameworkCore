﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWebFrameworkCore.Vendor.Configurations
{
    public class MSSQLConnectionOption
    {
        public string HOST { get; set; } = @"localhost\SQLSERVER2016";
        public int PORT { get; set; } = 1433;
        public string DATABASE_NAME { get; set; }
        public string DATABASE_USER_NAME { get; set; } = "sa";
        public string DATABASE_USER_PASSWORD { get; set; }

    }
}
