using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Teklif
    {
        public int Id { get; set; }
        public decimal Fiyat { get; set; }

        [StringLength(350)]
        public string Mesaj { get; set; }
        public DateTime Tarih { get; set; }
        public string Adres { get; set; } // sadece il de olabilir

        //*************

        public virtual Kullanici TeklifVeren { get; set; }
        public virtual Kullanici TeklifAlan { get; set; }   

    }
}
