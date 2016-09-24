namespace Entity.OrderApplicationExample
{
    partial class FormListSales
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
            this.dataGridViewListSales = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListSales)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListSales
            // 
            this.dataGridViewListSales.AllowUserToAddRows = false;
            this.dataGridViewListSales.AllowUserToDeleteRows = false;
            this.dataGridViewListSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewListSales.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewListSales.Name = "dataGridViewListSales";
            this.dataGridViewListSales.ReadOnly = true;
            this.dataGridViewListSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListSales.Size = new System.Drawing.Size(744, 382);
            this.dataGridViewListSales.TabIndex = 0;
            // 
            // FormListSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 382);
            this.Controls.Add(this.dataGridViewListSales);
            this.Name = "FormListSales";
            this.Text = "FormListSales";
            this.Load += new System.EventHandler(this.FormListSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListSales;
    }
}