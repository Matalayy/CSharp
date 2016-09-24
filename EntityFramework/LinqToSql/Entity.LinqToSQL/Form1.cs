using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity.LinqToSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KuzeyYeliDataContext ctx = new KuzeyYeliDataContext();

            dataGridViewNorthWind.DataSource = ctx.Products;

            cBoxCategory.DataSource = ctx.Categories;
            cBoxCategory.DisplayMember = "CategoryName";
            cBoxCategory.ValueMember = "CategoryID";

            cBoxSupplier.DataSource = ctx.Suppliers;
            cBoxSupplier.DisplayMember = "CompanyName";
            cBoxSupplier.ValueMember = "SupplierID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            KuzeyYeliDataContext ctx = new KuzeyYeliDataContext();

            Product product = new Product();
            product.ProductName = txtProductName.Text;
            product.UnitPrice = numericUnitPrice.Value;
            product.UnitsInStock = (short)numericUnitsInStock.Value;

            product.CategoryID = (int)cBoxCategory.SelectedValue;
            product.SupplierID = (int)cBoxSupplier.SelectedValue;

            ctx.Products.InsertOnSubmit(product);

            ctx.SubmitChanges();

            dataGridViewNorthWind.DataSource = ctx.Products;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int productid =(int)dataGridViewNorthWind.CurrentRow.Cells["ProductID"].Value;

            KuzeyYeliDataContext ctx = new KuzeyYeliDataContext();
            // Lambda expression
            Product product = ctx.Products.SingleOrDefault(Lproduct => Lproduct.ProductID==productid);

            ctx.Products.DeleteOnSubmit(product);
            ctx.SubmitChanges();
            dataGridViewNorthWind.DataSource = ctx.Products;
        }

        private void dataGridViewNorthWind_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgr = dataGridViewNorthWind.CurrentRow;
            txtProductName.Text = dgr.Cells["ProductName"].Value.ToString();
            txtProductName.Tag = dgr.Cells["ProductID"].Value;

            cBoxCategory.SelectedValue = dgr.Cells["CategoryID"].Value;
            cBoxSupplier.SelectedValue = dgr.Cells["SupplierID"].Value;
            numericUnitPrice.Value = (decimal)dgr.Cells["UnitPrice"].Value;
            numericUnitsInStock.Value = (short)dgr.Cells["UnitsInStock"].Value;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int productid = (int)txtProductName.Tag;
            KuzeyYeliDataContext ctx = new KuzeyYeliDataContext();
            Product product = ctx.Products.SingleOrDefault(Lproduct => Lproduct.ProductID == productid);
            product.ProductName = txtProductName.Text;
            product.UnitPrice = numericUnitPrice.Value;
            product.UnitsInStock = (short)numericUnitsInStock.Value;
            product.SupplierID = (int)cBoxSupplier.SelectedValue;
            product.CategoryID = (int)cBoxCategory.SelectedValue;

            ctx.SubmitChanges();
            dataGridViewNorthWind.DataSource = ctx.Products;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            KuzeyYeliDataContext ctx = new KuzeyYeliDataContext();

            dataGridViewNorthWind.DataSource = ctx.Products.Where(x => x.ProductName.Contains(txtFilter.Text));
        }

        private void rdbProductName_CheckedChanged(object sender, EventArgs e)
        {
            KuzeyYeliDataContext ctx = new KuzeyYeliDataContext();

            if (rdbProductName.Checked)
                dataGridViewNorthWind.DataSource = ctx.Products.OrderBy(x => x.ProductName);
            else if (rdbUnitPrice.Checked)
                dataGridViewNorthWind.DataSource = ctx.Products.OrderByDescending(x => x.UnitPrice);
            else if (rdbUnitsInStcok.Checked)
                dataGridViewNorthWind.DataSource = ctx.Products.OrderByDescending(x => x.UnitsInStock);
        }
    }
}
