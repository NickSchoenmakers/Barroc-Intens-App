using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarrocIntensApp.Models
{
    internal class CustomInvoiceProduct
    {
        public int id { get; set; }
        public int product_id { get; set; }
        public int amount { get; set; }
        public decimal price_per_product { get; set; }
    }
}
