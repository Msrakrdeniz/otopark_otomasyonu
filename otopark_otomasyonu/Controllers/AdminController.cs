using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using otopark_otomasyonu.Models.Siniflar;

namespace otopark_otomasyonu.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        OtoparkDbContext c = new OtoparkDbContext();
        public ActionResult Index()
        {
            var deger = c.Kisi_bilgisis.ToList();
            return View(deger);
        }

        public ActionResult KisileriGetir(int id)
        {
            var ag = c.Kisi_bilgisis.Find(id);
            return View("KisileriGetir", ag);
        }
    }
}