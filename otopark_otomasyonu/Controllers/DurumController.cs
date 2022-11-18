using otopark_otomasyonu.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace otopark_otomasyonu.Controllers
{
    public class DurumController : Controller
    {
        OtoparkDbContext db = new OtoparkDbContext();   
        // GET: Durum
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult otoparkdurumu()
        {
            return View();
        }

        [HttpPost]
        public ActionResult otoparkdurumu(Arac_parkyeri P)
        {
            db.Arac_parkyeris.Add(P);
            db.SaveChanges();
            return RedirectToAction("otoparkdurumu");
        }

        public ActionResult SIL(int id)
        {
            db.Arac_parkyeris.Remove(db.Arac_parkyeris.Find(id));
            db.SaveChanges();
            return RedirectToAction("otoparkdurumu");
        }

    }
}