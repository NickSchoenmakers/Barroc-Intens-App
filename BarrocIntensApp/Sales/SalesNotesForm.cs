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
using static Azure.Core.HttpHeader;
using static BarrocIntensApp.LoginForm;

namespace BarrocIntensApp.Sales
{
    public partial class SalesNotesForm : Form
    {
        public SalesNotesForm()
        {
            InitializeComponent();

            lblTitle.Text = $"Sales | {Globals.loggedInUser.Name}";

            LoadNotes(lvNotes);

            lvNotes.Items[0].Selected = true;
            Program.dbContext.Notes.Load();
            Program.dbContext.Companies.Load();
        }

        private void btnBackNotes_Click(object sender, EventArgs e)
        {
            var sales = new SalesForm();
            this.Hide();
            sales.Show(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            var company = (Company)CompNameCB.SelectedItem;
            var addNote = new Note
            {
                NoteText = txbNote.Text,
                
                Date = DateTime.Now,
                
                Author = Globals.loggedInUser
                
                

            };

            //Program.dbContext.Notes.Add(addNote);
            company.Notes.Add(addNote);
            Program.dbContext.SaveChanges();

            lvNotes.Items.Clear();
            LoadNotes(lvNotes);
        }

        static void LoadNotes(ListView listView)
        {
            var notes = (from n in Program.dbContext.Notes select n).ToList();
            foreach (var note in notes)
            {
                listView.Items.Add(new ListViewItem(note.NoteText)
                {
                    Tag = note,
                });
            }
        }

        private void lvNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNotes.SelectedIndices.Count == 0)
                return;
            var note = (Note)lvNotes.SelectedItems[0].Tag;
            if (note == null)    
                return;
            
            if (lvNotes.SelectedItems.Count > 0)
            {
                lbNoteSelected.Text = lvNotes.SelectedItems[0].Text;
                CompanyNamelbl.Text = note.Company.Name;
            }

        }

        


        private void SalesNotesLoad(object sender, EventArgs e)
        {
            
           
            this.CompNameCB.DataSource = Program.dbContext.Companies.Local.ToBindingList();
            
        }

        public void CompNameCB_SelectedValueChanged(object sender, EventArgs e)
        {
           //
        }

        private void CompNameCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var company = (Company)CompNameCB.SelectedItem;
        }

        private void noteBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void lbNoteSelected_Click(object sender, EventArgs e)
        {

        }
    }
}
