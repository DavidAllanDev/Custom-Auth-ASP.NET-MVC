using System.Linq;
using System.Security.Principal;
using Custom_Auth.Web.Models;

namespace Custom_Auth.Web.Security
{
    public class CustomPrincipal : IPrincipal
    {
        private Account _account;


        public CustomPrincipal(Account account)
        {
            _account = account;

            Identity = new GenericIdentity(account.UserName);
        }

        public IIdentity Identity{ get; set; }

        public bool IsInRole(string role)
        {
            var roles = role.Split(new char[] { ',' });
            return roles.Any(r => _account.Roles.Contains(r));
        }
    }
}