using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.InterFace
{
    class SabriSarioglu : FutbolcuBase, OyunKurabilme
    {
        public bool CalimAt(float hiz, float aci)
        {
            return true;
        }
    }
}
