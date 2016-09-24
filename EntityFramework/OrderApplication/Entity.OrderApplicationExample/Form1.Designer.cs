namespace Entity.OrderApplicationExample
{
    partial class FormOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.comboBoxShipping = new System.Windows.Forms.ComboBox();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.numericDiscount = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnApproveOrder = new System.Windows.Forms.Button();
            this.btnListSales = new System.Windows.Forms.Button();
            this.btnCSPaper = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(579, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Shipping";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Discount";
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(825, 218);
            this.dataGridViewProducts.TabIndex = 0;
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(648, 314);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(160, 21);
            this.comboBoxCustomer.TabIndex = 4;
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(648, 350);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(160, 21);
            this.comboBoxEmployee.TabIndex = 5;
            // 
            // comboBoxShipping
            // 
            this.comboBoxShipping.FormattingEnabled = true;
            this.comboBoxShipping.Location = new System.Drawing.Point(648, 383);
            this.comboBoxShipping.Name = "comboBoxShipping";
            this.comboBoxShipping.Size = new System.Drawing.Size(160, 21);
            this.comboBoxShipping.TabIndex = 6;
            // 
            // numericQuantity
            // 
            this.numericQuantity.Location = new System.Drawing.Point(15, 268);
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(120, 20);
            this.numericQuantity.TabIndex = 1;
            // 
            // numericDiscount
            // 
            this.numericDiscount.Location = new System.Drawing.Point(141, 268);
            this.numericDiscount.Name = "numericDiscount";
            this.numericDiscount.Size = new System.Drawing.Size(120, 20);
            this.numericDiscount.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(282, 265);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add New Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listViewProducts
            // 
            this.listViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewProducts.FullRowSelect = true;
            this.listViewProducts.GridLines = true;
            this.listViewProducts.Location = new System.Drawing.Point(15, 311);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(473, 183);
            this.listViewProducts.TabIndex = 12;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product Name";
            this.columnHeader1.Width = 165;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Unit Price";
            this.columnHeader2.Width = 126;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Discount";
            this.columnHeader4.Width = 85;
            // 
            // btnApproveOrder
            // 
            this.btnApproveOrder.Location = new System.Drawing.Point(582, 436);
            this.btnApproveOrder.Name = "btnApproveOrder";
            this.btnApproveOrder.Size = new System.Drawing.Size(226, 23);
            this.btnApproveOrder.TabIndex = 7;
            this.btnApproveOrder.Text = "Approve Order";
            this.btnApproveOrder.UseVisualStyleBackColor = true;
            this.btnApproveOrder.Click += new System.EventHandler(this.btnApproveOrder_Click);
            // 
            // btnListSales
            // 
            this.btnListSales.Location = new System.Drawing.Point(582, 471);
            this.btnListSales.Name = "btnListSales";
            this.btnListSales.Size = new System.Drawing.Size(92, 23);
            this.btnListSales.TabIndex = 13;
            this.btnListSales.Text = "List Sales";
            this.btnListSales.UseVisualStyleBackColor = true;
            this.btnListSales.Click += new System.EventHandler(this.btnListSales_Click);
            // 
            // btnCSPaper
            // 
            this.btnCSPaper.Location = new System.Drawing.Point(685, 471);
            this.btnCSPaper.Name = "btnCSPaper";
            this.btnCSPaper.Size = new System.Drawing.Size(123, 23);
            this.btnCSPaper.TabIndex = 14;
            this.btnCSPaper.Text = "Customer Sales Paper";
            this.btnCSPaper.UseVisualStyleBackColor = true;
            this.btnCSPaper.Click += new System.EventHandler(this.btnCSPaper_Click);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 506);
            this.Controls.Add(this.btnCSPaper);
            this.Controls.Add(this.btnListSales);
            this.Controls.Add(this.btnApproveOrder);
            this.Controls.Add(this.listViewProducts);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numericDiscount);
            this.Controls.Add(this.numericQuantity);
            this.Controls.Add(this.comboBoxShipping);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.comboBoxCustomer);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormOrder";
            this.Text = "Order Application With Linq Example";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.ComboBox comboBoxShipping;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.NumericUpDown numericDiscount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnApproveOrder;
        private System.Windows.Forms.Button btnListSales;
        private System.Windows.Forms.Button btnCSPaper;
    }
}

