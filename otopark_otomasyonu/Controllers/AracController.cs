using otopark_otomasyonu.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace otopark_otomasyonu.Controllers
{
    public class AracController : Controller
    {
        OtoparkDbContext db = new OtoparkDbContext();
        // GET: Arac
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AracGoster()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AracGoster(Arac_bilgisi P)
        {
            db.Arac_bilgisis.Add(P);
            db.SaveChanges();
            return RedirectToAction("AracCikis");
        }

        public ActionResult AracCikis()
        {
            var listee = db.Arac_bilgisis.ToList();
            return View(listee);
        }

        public ActionResult SIL(int id)
        {
            db.Arac_bilgisis.Remove(db.Arac_bilgisis.Find(id));
            db.SaveChanges();
            return RedirectToAction("AracCikis");

        }

        public ActionResult AracGetir(int id)
        {
            var arac = db.Arac_bilgisis.Find(id);
            return View("AracGetir", arac);
        }

        public ActionResult AracıGuncelle(Arac_bilgisi P1)
        {
            var kisi = db.Arac_bilgisis.Find(P1.Arac_ID);
            kisi.Plaka = P1.Plaka;
            kisi.Marka = P1.Marka;
            kisi.Renk = P1.Renk;
            kisi.Kisi_ID = P1.Kisi_ID;
            db.SaveChanges();
            return RedirectToAction("AracCikis");
        }
    }
}