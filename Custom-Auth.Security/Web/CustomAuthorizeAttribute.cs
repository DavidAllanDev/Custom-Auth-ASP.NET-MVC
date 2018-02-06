using System.Web.Routing;
using System.Web.Mvc;
using Custom_Auth.Repository;

namespace Custom_Auth.Security.Web
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (string.IsNullOrEmpty(SessionPersister.Username))
            {
                filterContext.Result = new RedirectToRouteResult(
                                                        new RouteValueDictionary(new { controller = "Account", action = "Index" })
                                                        );
            }
            else
            {
                CustomPrincipal customPrincipal = new CustomPrincipal(Accounts.FindByUserName(SessionPersister.Username));
                if (!customPrincipal.IsInRole(Roles))
                {
                    filterContext.Result = new RedirectToRouteResult(
                                                    new RouteValueDictionary(new { controller = "AccessDenied", action = "Index" })
                                                    );
                }
            }
        }
    }
}
