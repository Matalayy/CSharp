using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.OtoparkUygulamasi
{
    public partial class Form1 : Form
    {
        public object CikisYapanlar { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            Arac arac = new Arac();
            arac.Plaka = textBoxPlaka.Text;
            arac.Tip = (AracTip)listBoxAracTip.SelectedItem;
            arac.KontakVar = checkBoxKontakVar.Checked;
            arac.Abone = checkBoxAbone.Checked;

            listBoxOtoparkAraclar.Items.Add(arac);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxAracTip.Items.Add(new AracTip { Adi = "Otomabil(1)", Fiyat = 1 });

            listBoxAracTip.Items.Add(new AracTip { Adi = "Minibus(2)", Fiyat = 2 });

            listBoxAracTip.Items.Add(new AracTip { Adi = "Otobus(4)", Fiyat = 4 });

            listBoxAracTip.Items.Add(new AracTip { Adi = "Kamyon(4)", Fiyat = 4 });

            listBoxAracTip.Items.Add(new AracTip { Adi = "Tir(8)", Fiyat = 8 });   
        }

        List<Arac> CikisYapanlarr = new List<Arac>();
        private void listBoxOtoparkAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxOtoparkAraclar.SelectedItem == null) return;

            Arac seciliArac = (Arac)listBoxOtoparkAraclar.SelectedItem;
            seciliArac.Cikis = DateTime.Now;

            labelPlaka.Text = seciliArac.Plaka;
            labelSure.Text = seciliArac.Sure.ToString();
            labelUcret.Text = seciliArac.Ucret.ToString("C2");
        }

        private void CikisYap_Click(object sender, EventArgs e)
        {
            if (listBoxOtoparkAraclar.SelectedItem == null) return;

            Arac seciliArac = (Arac)listBoxOtoparkAraclar.SelectedItem;
            CikisYapanlarr.Add(seciliArac);
            listBoxOtoparkAraclar.Items.Remove(seciliArac);



        }

        private void buttonSatisRaporu_Click(object sender, EventArgs e)
        {
            Rapor formRapor = new Rapor();
            decimal total = 0;

            foreach (Arac item in CikisYapanlarr)
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.Plaka;
                li.SubItems.Add(item.Tip.Adi);
                li.SubItems.Add(item.Abone ? "Abone" : "Degil");
                li.SubItems.Add(item.Sure.ToString());
                li.SubItems.Add(item.Ucret.ToString("C2"));
                formRapor.listView1.Items.Add(li);

                total += item.Ucret;
            }

            formRapor.labelToplamUcret.Text = total.ToString("C2");
            formRapor.labelToplamArac.Text = CikisYapanlarr.Count.ToString();
            formRapor.Show();
        }
    }
}
