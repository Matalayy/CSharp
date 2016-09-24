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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            NorthWindDataContext ctx = new NorthWindDataContext();

            var result = from order in ctx.Orders
                         join employee in ctx.Employees on
                         order.EmployeeID equals employee.EmployeeID
                         group order by employee.FirstName into Group
                         select new
                         {
                             EMPLOYEE_NAME = Group.Key,
                             TOTAL_QUANTITY = Group.Count()
                         };

            dataGridView1.DataSource = result;
        }
    }
}
