using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Repository_Intefaces;
using Microsoft.AspNetCore.Mvc.Controllers;
using System.Linq;

namespace DeviceManagement_WebApp.Repository_Classes
{
    public class DeviceRepository : GenericRepository<Device>, IDeviceRepository
    {
        public DeviceRepository(ConnectedOfficeContext context): base(context)
        {
        }

        public Device GetMostRecentDevice()
        {
            return _context.Device.OrderByDescending(Device => Device.DateCreated).FirstOrDefault();
        }
    }
}
