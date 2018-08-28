using DAO.DAO;
using DAO.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopCam.Areas.AdminUsers.Controllers
{
    public class UserController : Controller 
    {
        // GET: AdminUsers/User
        [HttpGet]
        public ActionResult Index(string txtSearch,int page = 1, int pageSize = 2)
        {
            var dao = new UserDAO();
            var Model = dao.ListALl(txtSearch,page, pageSize);
            ViewBag.txtSearch = txtSearch;  
            return View(Model);
        }
        #region Insert 

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            var dao = new UserDAO();
            string id = dao.Insert(user);
            if (id!=null)
            {
                return RedirectToAction("Index", "User");
            }
            else
            {

            }

            return View("Index");
        }

        public ActionResult Insert()
        {
            return View();
        }
        #endregion

        #region Edit
        [HttpGet]
        public ActionResult Edit(string id)
        {
            var userDAO = new UserDAO().ViewDetail(id);
            return View(userDAO);
        }
        [HttpPost]
        public ActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDAO();
                bool result = dao.Update(user);
                if (result)
                {
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    ModelState.AddModelError("", "Cập nhập user không thành công.!");
                }
            }
            return View("Index");
        }
        #endregion

        #region Delete
        public ActionResult Delete(string id)
        {
            bool dao = new UserDAO().Delete(id);
            return RedirectToAction("Index");
        }
        #endregion
    }


}