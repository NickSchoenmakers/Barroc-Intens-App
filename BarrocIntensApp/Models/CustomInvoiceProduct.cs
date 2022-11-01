﻿using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarrocIntensApp.Models
{
    public class CustomInvoiceProduct
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = null;
        public int Amount { get; set; }
        //public int CustomInvoiceId { get; set; }
        public ObservableCollectionListSource<CustomInvoice> CustomInvoice { get; } = new ObservableCollectionListSource<CustomInvoice>();

        public override string ToString(){}

    }
}
