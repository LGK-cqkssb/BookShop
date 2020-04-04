namespace BookShop.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BookShopContext : DbContext
    {
        public BookShopContext()
            : base("name=BookShopContext")
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<CartItem> CartItems { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Publish> Publishes { get; set; }
        public virtual DbSet<RoleEmpRelation> RoleEmpRelations { get; set; }
        public virtual DbSet<RoleInfo> RoleInfoes { get; set; }
        public virtual DbSet<RoleMenuRelation> RoleMenuRelations { get; set; }
        public virtual DbSet<UserInfo> UserInfoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.CartItems)
                .WithRequired(e => e.Book)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cart>()
                .Property(e => e.TotalPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Cart>()
                .HasMany(e => e.CartItems)
                .WithRequired(e => e.Cart)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CartItem>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CartItem>()
                .Property(e => e.SumPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Category>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                 .HasMany(e => e.SubCategories)      
                 .WithOptional(e => e.ParentCategory) 
                 .HasForeignKey(e => e.ParentID);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmpCode)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Avatar)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.RoleEmpRelations)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.EmpID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.Href)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .HasMany(e => e.SubMenus)
                .WithOptional(e => e.ParentMenu)
                .HasForeignKey(e => e.ParentID);

            modelBuilder.Entity<Menu>()
                .HasMany(e => e.RoleMenuRelations)
                .WithRequired(e => e.Menu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoleInfo>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<RoleInfo>()
                .HasMany(e => e.RoleEmpRelations)
                .WithRequired(e => e.RoleInfo)
                .HasForeignKey(e => e.RoleID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoleInfo>()
                .HasMany(e => e.RoleMenuRelations)
                .WithRequired(e => e.RoleInfo)
                .HasForeignKey(e => e.RoleID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.LoginName)
                .IsUnicode(false);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<UserInfo>()
                .HasMany(e => e.Carts)
                .WithRequired(e => e.UserInfo)
                .HasForeignKey(e => e.UID)
                .WillCascadeOnDelete(false);
        }
    }
}
