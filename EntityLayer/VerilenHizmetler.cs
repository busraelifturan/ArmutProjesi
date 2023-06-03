using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
        //buradan devam edicem. Şöyle düşündüm; Sistemin verdiği hizmetler var hizmetin soruları var ve sorunun tipi var. Misal bu bu radio button sorusu mu yoksa bir sayımı arttırmalı. Sorunun cevapları aslında hizmet almak isteyen kişinin derdinin anlatıyor. dert büyükse fiyatta büyük .d 
        //Sistemin hizmetini veren kullanıcılar listesi var. ama alan burada yok. alan ile vereni Hizmet class ında buluşturuyoruz ozaman oraya da bu class ın ıd si lazım
    public class VerilenHizmetler
    {
        public int Id { get; set; }
        public string HizmetAdi { get; set; }
        public decimal Fiyat { get; set; }
        public string Soru1 { get; set; }
        public string tip1 { get; set; }

        public string Soru2 { get; set; }
        public string tip2 { get; set; }
        public string Soru3 { get; set; }
        public string Soru4 { get; set; }
        public string Soru5 { get; set; }
        public string Soru6 { get; set; }
        public string Soru7 { get; set; }
        public string Soru8 { get; set; }

    }
}
