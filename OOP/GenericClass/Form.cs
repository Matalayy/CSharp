using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections; // Her turlu ekleme yapilabilir ancak tip guvenligi yoktur.

namespace OOP.GenericClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();

            Hasta<HastalikCesidi,AgriKesici> hasta = new Hasta<HastalikCesidi,AgriKesici>();

            HastalikCesidi Hcesid = new HastalikCesidi();
            Hcesid.HastalikAdi = "Grip";
            Hcesid.AntiDot = "Ada Cayi, Rezene";
            Hcesid.LD = 9;
            Hcesid.HastalikTuru = "Virusel Enfeksiyon";

            
        }
    }
}
