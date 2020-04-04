namespace BookShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoleEmpRelation")]
    public partial class RoleEmpRelation
    {
        public int ID { get; set; }

        public int EmpID { get; set; }

        public int RoleID { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual RoleInfo RoleInfo { get; set; }
    }
}
