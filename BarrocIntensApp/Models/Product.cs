using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarrocIntensApp.Models
{
    internal class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string image_path { get; set; }
        public decimal price { get; set; }
        public int product_category_id { get; set; }
        public ProductCategory product_category { get; set; } = null;
        public ObservableCollectionListSource<CustomInvoiceProduct> custom_invoice_products { get; } = new ObservableCollectionListSource<CustomInvoiceProduct>();
    }
}
