namespace warehouse_manager_LINQ_EF_project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ExchangeOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExchangeOrder()
        {
            Items = new HashSet<Item>();
        }

        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public int? DestinationWarehouse_Id { get; set; }

        public int? SourceWarehouse_Id { get; set; }

        public virtual Warehouse Warehouse { get; set; }

        public virtual Warehouse Warehouse1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item> Items { get; set; }
        public Warehouse SourceWarehouse { get; internal set; }
        public Warehouse DestinationWarehouse { get; internal set; }
    }
}
