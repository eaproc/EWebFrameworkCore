﻿namespace EWebFrameworkCore.Vendor.Configurations
{
    public class MSSQLConnectionOption
    {
        public string HOST { get; set; } = @"localhost\SQLSERVER2016";
        public int PORT { get; set; } = 1433;
        public string DATABASE_NAME { get; set; } = string.Empty;
        public string DATABASE_USER_NAME { get; set; } = "sa";
        public string DATABASE_USER_PASSWORD { get; set; } = string.Empty;
        public bool TraceQueries { get; set; } = false;

    }
}
