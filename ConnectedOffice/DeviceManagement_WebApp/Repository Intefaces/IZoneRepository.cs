using DeviceManagement_WebApp.Models;

namespace DeviceManagement_WebApp.Repository_Intefaces
{
    public interface IZoneRepository : IGenericRepository<Zone>
    {
        Zone GetMostRecentZone();
    }
}
