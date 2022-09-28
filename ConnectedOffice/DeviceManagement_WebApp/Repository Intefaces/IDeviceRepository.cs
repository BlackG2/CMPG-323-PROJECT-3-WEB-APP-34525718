using DeviceManagement_WebApp.Controllers;
using DeviceManagement_WebApp.Models;

namespace DeviceManagement_WebApp.Repository_Intefaces
{
    public interface IDeviceRepository : IGenericRepository<Device>
    {
        Device GetMostRecentDevice();
    }
}
