using System;
using System.Collections.Generic;

namespace _01_DatabaseFirst.Models
{
    public partial class Products
    {
        public Products()
        {
            Inventory = new HashSet<Inventory>();
            Sales = new HashSet<Sales>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }

        public virtual ICollection<Inventory> Inventory { get; set; }
        public virtual ICollection<Sales> Sales { get; set; }
    }
}
