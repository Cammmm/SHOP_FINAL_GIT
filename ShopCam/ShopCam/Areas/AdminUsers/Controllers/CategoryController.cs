using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopCam.Areas.AdminUsers.Controllers
{
    public class CategoryController : Controller
    {
        // GET: AdminUsers/Categoryy
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}