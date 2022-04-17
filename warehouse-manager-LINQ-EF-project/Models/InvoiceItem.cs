namespace warehouse_manager_LINQ_EF_project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class InvoiceItem
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        public int? Item_Id { get; set; }

        public int? PaymentOrder_Id { get; set; }

        public int? Unit_Id { get; set; }

        public virtual Item Item { get; set; }

        public virtual PaymentOrder PaymentOrder { get; set; }

        public virtual Unit Unit { get; set; }
    }
}
