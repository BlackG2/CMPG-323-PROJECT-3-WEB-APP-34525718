using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Repository_Intefaces;
using System.Linq;

namespace DeviceManagement_WebApp.Repository_Classes
{
    public class ZoneRepository : GenericRepository<Zone>, IZoneRepository
    {
        public ZoneRepository(ConnectedOfficeContext context) : base(context)
        {
        }

        public Zone GetMostRecentZone()
        {
            return _context.Zone.OrderByDescending(Zone => Zone.DateCreated).FirstOrDefault();
        }
    }
}
