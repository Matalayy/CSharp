using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity.OrderApplicationExample
{
    public partial class CustomerSalesPaper : Form
    {
        public CustomerSalesPaper()
        {
            InitializeComponent();
        }

        private void CustomerSalesPaper_Load(object sender, EventArgs e)
        {
            NorthWindDataContext dc = new NorthWindDataContext();

            var result = (from order in dc.Orders
                          join detail in dc.Order_Details on order.OrderID equals detail.OrderID
                          select new
                          {
                              order,
                              detail
                          }).GroupBy(x => x.order.CustomerID).Select(x => new
                          {
                              CustomerID = x.Key,
                              TotalTaking = x.Sum(y => y.detail.Quantity * y.detail.UnitPrice),
                              TotalDeal = x.Count(),
                          }).OrderByDescending(x => x.CustomerID).Take(10);

            dataGridView1.DataSource = result;
        }
    }
}
