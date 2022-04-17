using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using warehouse_manager_LINQ_EF_project.Models;

namespace warehouse_manager_LINQ_EF_project
{
    public partial class Model : DbContext
    {
        public Model()
            : base("name=Model")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<ExchangeOrder> ExchangeOrders { get; set; }
        public virtual DbSet<InvoiceItem> InvoiceItems { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<PaymentOrder> PaymentOrders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Provider> Providers { get; set; }
        public virtual DbSet<SupplyingOrder> SupplyingOrders { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasMany(e => e.PaymentOrders)
                .WithOptional(e => e.Customer)
                .HasForeignKey(e => e.Customer_Id);

            modelBuilder.Entity<ExchangeOrder>()
                .HasMany(e => e.Items)
                .WithOptional(e => e.ExchangeOrder)
                .HasForeignKey(e => e.ExchangeOrder_Id);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.InvoiceItems)
                .WithOptional(e => e.Item)
                .HasForeignKey(e => e.Item_Id);

            modelBuilder.Entity<PaymentOrder>()
                .HasMany(e => e.InvoiceItems)
                .WithOptional(e => e.PaymentOrder)
                .HasForeignKey(e => e.PaymentOrder_Id);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Items)
                .WithOptional(e => e.Product)
                .HasForeignKey(e => e.Product_Id);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Units)
                .WithMany(e => e.Products)
                .Map(m => m.ToTable("UnitProducts"));

            modelBuilder.Entity<Provider>()
                .HasMany(e => e.Items)
                .WithOptional(e => e.Provider)
                .HasForeignKey(e => e.Provider_Id);

            modelBuilder.Entity<Provider>()
                .HasMany(e => e.SupplyingOrders)
                .WithOptional(e => e.Provider)
                .HasForeignKey(e => e.Provider_Id);

            modelBuilder.Entity<SupplyingOrder>()
                .HasMany(e => e.Items)
                .WithOptional(e => e.SupplyingOrder)
                .HasForeignKey(e => e.SupplyingOrder_Id);

            modelBuilder.Entity<Unit>()
                .HasMany(e => e.InvoiceItems)
                .WithOptional(e => e.Unit)
                .HasForeignKey(e => e.Unit_Id);

            modelBuilder.Entity<Unit>()
                .HasMany(e => e.Items)
                .WithOptional(e => e.Unit)
                .HasForeignKey(e => e.Unit_Id);

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.ExchangeOrders)
                .WithOptional(e => e.Warehouse)
                .HasForeignKey(e => e.DestinationWarehouse_Id);

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.ExchangeOrders1)
                .WithOptional(e => e.Warehouse1)
                .HasForeignKey(e => e.SourceWarehouse_Id);

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.Items)
                .WithOptional(e => e.Warehouse)
                .HasForeignKey(e => e.Warehouse_Id);

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.PaymentOrders)
                .WithOptional(e => e.Warehouse)
                .HasForeignKey(e => e.Warehouse_Id);

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.SupplyingOrders)
                .WithOptional(e => e.Warehouse)
                .HasForeignKey(e => e.Warehouse_Id);
        }
    }
}
