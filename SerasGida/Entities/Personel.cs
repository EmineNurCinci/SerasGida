using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SerasGida.Entities
{
    
    public class Personel
    {
        public int PersonelID { get; set; }
        public string Mail { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tur { get; set; }
        public string UserName { get; set; }
        public string Password { get; set;}
    }
}
