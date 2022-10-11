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
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int role_id { get; set; }
        public Role role { get; set; } = null;
        public ObservableCollectionListSource<Note> notes { get; } = new ObservableCollectionListSource<Note>();
        public ObservableCollectionListSource<Company> companies { get; } = new ObservableCollectionListSource<Company>();
    }
}
