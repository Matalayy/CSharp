using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Random
    {
        int Next() { return 0; }
        int Next(int max) { return 0; }

        int Next(int min,int max) { return 0; }
    }
    public class Personel
    {
        /*
        Access Modifiers
        1. private
        2. potected --> Miras alinan siniflardan erisilmeyi saglar
        3. internal --> Sadece Bulundugu projede her yerde erisilebilinir.
        4. protected internal --> Miras ve bulundugu projede erisilebilinir
        5. public
        */


        public Personel()
        {
            GirisTarihi = DateTime.Now;
        }

        ~Personel()
        {

        }

        internal string Adi;
        internal string Soyadi;
        internal string TCKimlik;
        internal string SicilNo;
        internal decimal Maas;
        internal DateTime GirisTarihi;

        internal void IseAl()
        {

        }

        internal decimal KidemTazminatiHesapla()
        {
            return 0;
        }

        internal void IstenCikart()
        {
            decimal para = KidemTazminatiHesapla();
        }

    }
}
