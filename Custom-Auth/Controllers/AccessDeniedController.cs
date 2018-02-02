using System.Web.Mvc;

namespace Custom_Auth.Web.Controllers
{
    public class AccessDeniedController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}