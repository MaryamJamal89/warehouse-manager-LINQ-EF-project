namespace warehouse_manager_LINQ_EF_project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Item()
        {
            InvoiceItems = new HashSet<InvoiceItem>();
        }

        public int Id { get; set; }

        public int AvailableQuantity { get; set; }

        public int SuppliedQuantity { get; set; }

        [Column(TypeName = "date")]
        public DateTime ProductionDate { get; set; }

        public int Expiry { get; set; }

        public int? Product_Id { get; set; }

        public int? SupplyingOrder_Id { get; set; }

        public int? Warehouse_Id { get; set; }

        public int? Provider_Id { get; set; }

        public int? Unit_Id { get; set; }

        public int? ExchangeOrder_Id { get; set; }

        public virtual ExchangeOrder ExchangeOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceItem> InvoiceItems { get; set; }

        public virtual Product Product { get; set; }

        public virtual Provider Provider { get; set; }

        public virtual SupplyingOrder SupplyingOrder { get; set; }

        public virtual Unit Unit { get; set; }

        public virtual Warehouse Warehouse { get; set; }
    }
}
