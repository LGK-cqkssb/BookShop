namespace BookShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            CartItems = new HashSet<CartItem>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        [StringLength(200)]
        public string Author { get; set; }

        public int PublisherId { get; set; }

        public DateTime PublishDate { get; set; }

        [Required]
        [StringLength(50)]
        public string ISBN { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        public string ContentDescription { get; set; }

        public string TOC { get; set; }

        public int CategoryId { get; set; }

        public int Clicks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}
