using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarrocIntensApp.Models
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Company> companies { get; set; }
        public DbSet<CustomInvoice> custom_invoices { get; set; }
        public DbSet<CustomInvoiceProduct> custom_invoice_products { get; set; }
        public DbSet<MaintenanceAppointment> maintenance_appointments { get; set; }
        public DbSet<Note> notes { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<ProductCategory> product_categories { get; set; }
        public DbSet<Role> roles { get; set; }
        public DbSet<User> users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql
                ("server=localhost;database=barroc_intens_app;user=root;password=;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { id = 1, name = "Inkoop Gebruiker 1", username = "inkoop1", password = "pass", role_id = 1 },
                new User { id = 2, name = "Inkoop Gebruiker 2", username = "inkoop2", password = "pass", role_id = 1 },
                new User { id = 3, name = "Inkoop Gebruiker 3", username = "inkoop3", password = "pass", role_id = 1 }
            );

            modelBuilder.Entity<Role>().HasData(
                    new Role { id = 1, name = "Inkoop" },
                    new Role { id = 2, name = "Maintenance" },
                    new Role { id = 3, name = "Sales" },
                    new Role { id = 4, name = "Finance" }
            );
        }
    }
}
