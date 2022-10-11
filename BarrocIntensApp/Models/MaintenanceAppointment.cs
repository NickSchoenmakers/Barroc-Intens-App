using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarrocIntensApp.Models
{
    internal class MaintenanceAppointment
    {
        public int id { get; set; }
        public int company_id { get; set; }
        public Company company { get; set; } = null;
        public string remark { get; set; }
        public DateTime date_added { get; set; }
    }
}
