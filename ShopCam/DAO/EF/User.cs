namespace DAO.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        public int ID { get; set; }

        [StringLength(30)]
        public string Username { get; set; }

        public int? Usermode { get; set; }

        [StringLength(255)]
        public string Fullname { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(255)]
        public string Password { get; set; }

        [StringLength(100)]
        public string Remember_token { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        [StringLength(255)]
        public string Img { get; set; }

        public DateTime? CreateAt { get; set; }

        public DateTime? UpdateAt { get; set; }

        public bool? Active { get; set; }
    }
}
