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
    public partial class FormListSales : Form
    {
        public FormListSales()
        {
            InitializeComponent();
        }

        public int EmployeeId { get; set; }
        public int ShippingId { get; set; }
        public string CustomerId { get; set; }


        private void FormListSales_Load(object sender, EventArgs e)
        {
            NorthWindDataContext dc = new NorthWindDataContext();

            /* var result = dc.Orders.Where(x => x.EmployeeID == EmployeeId && x.CustomerID==CustomerId 
            && x.ShipVia==ShippingId); */

            /* var result = dc.Orders.Where(x => x.EmployeeID == EmployeeId && x.CustomerID == CustomerId
            && x.ShipVia == ShippingId).Select(x => new
            {
                x.OrderID,
                x.EmployeeID,
                x.CustomerID,
                x.ShipVia,
                x.ShipName
            }); */


            var result = dc.Orders.Join(
                dc.Employees,
                ord => ord.EmployeeID,
                emp => emp.EmployeeID,
                (order, employee) => new { order, employee }).Join(
                dc.Customers,
                ord => ord.order.CustomerID,
                cus => cus.CustomerID,
                (order, customer) => new
                {
                    order.order.OrderID,
                    order.order.OrderDate,
                    EMployee = order.employee.FirstName + " " + order.employee.LastName,
                    customer.CompanyName,
                    order.order.CustomerID,
                    order.order.EmployeeID,
                    //order.order.CustomerID
                }).Where(x => x.EmployeeID == EmployeeId && x.CustomerID == CustomerId).Select(
                x => new
                {
                    x.OrderID,
                    x.OrderDate,
                    x.EMployee,
                    x.CompanyName,
                    x.CustomerID
                });
                

            dataGridViewListSales.DataSource = result;
        }
    }
}
