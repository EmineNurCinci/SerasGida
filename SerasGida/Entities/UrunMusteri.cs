using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SerasGida.Entities
{
    public class UrunMusteri
    {
        public int Id { get; set; }
        public int MusteriId { get; set; }
        public int UrunId { get; set; }
    }
}