using EWebFrameworkCore.Vendor.Configurations;
using EWebFrameworkCore.Vendor.Services;

namespace EWebFrameworkCore.Dev.DBEntities
{
    /// <summary>
    /// 
    /// </summary>
    public class ClientService : BaseClientService
    {
        public ClientService(MSSQLConnectionOption connectionOption): base(connectionOption)
        {
        }
    }
}