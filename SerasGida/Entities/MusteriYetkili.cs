using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SerasGida.Entities
{    
    public class MusteriYetkili
    {
        public int YetkiliID { get; set; }
        public int MusteriID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Unvan { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }

        public virtual Musteri Musteris { get; set; }
    }
}
