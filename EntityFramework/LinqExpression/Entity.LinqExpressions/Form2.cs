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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            NorthWindDataContext dc = new NorthWindDataContext();

            dataGridView1.DataSource = from product2 in dc.Products
                                       join orderdetail in dc.Order_Details on
                                       product2.ProductID equals orderdetail.ProductID
                                       join order in dc.Orders on
                                       orderdetail.OrderID equals order.OrderID
                                       join customer in dc.Customers on
                                       order.CustomerID equals customer.CustomerID
                                       join employee in dc.Employees on
                                       order.EmployeeID equals employee.EmployeeID
                                       join supplier in dc.Suppliers on
                                       product2.SupplierID equals supplier.SupplierID
                                       join category2 in dc.Categories on
                                       product2.CategoryID equals category2.CategoryID
                                       select new
                                       {
                                           product2.ProductName,
                                           category2.CategoryName,
                                           Supplier=supplier.CompanyName,
                                           product2.UnitPrice,
                                           Order_UnitPrice = orderdetail.UnitPrice,
                                           orderdetail.Quantity,
                                           orderdetail.Discount,
                                           Customer=customer.CompanyName,
                                           Employees = employee.FirstName+" "+employee.LastName
                                       };
        }
    }
}
