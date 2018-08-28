using ShopCam.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ShopCam.Areas.AdminUsers.Controllers
{
    public class BaseController : Controller
    {
        // GET: AdminUsers/Base
        
         
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var session = (UserLogin)Session[CommonConstants.USER_SESSION];
            if (session == null)
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(
                    new { Controller = "login", Action = "index", Area = "AdminUsers" }));
            }
            base.OnActionExecuting(filterContext);
        }
    }
}