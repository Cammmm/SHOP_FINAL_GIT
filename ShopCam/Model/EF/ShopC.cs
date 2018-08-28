namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ShopC : DbContext
    {
        public ShopC()
            : base("name=ShopC")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
