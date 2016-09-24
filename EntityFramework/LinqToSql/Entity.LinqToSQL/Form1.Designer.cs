namespace Entity.LinqToSQL
{
    partial class Form1
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
            this.dataGridViewNorthWind = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.cBoxCategory = new System.Windows.Forms.ComboBox();
            this.cBoxSupplier = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUnitsInStock = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rdbProductName = new System.Windows.Forms.RadioButton();
            this.rdbUnitPrice = new System.Windows.Forms.RadioButton();
            this.rdbUnitsInStcok = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNorthWind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUnitsInStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNorthWind
            // 
            this.dataGridViewNorthWind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNorthWind.Location = new System.Drawing.Point(3, 121);
            this.dataGridViewNorthWind.Name = "dataGridViewNorthWind";
            this.dataGridViewNorthWind.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNorthWind.Size = new System.Drawing.Size(868, 249);
            this.dataGridViewNorthWind.TabIndex = 0;
            this.dataGridViewNorthWind.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNorthWind_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(137, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(256, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Supplier";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(4, 41);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(96, 20);
            this.txtProductName.TabIndex = 4;
            // 
            // cBoxCategory
            // 
            this.cBoxCategory.FormattingEnabled = true;
            this.cBoxCategory.Location = new System.Drawing.Point(130, 40);
            this.cBoxCategory.Name = "cBoxCategory";
            this.cBoxCategory.Size = new System.Drawing.Size(96, 21);
            this.cBoxCategory.TabIndex = 5;
            // 
            // cBoxSupplier
            // 
            this.cBoxSupplier.FormattingEnabled = true;
            this.cBoxSupplier.Location = new System.Drawing.Point(249, 40);
            this.cBoxSupplier.Name = "cBoxSupplier";
            this.cBoxSupplier.Size = new System.Drawing.Size(96, 21);
            this.cBoxSupplier.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(385, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Unit Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(518, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Units In Stock";
            // 
            // numericUnitPrice
            // 
            this.numericUnitPrice.Location = new System.Drawing.Point(377, 40);
            this.numericUnitPrice.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUnitPrice.Name = "numericUnitPrice";
            this.numericUnitPrice.Size = new System.Drawing.Size(96, 20);
            this.numericUnitPrice.TabIndex = 9;
            // 
            // numericUnitsInStock
            // 
            this.numericUnitsInStock.Location = new System.Drawing.Point(510, 40);
            this.numericUnitsInStock.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUnitsInStock.Name = "numericUnitsInStock";
            this.numericUnitsInStock.Size = new System.Drawing.Size(97, 20);
            this.numericUnitsInStock.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(622, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(714, 37);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(796, 37);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Filter";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(53, 388);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(100, 20);
            this.txtFilter.TabIndex = 15;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "ALIGN";
            // 
            // rdbProductName
            // 
            this.rdbProductName.AutoSize = true;
            this.rdbProductName.Location = new System.Drawing.Point(68, 84);
            this.rdbProductName.Name = "rdbProductName";
            this.rdbProductName.Size = new System.Drawing.Size(93, 17);
            this.rdbProductName.TabIndex = 17;
            this.rdbProductName.TabStop = true;
            this.rdbProductName.Text = "Product Name";
            this.rdbProductName.UseVisualStyleBackColor = true;
            this.rdbProductName.CheckedChanged += new System.EventHandler(this.rdbProductName_CheckedChanged);
            // 
            // rdbUnitPrice
            // 
            this.rdbUnitPrice.AutoSize = true;
            this.rdbUnitPrice.Location = new System.Drawing.Point(175, 84);
            this.rdbUnitPrice.Name = "rdbUnitPrice";
            this.rdbUnitPrice.Size = new System.Drawing.Size(71, 17);
            this.rdbUnitPrice.TabIndex = 19;
            this.rdbUnitPrice.TabStop = true;
            this.rdbUnitPrice.Text = "Unit Price";
            this.rdbUnitPrice.UseVisualStyleBackColor = true;
            this.rdbUnitPrice.CheckedChanged += new System.EventHandler(this.rdbProductName_CheckedChanged);
            // 
            // rdbUnitsInStcok
            // 
            this.rdbUnitsInStcok.AutoSize = true;
            this.rdbUnitsInStcok.Location = new System.Drawing.Point(289, 84);
            this.rdbUnitsInStcok.Name = "rdbUnitsInStcok";
            this.rdbUnitsInStcok.Size = new System.Drawing.Size(92, 17);
            this.rdbUnitsInStcok.TabIndex = 21;
            this.rdbUnitsInStcok.TabStop = true;
            this.rdbUnitsInStcok.Text = "Units In Stock";
            this.rdbUnitsInStcok.UseVisualStyleBackColor = true;
            this.rdbUnitsInStcok.CheckedChanged += new System.EventHandler(this.rdbProductName_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 413);
            this.Controls.Add(this.rdbUnitsInStcok);
            this.Controls.Add(this.rdbUnitPrice);
            this.Controls.Add(this.rdbProductName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numericUnitsInStock);
            this.Controls.Add(this.numericUnitPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBoxSupplier);
            this.Controls.Add(this.cBoxCategory);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewNorthWind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNorthWind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUnitsInStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNorthWind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.ComboBox cBoxCategory;
        private System.Windows.Forms.ComboBox cBoxSupplier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUnitPrice;
        private System.Windows.Forms.NumericUpDown numericUnitsInStock;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdbProductName;
        private System.Windows.Forms.RadioButton rdbUnitPrice;
        private System.Windows.Forms.RadioButton rdbUnitsInStcok;
    }
}

