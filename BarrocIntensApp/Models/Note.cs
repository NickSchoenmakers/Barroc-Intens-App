using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarrocIntensApp.Models
{
    internal class Note
    {
        public int id { get; set; }
        public string note { get; set; }
        public DateTime date { get; set; }
        public int company_id { get; set; }
        public Company company { get; set; } = null;
        public int author_id { get; set; }
        public User author { get; set; } = null;
    }
}
