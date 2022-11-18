using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace otopark_otomasyonu.Models.Siniflar
{
    public class Otopark_islem
    {
        [Key]
        public int Islem_ID { get; set; }
        public int Satis_ID { get; set; }

        public int Kisi_ID { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(70)]
        public string Ad_soyad { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Telefon { get; set; }
        public int Marka_ID { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Plaka { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(70)]
        public string Yil { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(70)]
        public string Renk { get; set; }

        public int Py_ID { get; set; }
        public decimal Saat_ucreti { get; set; }
        public decimal Sure { get; set; }
        public decimal Tutar { get; set; }


        public DateTime Giris_Tarihi { get; set; }
        public DateTime Cikis_Tarihi { get; set; }

        public virtual Kisi_bilgisi Kisi_Bilgisi { get; set; }

        public virtual Marka Marka { get; set; }

        public virtual Arac_parkyeri Arac_Parkyeri { get; set; }
    }
}