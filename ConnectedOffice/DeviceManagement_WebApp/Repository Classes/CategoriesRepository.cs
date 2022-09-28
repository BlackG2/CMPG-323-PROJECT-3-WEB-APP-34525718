using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Repository_Intefaces;
using Microsoft.AspNetCore.Mvc.Controllers;
using System.Linq;

namespace DeviceManagement_WebApp.Repository_Classes
{
    public class CategoriesRepository : GenericRepository<Category>, ICategoriesRepository
    {
        public CategoriesRepository(ConnectedOfficeContext context) : base(context)
        {

        }

        public Category GetMostRecentCategory()
        {
            return _context.Category.OrderByDescending(Category => Category.DateCreated).FirstOrDefault();
        }

        Category ICategoriesRepository.GetMostRecentCategory()
        {
            throw new System.NotImplementedException();
        }
    }
}
