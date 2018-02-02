﻿using System;
using System.Web.Mvc;
using Custom_Auth.Web.Models;
using Custom_Auth.Web.ViewModels;
using Custom_Auth.Security.Web;

namespace Custom_Auth.Web.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Index() => View();

        [HttpPost]
        public ActionResult Login(AccountViewModel avm)
        {
            Account account = avm.Account;

            if(String.IsNullOrEmpty(account.UserName) || String.IsNullOrEmpty(account.Password))
            {
                ViewBag.Error = "User or Password invalid¹";
                return View("Index");
            }

            if (!new AccountModel().IsAuthenticable(account.UserName, account.Password))
            {
                ViewBag.Error = "User or Password invalid²";
                return View("Index");
            }

            SessionPersister.Username = account.UserName;

            return View("Success");
        }

        public ActionResult Logout()
        {
            SessionPersister.Username = string.Empty;
            return RedirectToAction("Index");
        }
    }
}