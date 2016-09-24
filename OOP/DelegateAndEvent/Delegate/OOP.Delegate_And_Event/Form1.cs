using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Delegate_And_Event
{
    public delegate void MesajVerHandler(string mesaj);
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void KutudaMesajVer(string msg)
        {
            MessageBox.Show(msg);
        }

        void LabeldaMesajVer(string msg)
        {
            labelDelegate.Text = msg;
        }

        void TextBoxDaMesajVer(string msg)
        {
            txtDelegate.Text = msg;
        }

        void CaptionDaMesajVer(string msg)
        {
            this.Text = msg;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDelegate_Click(object sender, EventArgs e)
        {
            MesajVerHandler mesajverici = new MesajVerHandler(KutudaMesajVer);
            mesajverici += LabeldaMesajVer;
            mesajverici += TextBoxDaMesajVer;
            mesajverici += CaptionDaMesajVer;

            mesajverici.Invoke("Merhaba Dunya");
        }
    }
}
