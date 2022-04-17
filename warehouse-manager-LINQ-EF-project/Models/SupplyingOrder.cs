namespace warehouse_manager_LINQ_EF_project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SupplyingOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SupplyingOrder()
        {
            Items = new HashSet<Item>();
        }

        public int Id { get; set; }

        public string Number { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public int? Provider_Id { get; set; }

        public int? Warehouse_Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item> Items { get; set; }

        public virtual Provider Provider { get; set; }

        public virtual Warehouse Warehouse { get; set; }
    }
}
