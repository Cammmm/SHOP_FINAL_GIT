using ShopCam.Areas.AdminUsers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAO.DAO;
using ShopCam.Common;

namespace ShopCam.Areas.AdminUsers.Controllers
{
    public class LoginController : Controller
    {
        //[ActionName("Login")]
        // GET: AdminUsers/Login
        public ActionResult Index()
        {
            ViewBag.Title = "Login";
            return View();
        }

        
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDAO();
                var result = dao.Login(model.Username, model.Password);
                // result   = 1     Đúng hết điều kiên
                // result   = 0     Sai ID
                // result   = -1    Đúng ID sai Mật khẩu
                if (result == 1) 
                {
                    var user = dao.GetbyID(model.Username);
                    var userSession = new UserLogin();
                    userSession.UserID = user.Username;
                    userSession.Fullname = user.Fullname;
                    Session.Add(CommonConstants.USER_SESSION, userSession);
                  
                    return RedirectToAction("Index", "Home");  
                }
                else if (result == 0)
                {
                    ModelState.AddModelError("error", "Username không tồn tại.");
                }
                else
                {
                    ModelState.AddModelError("error", "Sai mật khẩu.");
                }
            }
            else
            {
                ModelState.AddModelError("error", "Đăng nhập không đúng!");
            }
            return View("Index");
        }
    }
}