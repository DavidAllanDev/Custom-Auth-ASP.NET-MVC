using System.Web.Mvc;
using Custom_Auth.Web.Security;

namespace Custom_Auth.Web.Controllers
{
    public class DemoController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [CustomAuthorize(Roles = "root")]
        public ActionResult Work1()
        {
            return View("Work1");
        }

        [CustomAuthorize(Roles = "root,sudo")]
        public ActionResult Work2()
        {
            return View("Work2");
        }

        [CustomAuthorize(Roles = "root,sudo,sa")]
        public ActionResult Work3()
        {
            return View("Work3");
        }
    }
}