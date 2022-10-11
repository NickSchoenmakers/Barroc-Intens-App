using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarrocIntensApp.Models
{
    internal class Role
    {
        public int id { get; set; }
        public string name { get; set; }
        public ObservableCollectionListSource<User> users { get; } = new ObservableCollectionListSource<User>();
    }
}
