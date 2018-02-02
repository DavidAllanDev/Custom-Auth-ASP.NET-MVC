using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Custom_Auth.Web.Models
{
    public class AccountModel
    {
        private List<Account> _accounts;

        public AccountModel()
        {
            _accounts = new List<Account>() { };
            _accounts.Add(
                            new Account() {
                                            UserName = "User",
                                            Password = "xXx",
                                            Roles = new string[] {"sa", "user"}
                                          }
                         );
            _accounts.Add(
                            new Account()
                            {
                                UserName = "sasa",
                                Password = "xXx",
                                Roles = new string[] {"sudo", "sa" }
                            }
                         );
            _accounts.Add(
                            new Account()
                            {
                                UserName = "Root",
                                Password = "xXx",
                                Roles = new string[] { "root", "sudo", "sa" }
                            }
                         );
        }

        public Account FindByUserName(string userName)
        {
            return _accounts.Single(a => a.UserName.Equals(userName));
        }

        public bool IsAuthenticable(string userName, string password)
        {
            return _accounts.Find(A => A.UserName.Equals(userName) && A.Password.Equals(password)) != null;
        }
    }
}