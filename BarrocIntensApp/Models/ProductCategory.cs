using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarrocIntensApp.Models
{
    internal class ProductCategory
    {
        public int id { get; set; }
        public string name { get; set; }
        public int is_employee_only { get; set; }
        public ObservableCollectionListSource<Product> products { get; } = new ObservableCollectionListSource<Product>();
    }
}
