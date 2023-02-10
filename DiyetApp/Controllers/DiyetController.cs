using DiyetApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DiyetApp.Controllers
{
    public class DiyetController : Controller
    {
        // GET: Diyet
        public ActionResult Index()
        {
            return View(Veritabani.Liste);
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(Diyet entity)
        {
            entity.Tarih=DateTime.Now;
            Veritabani.Ekle(entity);
            return View("Index",Veritabani.Liste);
        }
    }
}