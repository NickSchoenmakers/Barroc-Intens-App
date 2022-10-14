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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BarrocIntensApp.Sales
{
    public partial class SalesNotesForm : Form
    {
        public SalesNotesForm()
        {
            InitializeComponent();
            var notes = (from n in Program.dbContext.Notes select n).ToList();
            foreach (var note in notes)
            {
                lvNotes.Items.Add(note.NoteText);
            }
        }

        private void btnBackNotes_Click(object sender, EventArgs e)
        {
            var sales = new SalesForm();
            this.Hide();
            sales.Show(this);
        }
    }
}
