namespace BookShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cart")]
    public partial class Cart
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cart()
        {
            CartItems = new HashSet<CartItem>();
        }

        public int ID { get; set; }

        public int UID { get; set; }

        /// <summary>
        /// 商品种类共计
        /// </summary>
        public int ItemCount { get; set; }

        /// <summary>
        /// 商品数量共计
        /// </summary>
        public int ItemSumCount { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalPrice { get; set; }

        public virtual UserInfo UserInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}
