using ModelGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrucXanh_WebVersion.Models;

namespace TrucXanh_WebVersion.Controllers
{
    public class _accountController : Controller
    {
        // GET: _account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(tblAccount Account)
        {
            if (ModelState.IsValid)
            {
                _modelAccount modelAccount = new _modelAccount();
                if (modelAccount.checkLogin(Account) == null)
                {
                    ModelState.AddModelError("","Tài khoản đăng nhập không đúng");
                }
                else
                {
                    tblAccount userSession = new tblAccount();
                    userSession = modelAccount.checkLogin(Account);
                    Session["loginAccount"] = userSession;
                    return RedirectToAction("menuGame", "_game");
                }
            }
            return View(Account);
        }
    }
}