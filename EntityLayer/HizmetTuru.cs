using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class HizmetTipi
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Tip { get; set; } //hizmet alan mı? veren mi?


        //************
        public virtual List<Kullanici> Kullanıcılar { get; set; } //Hizmetin kullanıcıları var

        public HizmetTipi()
        {
            Kullanıcılar = new List<Kullanici>();
        }
    }
}
