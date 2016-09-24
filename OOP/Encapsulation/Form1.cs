using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            EncapsulatinOgr ogrenci = new EncapsulatinOgr();

            try
            {
                ogrenci.Adi = TxtAdi.Text;

                ogrenci.DogumTarihi = dateTimePicker1.Value;
                MessageBox.Show(ogrenci.yas.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            // label1.Text = ogrenci.Adi;
            // baska bir degiskene atama yaptigimizda get
            // Encapsulation icersindeki elemana bir deger atamya calistigimizda set
            // calisir.
        }
    }
}
