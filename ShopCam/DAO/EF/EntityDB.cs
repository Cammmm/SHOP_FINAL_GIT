namespace DAO.EF
{
    using System.Data.Entity;

    public partial class EntityDB : DbContext
    {
        public EntityDB()
            : base("name=EntityDB")
        {
        }

        public virtual DbSet<Bill_Detail> Bill_Detail { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Slide> Slides { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
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

            modelBuilder.Entity<Customer>()
                .Property(e => e.Img)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.Total_buy)
                .IsFixedLength();

            modelBuilder.Entity<News>()
                .Property(e => e.tContent)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.Image)
                .IsUnicode(false);

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
                .Property(e => e.Username)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Remember_token)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Img)
                .IsFixedLength();
        }
    }
}
