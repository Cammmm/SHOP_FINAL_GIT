namespace DAO.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public int? Gender { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(20)]
        public string Phone_number { get; set; }

        [StringLength(255)]
        public string Note { get; set; }

        [StringLength(255)]
        public string Img { get; set; }

        [StringLength(15)]
        public string Total_buy { get; set; }

        public DateTime? CreateAt { get; set; }

        public DateTime? UpdateAt { get; set; }
    }
}
