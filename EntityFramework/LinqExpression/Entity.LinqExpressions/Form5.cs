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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        NorthWindDataContext dc = new NorthWindDataContext();

        private void btnOrderBy_Click(object sender, EventArgs e)
        {

            var result = from product in dc.Products
                         orderby product.UnitPrice
                         select product;
            dataGridView1.DataSource = result;
        }

        private void btnDescending_Click(object sender, EventArgs e)
        {


            var result = from product in dc.Products
                         orderby product.ProductName descending
                         select product;

            var result2 = from order in dc.Orders
                          orderby order.OrderDate descending
                          select order;
            dataGridView1.DataSource = result2;
        }

        private void btnFilterDate_Click(object sender, EventArgs e)
        {
            DateTime dt = Convert.ToDateTime(maskedTextBox1.Text);
            var result = from order in dc.Orders
                         where order.OrderDate == dt
                         select order;
            dataGridView1.DataSource = result;

        }
    }
}
