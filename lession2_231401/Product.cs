using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lession2_231401
{
    internal class Product
    {
        public int ProductID { get; set; }
        public String ProductName { get; set; }
        public int? SupplierID { get; set; }

        public String CompanyName { get; set; }

        public String CategoryName { get; set; }
        public int? CategoryID { get; set; }
        public String? QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public Int16? UnitsInStock { get; set; }
        public Int16? UnitsOnOrder { get; set; }
        public Int16? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
    }
}
