using otopark_otomasyonu.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace otopark_otomasyonu.Controllers
{

    public class HomeController : Controller
    {
        OtoparkDbContext db = new OtoparkDbContext();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Kayit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Kayit(Kisi_bilgisi p)
        {
            db.Kisi_bilgisis.Add(p);
            db.SaveChanges();
            return RedirectToAction("otoparkcikis");
        }

        public ActionResult otoparkcikis()
        {
            var liste = db.Kisi_bilgisis.ToList();
            return View(liste);
        }

        public ActionResult SIL(int id)
        {
            db.Kisi_bilgisis.Remove(db.Kisi_bilgisis.Find(id));
            db.SaveChanges();
            return RedirectToAction("otoparkcikis");

        }

        public ActionResult KisiGetir(int id)
        {
            var kisi = db.Kisi_bilgisis.Find(id);
            return View("KisiGetir", kisi);
        }

        public ActionResult KisiyiGuncelle(Kisi_bilgisi P1)
        {
            var kisi = db.Kisi_bilgisis.Find(P1.Kisi_ID);
            
            kisi.Ad_soyad = P1.Ad_soyad;
            kisi.Telefon = P1.Telefon;
            kisi.Email = P1.Email;
            kisi.Tarih = P1.Tarih;
            db.SaveChanges();
            return RedirectToAction("otoparkcikis");
        }
    }
}