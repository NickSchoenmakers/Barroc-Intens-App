using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarrocIntensApp.Models
{
    public class AppDbContext : DbContext
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
            // Deze lijn uncommenten voor db logs
            //optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseMySql
                ("server=localhost;database=barroc_intens_app;user=root;password=;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Inkoop Gebruiker 1", Username = "inkoop1", Password = "pass", RoleId = 1 },
                new User { Id = 2, Name = "Inkoop Gebruiker 2", Username = "inkoop2", Password = "pass", RoleId = 1 },
                new User { Id = 3, Name = "Inkoop Gebruiker 3", Username = "inkoop3", Password = "pass", RoleId = 1 },
                new User { Id = 4, Name = "Maintenance Gebruiker 1", Username = "maintenance1", Password = "pass", RoleId = 2 },
                new User { Id = 5, Name = "Maintenance Gebruiker 2", Username = "maintenance2", Password = "pass", RoleId = 2 },
                new User { Id = 6, Name = "Maintenance Gebruiker 3", Username = "maintenance3", Password = "pass", RoleId = 2 },
                new User { Id = 7, Name = "Sales Gebruiker 1", Username = "sales1", Password = "pass", RoleId = 3 },
                new User { Id = 8, Name = "Sales Gebruiker 2", Username = "sales2", Password = "pass", RoleId = 3 },
                new User { Id = 9, Name = "Sales Gebruiker 3", Username = "sales3", Password = "pass", RoleId = 3 },
                new User { Id = 10, Name = "Finance Gebruiker 1", Username = "finance1", Password = "pass", RoleId = 4 },
                new User { Id = 11, Name = "Finance Gebruiker 2", Username = "finance2", Password = "pass", RoleId = 4 },
                new User { Id = 12, Name = "Finance Gebruiker 3", Username = "finance3", Password = "pass", RoleId = 4 }
            );

            modelBuilder.Entity<Role>().HasData(
                    new Role { Id = 1, Name = "Inkoop" },
                    new Role { Id = 2, Name = "Maintenance" },
                    new Role { Id = 3, Name = "Sales" },
                    new Role { Id = 4, Name = "Finance" }
            );

            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "Bedrijf 1", Street = "Bredaweg", HouseNumber = "23", City = "Breda", CountryCode = "NL", BkrCheckedAt = new DateTime(2022, 01, 25), ContactName = "Jan Bedrijfsel", ContactPhoneNumber = "+31618476837" },
                new Company { Id = 2, Name = "Bedrijf 2", Street = "Tilburgweg", HouseNumber = "55", City = "Tilburg", CountryCode = "NL", BkrCheckedAt = new DateTime(2021, 07, 19), ContactName = "Piet Bar", ContactPhoneNumber = "0638561212" },
                new Company { Id = 3, Name = "Bedrijf 3", Street = "Ja", HouseNumber = "1", City = "Antwerpen", CountryCode = "BE", BkrCheckedAt = new DateTime(2020, 01, 10), ContactName = "Belg Jat", ContactPhoneNumber = "+3165847643" }
            );

            modelBuilder.Entity<CustomInvoice>().HasData(
                new CustomInvoice { Id = 1, Date = new DateTime(2022, 03, 22), PaidAt = new DateTime(2022, 03, 23), CompanyId = 1},
                new CustomInvoice { Id = 2, Date = new DateTime(2021, 11, 01), PaidAt = new DateTime(2021, 11, 05), CompanyId = 1},
                new CustomInvoice { Id = 3, Date = new DateTime(2022, 06, 11), PaidAt = new DateTime(2022, 06, 11), CompanyId = 2 }
            );

            modelBuilder.Entity<CustomInvoiceProduct>().HasData(
                new CustomInvoiceProduct { Id = 1, ProductId = 2, Amount = 3, PricePerProduct = 599 },
                new CustomInvoiceProduct { Id = 2, ProductId = 1, Amount = 5, PricePerProduct = 499 },
                new CustomInvoiceProduct { Id = 3, ProductId = 8, Amount = 4, PricePerProduct = 27.80m },
                new CustomInvoiceProduct { Id = 4, ProductId = 4, Amount = 3, PricePerProduct = 999 },
                new CustomInvoiceProduct { Id = 5, ProductId = 6, Amount = 2, PricePerProduct = 23.20m },
                new CustomInvoiceProduct { Id = 6, ProductId = 8, Amount = 8, PricePerProduct = 27.80m }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Barroc Intens Italian Light", Description = "S234FREKT", ImagePath = "Image/machine-bit-light.png", Price = 499, Stock = 10, ProductCategoryId = 1 },
                new Product { Id = 2, Name = "Barroc Intens Italian", Description = "S234KNDPF", ImagePath = "Image/machine-bit-light.png", Price = 599, Stock = 5, ProductCategoryId = 1 },
                new Product { Id = 3, Name = "Barroc Intens Italian Deluxe", Description = "S234KNDPF", ImagePath = "Image/machine-bit-deluxe.png", Price = 799, Stock = 7, ProductCategoryId = 1 },
                new Product { Id = 4, Name = "Barroc Intens Italian Deluxe Special", Description = "S234NNBMV", ImagePath = "Image/machine-bit-deluxe.png", Price = 999, Stock = 0, ProductCategoryId = 1 },
                new Product { Id = 5, Name = "Espresso Beneficio", Description = "S239KLIUP", Price = 21.60m, Stock = 0, ProductCategoryId = 2 },
                new Product { Id = 6, Name = "Yellow Bourbon Brasil", Description = "S239MNKLL", Price = 23.20m, Stock = 250, ProductCategoryId = 2 },
                new Product { Id = 7, Name = "Espresso Roma", Description = "S239IPPSD", Price = 20.80m, Stock = 124, ProductCategoryId = 2 },
                new Product { Id = 8, Name = "Red Honey Honduras", Description = "S239EVVFS", Price = 27.80m, Stock = 121, ProductCategoryId = 2 }
            );

            modelBuilder.Entity<MaintenanceAppointment>().HasData(
                new MaintenanceAppointment { Id = 1, CompanyId = 1, Remark = "Spullen meenemen", DateAdded = new DateTime(2022, 05, 17) },
                new MaintenanceAppointment { Id = 2, CompanyId = 2, Remark = "Kan lang duren", DateAdded = new DateTime(2021, 12, 12) },
                new MaintenanceAppointment { Id = 3, CompanyId = 3, Remark = "Kleine onderhoud nodig", DateAdded = new DateTime(2020, 06, 01) }
            );

            modelBuilder.Entity<Note>().HasData(
                new Note { Id = 1, NoteText = "Goed gesprek", Date = new DateTime(2022, 01, 22), CompanyId = 1, AuthorId = 8 },
                new Note { Id = 2, NoteText = "Matig gesprek", Date = new DateTime(2021, 07, 15), CompanyId = 2, AuthorId = 7 },
                new Note { Id = 3, NoteText = "Goed gesprek", Date = new DateTime(2020, 01, 05), CompanyId = 3, AuthorId = 8 }
            );

            modelBuilder.Entity<ProductCategory>().HasData(
                new ProductCategory { Id = 1, Name = "Machines", IsEmployeeOnly = 1 },
                new ProductCategory { Id = 2, Name = "Koffiebonen", IsEmployeeOnly = 1 }
            );
            Console.WriteLine("test");

        }
    }
}
