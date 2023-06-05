using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<AltKategori> AltKategoriler { get; set; }
        public DbSet<Hizmet> Hizmetler { get; set; }
        public DbSet<HizmetTipi> HizmetTipleri { get; set; }
        public DbSet<VerilenHizmetler> VerilenHizmetlers { get; set; }
        public DbSet<Teklif> Teklifler { get; set; }

    }
}
