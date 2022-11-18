using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace otopark_otomasyonu.Models.Siniflar
{
    public class Kisi_bilgisi
    {
        [Key]
        public int Kisi_ID { get; set; }
        
        [Column(TypeName = "varchar")]
        public string Ad_soyad { get; set; }
       
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Telefon { get; set; }
       
        [Column(TypeName = "varchar")]
        [StringLength(150)]
        public string Email { get; set; }
        
        public DateTime Tarih { get; set; }

        public virtual ICollection<Arac_bilgisi> Arac_Bilgisis { get; set; }

        public virtual ICollection<Otopark_islem> Otopark_İslems { get; set; }

    }
}