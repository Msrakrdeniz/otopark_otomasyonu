using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace otopark_otomasyonu.Models.Siniflar
{
    public class Admin
    {
        [Key]
        public int Admin_ID { get; set; }
        public string Kullaniciadi { get; set; }
        public string Sifre { get; set; }
    }
}