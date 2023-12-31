﻿using KShopOnline.Areas.Admin.Models;
using KShopOnline.Areas.Admin.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using System.Web.Security;
namespace KShopOnline.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel model)
        {
            //var res = new AccountModel().Login(model.Username, model.Password);
            if(Membership.ValidateUser(model.Username, model.Password) == true &&ModelState.IsValid)
            {
                //SessionHelper.SetSession(new UserSession() { Username = model.Username});
                FormsAuthentication.SetAuthCookie(model.Username, model.RememberMe);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Ten dang nhap hoac mat khau khong dung");
            }
            return View(model);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}