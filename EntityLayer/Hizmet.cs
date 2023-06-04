using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Hizmet
    {
       public int Id { get; set; }

        //****
       public virtual Kullanici HizmetVerenKullanici { get; set; }
       public virtual Kullanici HizmetAlanKullanici { get; set; }
       public virtual AltKategori Kategori { get; set; }
    }
}
