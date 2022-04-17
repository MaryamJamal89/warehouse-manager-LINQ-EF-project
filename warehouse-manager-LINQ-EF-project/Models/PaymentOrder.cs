namespace warehouse_manager_LINQ_EF_project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PaymentOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PaymentOrder()
        {
            InvoiceItems = new HashSet<InvoiceItem>();
        }

        public int Id { get; set; }

        public string Number { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public int? Customer_Id { get; set; }

        public int? Warehouse_Id { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceItem> InvoiceItems { get; set; }

        public virtual Warehouse Warehouse { get; set; }
    }
}
