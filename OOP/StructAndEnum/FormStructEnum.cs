using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Struct_Enum
{
    public partial class FormStructEnum : Form
    {
        public FormStructEnum()
        {
            InitializeComponent();
        }

        private void FormStructEnum_Load(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();

            ogr.Adi = "Melih";
            ogr.Soyadi = "Atalay";
            ogr.Alani = Alan.Sayisal;

            Ders d1 = new Ders {Adi="Matematik",Vize=80,Final=70 };
            Ders d2 = new Ders { Adi = "Fizik", Vize = 60, Final = 50 };

            ogr.Dersler.Add(d1);
            //ogr.Dersler.Add(d2);

            switch (ogr.Durum)
            {
                case OgrenciDurum.Gecti:
                    MessageBox.Show("Direkt Gecti");
                    break;
                case OgrenciDurum.SartliGecti:
                    MessageBox.Show("Sartli Gecti");
                    break;
                case OgrenciDurum.Devamsiz:
                    MessageBox.Show("Devamsizliktan Kaldi");
                    break;
                case OgrenciDurum.Kaldi:
                    MessageBox.Show("Kaldi");
                    break;
                case OgrenciDurum.SinifTekrari:
                    MessageBox.Show("Sinif Tekrari");
                    break;
                default:
                    break;
            }
        }
    }
}
