using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarrocIntensApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; } = null;
        public decimal Price { get; set; }
        public int ProductCategoryId { get; set; }
        public int Stock { get; set; }
        public bool isPart {get; set;}
        public ProductCategory ProductCategory { get; set; } = null;
        public ObservableCollectionListSource<CustomInvoiceProduct> CustomInvoiceProducts { get; } = new ObservableCollectionListSource<CustomInvoiceProduct>();
    }
}
