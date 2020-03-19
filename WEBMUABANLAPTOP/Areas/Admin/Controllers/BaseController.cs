using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEBMUABANLAPTOP.Common;
using WEBMUABANLAPTOP.Common.CommonFuncions;

namespace WEBMUABANLAPTOP.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var session = (UserLogin)Session[CommonConstants.USER_SESSION];
            if (session == null)
            {
                filterContext.Result = new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary(new { Controller = "Login",action = "index", Areas = "Admin"}));
            }
            base.OnActionExecuting(filterContext);
        }
    }
}