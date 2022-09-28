using DeviceManagement_WebApp.Models;

namespace DeviceManagement_WebApp.Repository_Intefaces
{
    public interface ICategoriesRepository : IGenericRepository<Category>
    {
        Category GetMostRecentCategory();
    }
}
