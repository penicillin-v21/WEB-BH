using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEBMUABANLAPTOP.Areas.Admin.Model;
using WEBMUABANLAPTOP.Common;
using WEBMUABANLAPTOP.Common.CommonFuncions;

namespace WEBMUABANLAPTOP.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDAO();
                var res = dao.CheckLogin(model.UserName, model.Password);
                if (res)
                {
                    var user = dao.GetById(model.UserName);
                    var userSession = new UserLogin();
                    userSession.UserName = user.UserName;
                    userSession.USerId = user.Id;

                    // Add session
                    Session.Add(CommonConstants.USER_SESSION, userSession);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Login faild");
                }
            }
            return View("Index");
        }
    }
}