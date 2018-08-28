namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DB1 : DbContext
    {
        public DB1()
            : base("name=DB1")
        {
        }

        public virtual DbSet<Bill_Detail> Bill_Detail { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Slide> Slides { get; set; }
        public virtual DbSet<Type_Product> Type_Product { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bill>()
                .Property(e => e.Payment)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Phone_number)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.tContent)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<Slide>()
                .Property(e => e.Link)
                .IsUnicode(false);

            modelBuilder.Entity<Slide>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Type_Product>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Type_Product>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Remember_token)
                .IsUnicode(false);
        }
    }
}
