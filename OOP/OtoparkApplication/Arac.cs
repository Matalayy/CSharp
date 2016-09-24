using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.OtoparkUygulamasi
{
    class Arac
    {
        public Arac()
        {
            Giris = DateTime.Now;
        }
        public string Plaka { get; set; }
        public AracTip Tip { get; set; }
        public bool KontakVar { get; set; }
        public bool Abone { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }

        public int Sure
        {
            get
            {
                TimeSpan fark = Cikis - Giris;
                if(fark - TimeSpan.FromHours(fark.TotalHours) > TimeSpan.Zero)
                {
                    fark = fark.Add(TimeSpan.FromHours(1));
                }

                return (int)fark.TotalHours;
            }
        }

        public decimal Ucret
        {
            get
            {
                decimal toplam = Tip.Fiyat*(Sure-1) + Tip.Fiyat*2;
                if(Abone)
                {
                    toplam *= 0.80m;
                }
                return toplam;
            }
        }

        public override string ToString()
        {
            string metinabone = Abone ? "Abone" : "Abone Degil";
            string metinKontak = KontakVar ? "Kontak Var" : "Kontak Yok";
            return string.Format("{0}-{1}-{2}-{3}", Plaka, Tip.Adi, metinabone, metinKontak);
        }
    }

    class AracTip
    {
        public string Adi { get; set; }
        public decimal Fiyat { get; set; }

        public override string ToString()
        {
            return Adi;
        }
    }
}
