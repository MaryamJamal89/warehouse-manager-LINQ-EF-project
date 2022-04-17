namespace warehouse_manager_LINQ_EF_project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            PaymentOrders = new HashSet<PaymentOrder>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(10)]
        public string Phone { get; set; }

        [StringLength(15)]
        public string Mobile { get; set; }

        [StringLength(10)]
        public string Fax { get; set; }

        public string Website { get; set; }

        public string Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentOrder> PaymentOrders { get; set; }
    }
}
