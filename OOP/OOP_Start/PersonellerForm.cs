using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP1
{
    public partial class Personeller : Form
    {
        public Personeller()
        {
            InitializeComponent();
        }

        private void Personeller_Load(object sender, EventArgs e)
        {

        }

        Personel[] persons = new Personel[100];
        int sayac = 0;
        public void PersonelEkle(Personel personel)
        {
            persons[sayac] = personel;
            listBox1.Items.Add(personel.Adi + " " + personel.Soyadi);
            sayac++;
        }

        private void BtnIstenCikart_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;

            Personel prsCikartilacak = persons[listBox1.SelectedIndex];
            prsCikartilacak.IstenCikart();
        }
    }
}
