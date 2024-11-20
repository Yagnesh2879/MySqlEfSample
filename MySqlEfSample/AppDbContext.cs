namespace MySqlEfSample
{
    using Microsoft.EntityFrameworkCore;
    using MySqlEfSample.DBModels;
    using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
    using System.Net;

    public class AppDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public DbSet<CustomerPaymentInfo> CustomerPaymentInfos { get; set; }
        public DbSet<CustomerBussines> CustomerBussineses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "Server=localhost;Database=CustomerDb;User ID=root;Password=Admin1;",
                new MySqlServerVersion(new Version(8, 0, 40)) // Replace with your MySQL version, Password, DBName, Server
            );

            //Commnad to Execute
            //1. Add-Migration InitialCreate //This will create Migration
            //2. Update-Database //this will create DB in MySql
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Address relationship
            modelBuilder.Entity<CustomerAddress>()
                .HasOne(a => a.Customer)
                .WithMany(c => c.Addresses)
                .HasForeignKey(a => a.CustomerId);

            // PaymentInfo relationship
            modelBuilder.Entity<CustomerPaymentInfo>()
                .HasOne(p => p.Customer)
                .WithMany(c => c.PaymentInfos)
                .HasForeignKey(p => p.CustomerId);

            // Company relationship
            modelBuilder.Entity<CustomerBussines>()
            .HasOne(c => c.Customer)
                .WithOne(c => c.BusinessInfo)
                .HasForeignKey<CustomerBussines>(c => c.CustomerId);
        }
    }
}
