using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    [Table("Kullanıcı")]
    public class Kullanici
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(25)]
        public string KullanıcıAdı { get; set; }

        [MinLength(2), MaxLength(30)]
        public string? Ad { get; set; }


        [MinLength(2), MaxLength(30)]
        public string? Soyad { get; set; }

        [Required, StringLength(50)]
        public string Email { get; set; }

        [Required, MinLength(6), MaxLength(250)]
        public string Pasword { get; set; }

        public DateTime DogumTarihi { get; set; }

        [StringLength(25)]
        public string? TelefonNumarası { get; set; }
        public bool Aktivate { get; set; }
        public DateTime KayıtTarihi { get; set; }

        [StringLength(20), Required]
        public string Role { get; set; }

        [StringLength(255)]
        public string ProfilImagefileName { get; set; }

        [StringLength(10)]
        public string Cinsiyet { get; set; }

        [StringLength(255)]
        public string Adres { get; set; }

        [StringLength(50)]
        public string İl { get; set; }
        [StringLength(50)]
        public string İlçe { get; set; }



        //****************
        public virtual HizmetTipi HizmetTipi { get; set; }
        public virtual List<Hizmet> Hizmetler {get; set;} //aldığı veya verdiği hizmetler

        public Kullanici()
        {
            Hizmetler = new List<Hizmet>();

        }
    }
}
