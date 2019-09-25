using System.Collections.Generic;
using System.Threading.Tasks;
using _01_DatabaseFirst.Models;

namespace _01_DatabaseFirst.Repositories
{
    public interface IInventoryRepo
    {
        Task<IEnumerable<Inventory>> GetAllLocationsAsync();
        Task<IEnumerable<Inventory>> SearchInventoriesByLocationAsync(string row, int position);
        Task<IEnumerable<Inventory>> SearchInventoriesByProductNameAsync(string productName);
    }
}