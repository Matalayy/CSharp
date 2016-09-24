using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.InterFace
{
    interface SuTCekebilme
    {
        // interface icerisine sadece method ve prop(Encapsulation) yazilabilir.
        // inteface icerisinde public, private method ya da prop onculu tanimlanamaz.
        // interface lerden direkt olarak instance alinamaz. SutCekebilme sut = new SuTCekebilme() olmaz.
        // constructor yoktur.
        // Access modifier yoktur. 
        // Interface icerisine field konulmaz.
        string Mesafe { get; set; }

        bool SutCek(float guc, float aci);

    }
}
