namespace BookShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoleMenuRelation")]
    public partial class RoleMenuRelation
    {
        public int ID { get; set; }

        public int RoleID { get; set; }

        public int MenuID { get; set; }

        public virtual Menu Menu { get; set; }

        public virtual RoleInfo RoleInfo { get; set; }
    }
}
