using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_yeniGiris.Models;

namespace Mvc_yeniGiris.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.id = 25;
            ogrenci.Ad = "kağan";
            ogrenci.Soyad = "kuüçük";
            ViewBag.Ogrenci = ogrenci;

            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public string Mesaj()
        {
            return "Merhaba hoşgeldiniz";
        }
    }
}