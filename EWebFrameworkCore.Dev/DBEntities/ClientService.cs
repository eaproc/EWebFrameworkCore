using EWebFrameworkCore.Dev.DBEntities.DatabaseSchema;
using EWebFrameworkCore.Vendor.Configurations;
using EWebFrameworkCore.Vendor.Utils;
using System;

namespace EWebFrameworkCore.Dev.DBEntities
{
    /// <summary>
    /// 
    /// </summary>
    public class ClientService:IClientService
    {
        public ClientService(MSSQLConnectionOption connectionOption)
        {
            DatabaseInit.DBConnectInterface = new DatabaseInit(
                connectionOption.DATABASE_NAME, connectionOption.DATABASE_USER_NAME,
                connectionOption.DATABASE_USER_PASSWORD, connectionOption.PORT,
                connectionOption.HOST
                );
        }
    }
}