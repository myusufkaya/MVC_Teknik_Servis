using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeknikServis.Models;

namespace TeknikServis.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string klncAd, string sifre)
        {
            MvcContext db = new MvcContext();
            Kullanici k = db.Kullanicis.Where(x => x.Kullanici_Adi == klncAd && x.Sifre == sifre).SingleOrDefault();
            if (k == null)
            {// veritabanında yoksa
                ViewBag.Sonuc = "Kullanıcı bulunamadı.";
                return View();
            }
            else
            {
                Session["Kullanici"] = k;
                return RedirectToAction("Index", "Home");
            }

        }

        public ActionResult LogOff()
        {
            Session.Abandon();
            return RedirectToAction("Index","Login");
        }


    }
}