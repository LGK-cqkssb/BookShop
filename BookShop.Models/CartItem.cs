namespace BookShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CartItem")]
    public partial class CartItem
    {
        public int ID { get; set; }

        public int CartID { get; set; }

        public int BookID { get; set; }

        public int Count { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal SumPrice { get; set; }

        public virtual Book Book { get; set; }

        public virtual Cart Cart { get; set; }
    }
}
