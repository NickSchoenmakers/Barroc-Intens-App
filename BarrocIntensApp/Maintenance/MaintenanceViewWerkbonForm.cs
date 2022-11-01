using BarrocIntensApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarrocIntensApp.Maintenance
{
    public partial class MaintenanceViewWerkbonForm : Form
    {
        public MaintenanceViewWerkbonForm(MaintenanceAppointmentWorkOrder maintenanceAppointmentWorkOrder)
        {
            InitializeComponent();
            this.lblDescription.Text = maintenanceAppointmentWorkOrder.Description;
        }

    }
}
