using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction
{
    // Abstract siniflardan instance alinamaz.
    // eleman uretemezsiniz.
    // Cari c = new Cari(); seklinde eleman olusturulamaz.
    public abstract class Cari
    {
        public abstract string CariKodu { get; set; }

        public string Unvan { get; set; }

        public abstract string[] getBanks();

        public decimal getKDV()
        {
            return 0.18m;
        }
    }

    public class CariMusteri : Cari
    {
        private string cariKod;
        public override string CariKodu
        {
            get
            {
                return cariKod;
            }

            set
            {
                cariKod = value;
            }
        }

        public override string[] getBanks()
        {
            return new string[] { "Is Bankasi", "Ziraat Bankasi" };
        }
    }

    public class CariTedarikci : Cari
    {
        string cariKodu;
        public override string CariKodu
        {
            get
            {
                return cariKodu;
            }

            set
            {
                cariKodu = value;
            }
        }

        public override string[] getBanks()
        {
            return new string[] { "TEB", "Garanti" , "Akbank" };
        }
    }

}
