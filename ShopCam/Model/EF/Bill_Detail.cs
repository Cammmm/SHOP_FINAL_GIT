namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bill_Detail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? ID_Bill { get; set; }

        public int? ID_Product { get; set; }

        public int? Quantity { get; set; }

        public int? Unit_price { get; set; }
    }
}
