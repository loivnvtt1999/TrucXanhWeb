using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrucXanh_WebVersion.Models;
using ModelGame;
namespace TrucXanh_WebVersion.Controllers
{
    public class _gameController : Controller
    {
        // GET: _game
        public ActionResult menuGame()
        {
            return View();
        }
        public ActionResult newGame()
        {
            _modelImage modelImageObject = new _modelImage();
            _modelLevel modelLevelObject = new _modelLevel();
            List<tblImage> lstImage = modelImageObject.getListImage();
            tblLevel firstLevel = modelLevelObject.getFirstLevel();
            ViewBag.listImage = lstImage.ToArray();
            ViewBag.firstlevelID = firstLevel.levelID;
            ViewBag.firstlevelName = firstLevel.levelName;
            return View();
        }
    }
}