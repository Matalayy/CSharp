using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.PolyMorphism
{
    class Ogrenci:Insan
    {

        public decimal Vize { get; set; }

        public decimal Final { get; set; }

        public override string ToString()
        {
            return Adi+" "+SoyAdi;
        }

        public override void InsanAl()
        {
            // ogrenci olan insanlari almayi sagla
        }
    }
}
