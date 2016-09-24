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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Personeller personelform = new Personeller();
        private void Ekle_Click(object sender, EventArgs e)
        {
            Personel person1 = new Personel();
            person1.Adi = textBox1.Text;
            person1.Soyadi = textBox2.Text;
            person1.SicilNo = textBox3.Text;
            person1.Maas = numericUpDown1.Value;

            personelform.PersonelEkle(person1);

            textBox1.Text = textBox2.Text = textBox3.Text = "";
            numericUpDown1.Value = 0;
            textBox1.Focus();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            personelform.Show();
        }





        
    }
}
