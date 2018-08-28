namespace DAO.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class News
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        [Column(TypeName = "text")]
        public string tContent { get; set; }

        [StringLength(100)]
        public string Image { get; set; }

        public DateTime? CreateAt { get; set; }

        public DateTime? UpdateAt { get; set; }
    }
}
