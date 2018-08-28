using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopCam
{
    [Serializable]
    public class UserLogin
    {
        public string UserID { set; get; }
        public string Fullname { set; get; }
    }
}