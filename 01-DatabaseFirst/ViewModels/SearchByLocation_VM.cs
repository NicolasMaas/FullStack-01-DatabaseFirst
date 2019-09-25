using _01_DatabaseFirst.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _01_DatabaseFirst.ViewModels
{
    public class SearchByLocation_VM
    {
        [Required] 
        [RegularExpression(@"[A-E]", ErrorMessage = "Must be between A and E")] 
        public string Row { get; set; }

        [Required] 
        [Range(1, 20)] 
        public int Position { get; set; }
        public ICollection<Inventory> Inventories { get; set; }
    }
}
