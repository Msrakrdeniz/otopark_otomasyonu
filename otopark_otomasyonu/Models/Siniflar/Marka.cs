using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace otopark_otomasyonu.Models.Siniflar
{
    public class Marka
    {
        [Key]
        public int Marka_ID { get; set; }
        [Column(TypeName ="varchar")]
        [StringLength(70)]
        public string MarkaAdi { get; set; }

        public virtual ICollection<Arac_bilgisi> Arac_Bilgisis { get; set; }

       public virtual ICollection<Otopark_islem> Otopark_İslems { get; set; }
    }
}