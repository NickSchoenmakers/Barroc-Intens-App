using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarrocIntensApp.Models
{
    internal class CustomInvoice
    {
        public string id { get; set; }
        public DateTime date { get; set; }
        public DateTime paid_at { get; set; }
        public int company_id { get; set; }
        public Company company { get; set; } = null;
        public ObservableCollectionListSource<CustomInvoiceProduct> custom_invoice_products { get; } = new ObservableCollectionListSource<CustomInvoiceProduct>();
    }
}
