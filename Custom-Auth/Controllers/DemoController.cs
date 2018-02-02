using System.Web.Mvc;
using Custom_Auth.Web.Security;

namespace Custom_Auth.Web.Controllers
{
    public class DemoController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index() => View();

        [CustomAuthorize(Roles = "root")]
        public ActionResult Work1() => View("Work1");

        [CustomAuthorize(Roles = "root,sudo")]
        public ActionResult Work2() => View("Work2");

        [CustomAuthorize(Roles = "root,sudo,sa")]
        public ActionResult Work3() => View("Work3");
    }
}