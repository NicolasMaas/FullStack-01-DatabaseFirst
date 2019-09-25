using System;
using System.Collections.Generic;

namespace _01_DatabaseFirst.Models
{
    public partial class Sales
    {
        public int SalesId { get; set; }
        public int SalesPersonId { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual Products Product { get; set; }
        public virtual Employees SalesPerson { get; set; }
    }
}
