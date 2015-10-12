using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SerasGida.Entities
{


    public class Urun
    {
        public int UrunID { get; set; }
        public int MusteriID { get; set; }
        public string UrunAdi { get; set; }
        public string UrunKodu { get; set; }
        public string CikisTuru { get; set; }
        public int SttUyariGun { get; set; }
        public int MinStokMik { get; set; }
    }
}
