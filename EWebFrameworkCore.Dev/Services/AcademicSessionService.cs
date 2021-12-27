using EWebFrameworkCore.Dev.DBEntities;
using EWebFrameworkCore.Dev.DBEntities.DatabaseSchema.AuxTables.AuxTables.academic;
using EWebFrameworkCore.Vendor.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EWebFrameworkCore.Dev.Services
{
    public class AcademicSessionService: ClientService
    {
        public AcademicSessionService(MSSQLConnectionOption connectionOption) : base(connectionOption)
        {

        }

        public string GetFirstRowName()
        {
            return T___AcademicSession.GetFullTable(CreateTransactionRunner()).GetFirstRow().Name;
        }

    }
}
