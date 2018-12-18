using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeknikServis.Models;

namespace TeknikServis.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            MvcContext db = new MvcContext();
            List<Musteri> musteriler = db.Musteris.ToList();
            return View(musteriler);
        }
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(Musteri m)
        {
            MvcContext db = new MvcContext();
            db.Musteris.Add(m);
            db.SaveChanges();
            ViewBag.Sonuc = m.Ad + " " + m.Soyad + " eklendi";
            return View();
        }
        [HttpGet]
        public ActionResult Duzenle(int id)
        {
            MvcContext db = new MvcContext();
            Musteri m = db.Musteris.Where(x => x.Mus_ID == id).SingleOrDefault();
            return View(m);
        }

        [HttpPost]

        public ActionResult Duzenle(Musteri musteriGelen)
        {
            MvcContext db = new MvcContext();
            Musteri m = db.Musteris.Where(x => x.Mus_ID == musteriGelen.Mus_ID).SingleOrDefault();
            m.TC = musteriGelen.TC;
            m.Ad = musteriGelen.Ad;
            m.Soyad = musteriGelen.Soyad;
            m.Adres = musteriGelen.Adres;
            m.Mail = musteriGelen.Mail;
            m.Telefon = musteriGelen.Telefon;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Sil(int id)
        {
            MvcContext db = new MvcContext();
            Musteri m = db.Musteris.SingleOrDefault(a => a.Mus_ID == id);
            db.Musteris.Remove(m);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

     
        

        public ActionResult Arıza()
        {
            MvcContext db = new MvcContext();
            List<Ariza> arizalar = db.Arizas.ToList();
            return View(arizalar);
        }
        [HttpGet]
        public ActionResult ArızaDuzenle(int id)
        {
            MvcContext db = new MvcContext();
            Ariza a = db.Arizas.Where(y => y.Ariza_ID == id).SingleOrDefault();
            return View(a);
        }

        [HttpPost]

        public ActionResult ArızaDuzenle(Ariza arizaGelen)
        {
            MvcContext db = new MvcContext();
            Ariza a = db.Arizas.Where(y => y.Ariza_ID == arizaGelen.Ariza_ID).SingleOrDefault();
            a.Ariza_ID = arizaGelen.Ariza_ID;
            a.Tip_ID = arizaGelen.Tip_ID;
            a.Tarih = arizaGelen.Tarih;
            a.Mus_ID = arizaGelen.Mus_ID;
            a.Detay = arizaGelen.Detay;
            a.Durum = arizaGelen.Durum;
            a.Urun_Ad = arizaGelen.Urun_Ad;
            a.Urun_Kategori = arizaGelen.Urun_Kategori;
            db.SaveChanges();
            return RedirectToAction("Arıza");
        }
        public ActionResult ArızaEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ArızaEkle(Ariza a)
        {
            MvcContext db = new MvcContext();
            db.Arizas.Add(a);
            db.SaveChanges();
            ViewBag.Sonuc = a.Ariza_ID + " Nolu arıza başarıyla eklendi.";
            return View();
        }
        public ActionResult ArızaSil(int id)
        {
            MvcContext db = new MvcContext();
            Ariza ar = db.Arizas.SingleOrDefault(a => a.Ariza_ID == id);
            db.Arizas.Remove(ar);
            db.SaveChanges();
            return RedirectToAction("Arıza");
        }

        public ActionResult Malzeme()
        {
            MvcContext db = new MvcContext();
            List<Malzeme> malzemeler = db.Malzemes.ToList();
            return View(malzemeler);
        }
        public ActionResult MalzemeEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MalzemeEkle(Malzeme m)
        {
            MvcContext db = new MvcContext();
            db.Malzemes.Add(m);
            db.SaveChanges();
            ViewBag.Sonuc = m.Malzeme_Ad + " ürününden " + m.Adet + " adet eklendi.";
            return View();
        }
        [HttpGet]
        public ActionResult MalzemeDuzenle(int id)
        {
            MvcContext db = new MvcContext();
            Malzeme m = db.Malzemes.Where(x => x.Malzeme_ID == id).SingleOrDefault();
            return View(m);
        }

        [HttpPost]

        public ActionResult MalzemeDuzenle(Malzeme malzemeGelen)
        {
            MvcContext db = new MvcContext();
            Malzeme m = db.Malzemes.Where(x => x.Malzeme_ID == malzemeGelen.Malzeme_ID).SingleOrDefault();
            m.Malzeme_Ad = malzemeGelen.Malzeme_Ad;
            m.Adet = malzemeGelen.Adet;
            m.Fiyat = malzemeGelen.Fiyat;
            db.SaveChanges();
            return RedirectToAction("Malzeme");
        }
        public ActionResult MalzemeSil(int id)
        {
            MvcContext db = new MvcContext();
            Malzeme m = db.Malzemes.SingleOrDefault(a => a.Malzeme_ID == id);
            db.Malzemes.Remove(m);
            db.SaveChanges();
            return RedirectToAction("Malzeme");
        }

        public ActionResult Siparis()
        {
            MvcContext db = new MvcContext();
            List<Tedarik> tedarikler = db.Tedariks.ToList();
            return View(tedarikler);
        }
        public ActionResult SiparisEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SiparisEkle(Tedarik t)
        {
            MvcContext db = new MvcContext();
            db.Tedariks.Add(t);
            db.SaveChanges();
            ViewBag.Sonuc = t.Tedarik_ID + " Sipariş nolu  " + t.Tedarik_Adet + " adet ürün siparişi verildi.";
            return View();
        }

        [HttpGet]
        public ActionResult SiparisDuzenle(int id)
        {
            MvcContext db = new MvcContext();
            Tedarik t = db.Tedariks.Where(y => y.Tedarik_ID == id).SingleOrDefault();
            return View(t);
        }

        [HttpPost]

        public ActionResult SiparisDuzenle(Tedarik tedarikGelen)
        {
            MvcContext db = new MvcContext();
            Tedarik t = db.Tedariks.Where(y => y.Tedarik_ID == tedarikGelen.Tedarik_ID).SingleOrDefault();
            //t.Tedarik_ID = tedarikGelen.Tedarik_ID;
            t.Malzeme_ID = tedarikGelen.Malzeme_ID;
            t.Tedarik_Adet = tedarikGelen.Tedarik_Adet;
            t.Siparis_Tarih = tedarikGelen.Siparis_Tarih;
            t.Fiyat = tedarikGelen.Fiyat;
            db.SaveChanges();
            return RedirectToAction("Siparis");
        }

        public ActionResult SiparisSil(int id)
        {
            MvcContext db = new MvcContext();
            Tedarik ted = db.Tedariks.SingleOrDefault(a => a.Tedarik_ID == id);
            db.Tedariks.Remove(ted);
            db.SaveChanges();
            return RedirectToAction("Siparis");
        }




    }
}