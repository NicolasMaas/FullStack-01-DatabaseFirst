using _01_DatabaseFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_DatabaseFirst.Repositories
{
    public class InventoryRepo : IInventoryRepo
    {
        private readonly SalesDBContext _context;
        public InventoryRepo(SalesDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Inventory>> GetAllLocationsAsync()
        {
            //Queryable heeft geen async definitie => must ToListAsync() 
            return await _context.Inventory
                .OrderBy(i => i.LocationId)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<IEnumerable<Inventory>> SearchInventoriesByLocationAsync(string row, int position)
        {
            return await _context.Inventory
                .Include(i => i.Product)
                .Where(i => i.Row == row && i.Position == position)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<IEnumerable<Inventory>> SearchInventoriesByProductNameAsync(string productName)
        {
            return await _context.Inventory
                .Include(i => i.Product)
                .Where(i => i.Product.Name.Contains(productName))
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
