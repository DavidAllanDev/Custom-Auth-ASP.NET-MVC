using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Mvc;
using Custom_Auth.Web.Models;

namespace Custom_Auth.Web.Security
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if(string.IsNullOrEmpty(SessionPersister.Username))
            {
                filterContext.Result = new RedirectToRouteResult(
                                                        new RouteValueDictionary(new { controller = "Account", action = "Index" })
                                                        );
            }
            else
            {
                AccountModel accountModel = new AccountModel();
                CustomPrincipal customPrincipal = new CustomPrincipal(accountModel.FindByUserName(SessionPersister.Username));
                if(!customPrincipal.IsInRole(Roles))
                {
                    filterContext.Result = new RedirectToRouteResult(
                                                    new RouteValueDictionary(new { controller = "AccessDenied", action = "Index" })
                                                    );
                }
            }
        }
    }
}