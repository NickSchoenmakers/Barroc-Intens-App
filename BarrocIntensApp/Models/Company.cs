﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarrocIntensApp.Models
{
    internal class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string City { get; set; }
        public string CountryCode { get; set; }
        public DateTime BkrCheckedAt { get; set; }
        public string ContactName { get; set; }
        public string ContactPhoneNumber { get; set; }
    }
}
