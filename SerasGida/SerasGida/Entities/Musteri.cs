using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SerasGida.Entities
{

    
    public class Musteri
    {
        public int MusteriID { get; set; }
        public string FirmaUnvani { get; set; }
        public string Adres { get; set; }
        public string VergiNo { get; set; }
        public string VergiDairesi { get; set; }
        public string SicilNo { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
    }
}
