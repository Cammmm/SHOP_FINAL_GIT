namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bill
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? ID_Customer { get; set; }

        public DateTime? Date_order { get; set; }

        public int? Total { get; set; }

        [StringLength(200)]
        public string Payment { get; set; }

        [StringLength(500)]
        public string Note { get; set; }
    }
}
