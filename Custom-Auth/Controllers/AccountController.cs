using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Custom_Auth.Web.Models;
using Custom_Auth.Web.ViewModels;

namespace Custom_Auth.Web.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(AccountViewModel avm)
        {
            Account account = avm.Account;

            if(String.IsNullOrEmpty(account.UserName) || String.IsNullOrEmpty(account.Password))
            {
                ViewBag.Error = "User or Password invalid";
                return View("Index");
            }

            AccountModel accountM = new AccountModel();

            if (!accountM.IsAuthenticable(account.UserName, account.Password))
            {
                ViewBag.Error = "User or Password invalid²";
                return View("Index");
            }

            return View("Success");
        }
    }
}