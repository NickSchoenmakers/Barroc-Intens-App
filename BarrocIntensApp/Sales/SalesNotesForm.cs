using BarrocIntensApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        }

        private void btnBackNotes_Click(object sender, EventArgs e)
        {
            var sales = new SalesForm();
            this.Hide();
            sales.Show(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var addNote = new Note
            {
                NoteText = txbNote.Text,
                Date = DateTime.Now,
                CompanyId = 1,
                AuthorId = Globals.loggedInUser.Id
            };

            Program.dbContext.Notes.Add(addNote);
            Program.dbContext.SaveChanges();

            lvNotes.Items.Clear();
            LoadNotes(lvNotes);
        }

        static void LoadNotes(ListView listView)
        {
            var notes = (from n in Program.dbContext.Notes select n).ToList();
            foreach (var note in notes)
            {
                listView.Items.Add(note.NoteText);
            }
        }

        private void lvNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNotes.SelectedItems.Count > 0)
            {
                lbNoteSelected.Text = lvNotes.SelectedItems[0].Text;
            }
        }
    }
}
