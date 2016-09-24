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
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            NorthWindDataContext dc = new NorthWindDataContext();
            dataGridViewProducts.DataSource = dc.Products;

            comboBoxCustomer.DataSource = dc.Customers;
            comboBoxCustomer.DisplayMember = "CompanyName";
            comboBoxCustomer.ValueMember = "CustomerID";

            comboBoxShipping.DataSource = dc.Shippers;
            comboBoxShipping.DisplayMember = "CompanyName";
            comboBoxShipping.ValueMember = "ShipperID";

            // Lambda
            comboBoxEmployee.DataSource = dc.Employees.Select(employee => new
            {
                employee.EmployeeID,
                NameSurname = employee.FirstName + " " + employee.LastName
            });
            comboBoxEmployee.DisplayMember = "NameSurname";
            comboBoxEmployee.ValueMember = "EmployeeID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.CurrentCell == null) return;

            DataGridViewRow dgr = dataGridViewProducts.CurrentRow;

            ListViewItem lvi = new ListViewItem();
            lvi.Text = dgr.Cells["ProductName"].Value.ToString();
            lvi.SubItems.Add(dgr.Cells["UnitPrice"].Value.ToString());
            lvi.SubItems.Add(numericQuantity.Value.ToString());
            lvi.SubItems.Add(numericDiscount.Value.ToString());
            lvi.Tag = dgr.Cells["ProductID"].Value;

            if((short)dgr.Cells["UnitsInStock"].Value < numericQuantity.Value)
                MessageBox.Show("Not Enough Quantity To Add This roduct");

            else
                listViewProducts.Items.Add(lvi);

            numericDiscount.Value = 0;
            numericQuantity.Value = 1;
        }

        private void btnApproveOrder_Click(object sender, EventArgs e)
        {
            if(comboBoxCustomer==null || comboBoxEmployee==null || comboBoxShipping==null)
            {
                MessageBox.Show("Missing Information");
                return;
            }

            NorthWindDataContext dc = new NorthWindDataContext();

            Order neworder = new Order();
            neworder.OrderDate = DateTime.Now;
            neworder.CustomerID = comboBoxCustomer.SelectedValue.ToString();
            neworder.EmployeeID = (int)comboBoxEmployee.SelectedValue;
            neworder.ShipVia = (int)comboBoxShipping.SelectedValue;

            dc.Orders.InsertOnSubmit(neworder);

            dc.SubmitChanges();

            foreach (ListViewItem item in listViewProducts.Items)
            {
                Order_Detail orderdetail = new Order_Detail();
                orderdetail.OrderID = neworder.OrderID;
                orderdetail.ProductID = (int)item.Tag;
                orderdetail.UnitPrice = decimal.Parse(item.SubItems[1].Text);
                orderdetail.Quantity = short.Parse(item.SubItems[2].Text);
                orderdetail.Discount = float.Parse(item.SubItems[3].Text)/100;
                dc.Order_Details.InsertOnSubmit(orderdetail);
                dc.SubmitChanges();

            }

            listViewProducts.Items.Clear();
            comboBoxCustomer.SelectedIndex = comboBoxEmployee.SelectedIndex = comboBoxShipping.SelectedIndex = -1;
        }

        private void btnListSales_Click(object sender, EventArgs e)
        {
            FormListSales form = new FormListSales();
            form.ShippingId = (int)comboBoxShipping.SelectedValue;
            form.CustomerId = comboBoxCustomer.SelectedValue.ToString();
            form.EmployeeId = (int)comboBoxEmployee.SelectedValue;

            form.Show();
        }

        private void btnCSPaper_Click(object sender, EventArgs e)
        {
            CustomerSalesPaper csp = new CustomerSalesPaper();

            csp.Show();
        }
    }
}
