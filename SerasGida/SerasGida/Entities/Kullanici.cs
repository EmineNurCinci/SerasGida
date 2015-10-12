using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SerasGida.Entities
{
    
    public class Kullanici
    {
        public int KullaniciID { get; set; }
        public string Mail { get; set; }
        public string Sifre { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tur { get; set; }
    }
}
