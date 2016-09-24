using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.PolyMorphism
{
    public partial class FormPolyMorphism : Form
    {
        public FormPolyMorphism()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();

            ogr.Adi = txtAdi.Text;
            ogr.SoyAdi = txtSoyadi.Text;
            ogr.Vize = NumericVize.Value;
            ogr.Final = NumericFinal.Value;


            MessageBox.Show(ogr.ToString());
            listBox1.Items.Add(ogr);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;

            Ogrenci SecilenOgrenci = (Ogrenci)listBox1.SelectedItem;

            txtAdi.Text = SecilenOgrenci.Adi;
            txtSoyadi.Text = SecilenOgrenci.SoyAdi;
            NumericVize.Value = SecilenOgrenci.Vize;
            NumericFinal.Value = SecilenOgrenci.Final;

        }
    }
}
