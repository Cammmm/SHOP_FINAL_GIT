using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShopCam.Areas.AdminUsers.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Mời nhập UserName")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Mời nhập Password")]
        public string Password { get; set; }


        public bool Rememberme { get; set; }
    }
}