using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace otopark_otomasyonu.Models.Siniflar
{
    public class OtoparkDbContext : DbContext
    {
        public DbSet<Marka> Markas { get; set; }
        public DbSet<Arac_parkyeri> Arac_parkyeris { get; set; }
        public DbSet<Kisi_bilgisi> Kisi_bilgisis { get; set; }
        public DbSet<Arac_bilgisi> Arac_bilgisis { get; set; }
        public DbSet<Otopark_islem> Otopark_islems { get; set; }
        public DbSet<Admin> Admins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

    }
}