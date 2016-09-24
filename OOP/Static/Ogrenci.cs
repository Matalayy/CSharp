using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Static
{
    class Ogrenci
    {
        public Ogrenci()
        {
            TanimliOgrenciSayisi++;
        }

        public static int TanimliOgrenciSayisi { get; set; }

        public string Adi { get; set; }

        public string SoyAdi { get; set; }

        public string OkulNo  { get; set; }

        public string TCKN { get; set; }

        public static void YoklamaAl()
        {
            // instance almadan bu metod calistirilabilir.
            // yani adi soyadi okulno TCKN olmasina gerek yoktur.
            // ve ayrica adi soyadi okulno TCKN prop larina ulasilamaz
            // sadece TanimliOgrenciSayisi static oldugundan ulasilabilir.
        }
    }
}
