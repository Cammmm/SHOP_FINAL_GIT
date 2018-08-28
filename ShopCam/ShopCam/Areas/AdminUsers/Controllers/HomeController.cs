using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopCam.Areas.AdminUsers.Controllers
{
    public class HomeController : BaseController
    {
        // GET: AdminUsers/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}