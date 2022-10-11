using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarrocIntensApp.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public ObservableCollectionListSource<Note> Notes { get; } = new ObservableCollectionListSource<Note>();
        public ObservableCollectionListSource<Company> Companies { get; } = new ObservableCollectionListSource<Company>();
    }
}
