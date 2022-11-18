using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace otopark_otomasyonu.Models.Siniflar
{
    public class Arac_parkyeri
    {
        [Key]
        public int Py_ID { get; set; }
        [Column(TypeName ="varchar")]
        [StringLength(70)]
        public string Parkyerleri { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(70)]
        public string Durum { get; set; }

        public int Arac_ID { get; set; }
        public virtual ICollection<Arac_bilgisi> Arac_Bilgisis { get; set; }

        public virtual ICollection<Otopark_islem> Otopark_İslems { get; set; }
    }
}