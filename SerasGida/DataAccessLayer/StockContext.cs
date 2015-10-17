using SerasGida.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer
{
    public class StockContext:DbContext
    {
        public StockContext():base("StockContext")
        {

        }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<MusteriYetkili> MusteriYetkililer{ get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<UrunMusteri> UrunMusteri { get; set; }
    }
}
