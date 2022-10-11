using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarrocIntensApp.Models
{
    internal class Company
    {
        public int id { get; set; }
        public string name { get; set; }
        public string street { get; set; }
        public string house_number { get; set; }
        public string city { get; set; }
        public string country_code { get; set; }
        public DateTime bkr_checked_at { get; set; }
        public string contact_name { get; set; }
        public string contact_phonenumber { get; set; }
        public ObservableCollectionListSource<Note> notes { get; } = new ObservableCollectionListSource<Note>();
        public ObservableCollectionListSource<MaintenanceAppointment> maintenance_appointments { get; } = new ObservableCollectionListSource<MaintenanceAppointment>();
        public ObservableCollectionListSource<CustomInvoice> custom_invoices { get; } = new ObservableCollectionListSource<CustomInvoice>();
    }
}
