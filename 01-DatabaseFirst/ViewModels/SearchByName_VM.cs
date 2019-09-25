using _01_DatabaseFirst.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _01_DatabaseFirst.ViewModels
{
    public class SearchByName_VM
    {
        [Required(ErrorMessage = "Search name is required")]
        public string Name { get; set; }
        public ICollection<Products> Product { get; set; }
        public ICollection<Inventory> Inventories { get; set; }
    }
}
