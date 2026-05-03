using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindUI.Models
{
    public partial class Product
    {
        public String SupplierCompany => Supplier?.CompanyName ?? "";
        public String CategoryName => Category?.CategoryName ?? "";
    }
}
