using BarrocIntensApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BarrocIntensApp.LoginForm;

namespace BarrocIntensApp.Maintenance
{
    public partial class MaintenanceCreateWerkbonForm : Form
    {
        private MaintenanceAppointment maintenanceAppointment;
        private MaintenanceAppointmentWorkOrder maintenanceAppointmentWorkOrderToAdd;
        public MaintenanceAppointmentWorkOrder workOrderCreated;

        public MaintenanceCreateWerkbonForm(MaintenanceAppointment maintenanceAppointment)
        {
            InitializeComponent();
            this.cboParts.DataSource = Program.dbContext.Products.Where(p => p.isPart).ToList();
            this.maintenanceAppointment = maintenanceAppointment;

            maintenanceAppointmentWorkOrderToAdd = new MaintenanceAppointmentWorkOrder();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            MaintenanceAppointmentWorkOrderProduct maintenanceAppointmentWorkOrderProductToAdd = new MaintenanceAppointmentWorkOrderProduct()
            {
                Product = (Product)cboParts.SelectedItem,
                Amount = (int)numAmount.Value
            };
            maintenanceAppointmentWorkOrderToAdd.MaintenanceAppointmentWorkOrderProducts.Add(maintenanceAppointmentWorkOrderProductToAdd);
            this.dgvParts.Rows.Add(maintenanceAppointmentWorkOrderProductToAdd.Product.Name, maintenanceAppointmentWorkOrderProductToAdd.Amount);

        }

        private void btnAddWorkOrder_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbDescription.Text))
            {
                maintenanceAppointmentWorkOrderToAdd.Description = txbDescription.Text;
            }

            maintenanceAppointment.MaintenanceAppointmentWorkOrder = maintenanceAppointmentWorkOrderToAdd;
            Program.dbContext.SaveChanges();
            if (dgvParts.Rows.Count > 0 || !string.IsNullOrEmpty(txbDescription.Text)) {
                workOrderCreated = maintenanceAppointmentWorkOrderToAdd;
                this.Close();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e) {
            dgvParts.Rows.RemoveAt(dgvParts.SelectedCells[0].RowIndex);
            btnRemove.Visible = false;
            dgvParts.ClearSelection();
        }

        private void dgvParts_SelectionChanged(object sender, EventArgs e) {
            if (dgvParts.SelectedCells.Count > 0) {
                btnRemove.Visible = true;
            }
        }
    }
}
