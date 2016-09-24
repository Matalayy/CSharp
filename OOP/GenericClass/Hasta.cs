using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.GenericClass
{
    class Hasta<Temsil,IlacTip> where IlacTip:Ilac where Temsil:class
    {
        public string Adi { get; set; }

        public string Soyadi { get; set; }

        public string TCKN { get; set; }

        public Temsil HastaOzellikleri { get; set; }

        public List<IlacTip> Ilaclar { get; set; }
    }

    class Ilac
    {
        public string Adi { get; set; }
        public string Marka { get; set; }
    }

    class HastalikCesidi
    {
        public string HastalikAdi { get; set; }

        public string HastalikTuru { get; set; }

        public float LD { get; set; } // hastaliktaki olum orani

        public string AntiDot { get; set; }
    }

    class AgriKesici:Ilac
    {
        public int Mg { get; set; }

    }

    
}
