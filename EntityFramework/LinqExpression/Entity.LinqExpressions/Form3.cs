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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            NorthWindDataContext dc = new NorthWindDataContext();

            var result = from product in dc.Products
                         join orderdetail in dc.Order_Details on
                         product.ProductID equals orderdetail.ProductID
                         group orderdetail by product.ProductName into Group
                         select new
                         {
                             ProductName = Group.Key,
                             TotalSales = Group.Sum(x => x.UnitPrice*x.Quantity)
                         };

            var result2 = from product in dc.Products
                          select new
                          {
                              product.ProductName,
                              TotalSales = product.Order_Details.Any()?
                              product.Order_Details.Sum(x => x.UnitPrice * x.Quantity):0
                          };

            dataGridView1.DataSource = result2;

        }
    }
}
