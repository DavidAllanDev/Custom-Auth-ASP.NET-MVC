using Custom_Auth.Domain.Model;
using Custom_Auth.Interfaces.ModelInterface;
using System.Collections.Generic;
using System.Linq;

namespace Custom_Auth.Repository
{
    public static class Accounts
    {
        private static List<IAccount> _accounts = new List<IAccount>()
        {
            new Account {
                    UserName = "User",
                    Password = "xXx",
                    Roles = new string[] { "sa", "user" }
              },
            new Account()
              {
                  UserName = "sasa",
                  Password = "xXx",
                  Roles = new string[] { "sudo", "sa" }
              },
            new Account()
              {
                  UserName = "Root",
                  Password = "xXx",
                  Roles = new string[] { "root", "sudo", "sa" }
              }
        };                  

        public static List<IAccount> AccountList(string userName) => _accounts;

        public static IAccount FindByUserName(string userName) => _accounts.FindAll(a => a.UserName.Equals(userName)).FirstOrDefault();

        public static bool IsAuthenticable(string userName, string password) => _accounts.Find(A => A.UserName.Equals(userName) && A.Password.Equals(password)) != null;
    }
}
