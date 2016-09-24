using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.InterFace
{
    class ArdaTuran : FutbolcuBase, SuTCekebilme , OyunKurabilme
    {

        // SutCekebilir
        public string Mesafe
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public bool SutCek(float guc, float aci)
        {
            return true;
        }

        // SutCekebilir Son


        // oyunkurabilir
        public bool CalimAt(float hiz, float aci)
        {
            return true;
        }

        

        // Oyunkurabilir son
    }
}
