namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(10)]
        public string Name { get; set; }

        public int? ID_type { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        public double? Unit_price { get; set; }

        public double? Promotion_price { get; set; }

        [StringLength(255)]
        public string Image { get; set; }

        [StringLength(255)]
        public string Unit { get; set; }
    }
}
