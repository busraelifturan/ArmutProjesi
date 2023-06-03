using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class AltKategori
    {
        public int Id { get; set; }
        public string Ad { get; set; }


        //*****
        public virtual Kategori Kategori { get; set; }
    }
}
