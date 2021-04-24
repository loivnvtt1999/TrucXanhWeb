using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ModelGame;
using TrucXanh_WebVersion.Data;

namespace TrucXanh_WebVersion.Controllers
{
    public class _userController : Controller
    {
        public ActionResult playGame()
        {
            return View();
        }
    }
}
