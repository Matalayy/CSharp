using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity.LinqExpressions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NorthWindDataContext dc = new NorthWindDataContext();
            dataGridView1.DataSource = from product in dc.Products
                                       join category in dc.Categories on
           product.CategoryID equals category.CategoryID
                                       select new
                                       {
                                           product.ProductName,
                                           category.CategoryName,
                                           product.UnitPrice,
                                           product.UnitsInStock
                                       };
        }
    }
}
