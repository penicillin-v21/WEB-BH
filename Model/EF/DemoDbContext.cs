namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DemoDbContext : DbContext
    {
        public DemoDbContext()
            : base("name=DemoDbContext")
        {
        }

        public virtual DbSet<BILLIN> BILLINs { get; set; }
        public virtual DbSet<CART> CARTS { get; set; }
        public virtual DbSet<CATEGORy> CATEGORIES { get; set; }
        public virtual DbSet<DETAILBILLIN> DETAILBILLINs { get; set; }
        public virtual DbSet<ORDERDETAIL> ORDERDETAILS { get; set; }
        public virtual DbSet<ORDER> ORDERS { get; set; }
        public virtual DbSet<PRODUCT> PRODUCTS { get; set; }
        public virtual DbSet<PROVIDER> PROVIDERS { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<USER> USERS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BILLIN>()
                .HasMany(e => e.DETAILBILLINs)
                .WithRequired(e => e.BILLIN)
                .HasForeignKey(e => e.BillId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CATEGORy>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CATEGORy>()
                .Property(e => e.SortOrder)
                .IsUnicode(false);

            modelBuilder.Entity<CATEGORy>()
                .Property(e => e.ParentId)
                .IsFixedLength();

            modelBuilder.Entity<ORDER>()
                .Property(e => e.ShipPhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER>()
                .HasMany(e => e.ORDERDETAILS)
                .WithRequired(e => e.ORDER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUCT>()
                .HasMany(e => e.DETAILBILLINs)
                .WithRequired(e => e.PRODUCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUCT>()
                .HasMany(e => e.ORDERDETAILS)
                .WithRequired(e => e.PRODUCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PROVIDER>()
                .HasMany(e => e.DETAILBILLINs)
                .WithOptional(e => e.PROVIDER)
                .HasForeignKey(e => e.ProciderId);

            modelBuilder.Entity<Role>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.USERS)
                .WithMany(e => e.Roles)
                .Map(m => m.ToTable("USERROLES").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<USER>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.Email)
                .IsUnicode(false);
        }
    }
}
