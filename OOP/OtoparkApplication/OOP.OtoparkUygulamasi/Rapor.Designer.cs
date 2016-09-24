namespace OOP.OtoparkUygulamasi
{
    partial class Rapor
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxToplamBilgiler = new System.Windows.Forms.GroupBox();
            this.labelToplamUcret = new System.Windows.Forms.Label();
            this.labelToplamArac = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxToplamBilgiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(513, 333);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "PLAKA";
            this.columnHeader1.Width = 128;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "TiP";
            this.columnHeader2.Width = 117;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ABONE";
            this.columnHeader3.Width = 105;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SURE";
            this.columnHeader4.Width = 81;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "UCRET";
            this.columnHeader5.Width = 75;
            // 
            // groupBoxToplamBilgiler
            // 
            this.groupBoxToplamBilgiler.Controls.Add(this.labelToplamUcret);
            this.groupBoxToplamBilgiler.Controls.Add(this.labelToplamArac);
            this.groupBoxToplamBilgiler.Controls.Add(this.label4);
            this.groupBoxToplamBilgiler.Controls.Add(this.label3);
            this.groupBoxToplamBilgiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxToplamBilgiler.Location = new System.Drawing.Point(531, 12);
            this.groupBoxToplamBilgiler.Name = "groupBoxToplamBilgiler";
            this.groupBoxToplamBilgiler.Size = new System.Drawing.Size(263, 169);
            this.groupBoxToplamBilgiler.TabIndex = 1;
            this.groupBoxToplamBilgiler.TabStop = false;
            this.groupBoxToplamBilgiler.Text = "Toplam Bilgiler";
            // 
            // labelToplamUcret
            // 
            this.labelToplamUcret.AutoSize = true;
            this.labelToplamUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelToplamUcret.Location = new System.Drawing.Point(170, 105);
            this.labelToplamUcret.Name = "labelToplamUcret";
            this.labelToplamUcret.Size = new System.Drawing.Size(37, 17);
            this.labelToplamUcret.TabIndex = 8;
            this.labelToplamUcret.Text = "0 TL";
            // 
            // labelToplamArac
            // 
            this.labelToplamArac.AutoSize = true;
            this.labelToplamArac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelToplamArac.Location = new System.Drawing.Point(191, 46);
            this.labelToplamArac.Name = "labelToplamArac";
            this.labelToplamArac.Size = new System.Drawing.Size(16, 17);
            this.labelToplamArac.TabIndex = 7;
            this.labelToplamArac.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(15, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Toplam Ucret :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = " Toplam Arac Sayisi :";
            // 
            // Rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 406);
            this.Controls.Add(this.groupBoxToplamBilgiler);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Rapor";
            this.Text = "Rapor";
            this.groupBoxToplamBilgiler.ResumeLayout(false);
            this.groupBoxToplamBilgiler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBoxToplamBilgiler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.Label labelToplamUcret;
        public System.Windows.Forms.Label labelToplamArac;
    }
}