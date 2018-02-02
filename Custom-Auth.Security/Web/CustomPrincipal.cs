using System.Linq;
using System.Security.Principal;
using Custom_Auth.Security.ModelInterface;

namespace Custom_Auth.Security.Web
{
    public class CustomPrincipal : IPrincipal
    {
        private IAccount _account;


        public CustomPrincipal(IAccount account)
        {
            _account = account;

            Identity = new GenericIdentity(account.UserName);
        }

        public IIdentity Identity { get; set; }

        public bool IsInRole(string role)
        {
            var roles = role.Split(new char[] { ',' });
            return roles.Any(r => _account.Roles.Contains(r));
        }
    }
}
