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
        public DbSet<Company> Companies { get; set; }
        public DbSet<CustomInvoice> CustomInvoices { get; set; }
        public DbSet<CustomInvoiceProduct> CustomInvoiceProducts { get; set; }
        public DbSet<MaintenanceAppointment> MaintenanceAppointments { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql
                ("server=localhost;database=barroc_intens_app;user=root;password=;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Inkoop Gebruiker 1", Username = "inkoop1", Password = "pass", RoleId = 1 },
                new User { Id = 2, Name = "Inkoop Gebruiker 2", Username = "inkoop2", Password = "pass", RoleId = 1 },
                new User { Id = 3, Name = "Inkoop Gebruiker 3", Username = "inkoop3", Password = "pass", RoleId = 1 }
            );

            modelBuilder.Entity<Role>().HasData(
                    new Role { Id = 1, Name = "Inkoop" },
                    new Role { Id = 2, Name = "Maintenance" },
                    new Role { Id = 3, Name = "Sales" },
                    new Role { Id = 4, Name = "Finance" }
            );

        }
    }
}
