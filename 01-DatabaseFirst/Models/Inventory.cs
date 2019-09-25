using System;
using System.Collections.Generic;

namespace _01_DatabaseFirst.Models
{
    public partial class Inventory
    {
        public int? ProductId { get; set; }
        public string Row { get; set; }
        public int? Position { get; set; }
        public int? Count { get; set; }
        public DateTime? TransactionDate { get; set; }
        public int LocationId { get; set; }

        public virtual Products Product { get; set; }
    }
}
