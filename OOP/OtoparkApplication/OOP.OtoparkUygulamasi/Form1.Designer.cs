namespace OOP.OtoparkUygulamasi
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxGiris = new System.Windows.Forms.GroupBox();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.checkBoxAbone = new System.Windows.Forms.CheckBox();
            this.checkBoxKontakVar = new System.Windows.Forms.CheckBox();
            this.listBoxAracTip = new System.Windows.Forms.ListBox();
            this.textBoxPlaka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDurum = new System.Windows.Forms.GroupBox();
            this.buttonSatisRaporu = new System.Windows.Forms.Button();
            this.labelUcret = new System.Windows.Forms.Label();
            this.labelSure = new System.Windows.Forms.Label();
            this.labelPlaka = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxOtoparkAraclar = new System.Windows.Forms.GroupBox();
            this.listBoxOtoparkAraclar = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cikisYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxGiris.SuspendLayout();
            this.groupBoxDurum.SuspendLayout();
            this.groupBoxOtoparkAraclar.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxGiris
            // 
            this.groupBoxGiris.Controls.Add(this.buttonEkle);
            this.groupBoxGiris.Controls.Add(this.checkBoxAbone);
            this.groupBoxGiris.Controls.Add(this.checkBoxKontakVar);
            this.groupBoxGiris.Controls.Add(this.listBoxAracTip);
            this.groupBoxGiris.Controls.Add(this.textBoxPlaka);
            this.groupBoxGiris.Controls.Add(this.label2);
            this.groupBoxGiris.Controls.Add(this.label1);
            this.groupBoxGiris.Location = new System.Drawing.Point(12, 12);
            this.groupBoxGiris.Name = "groupBoxGiris";
            this.groupBoxGiris.Size = new System.Drawing.Size(277, 231);
            this.groupBoxGiris.TabIndex = 0;
            this.groupBoxGiris.TabStop = false;
            this.groupBoxGiris.Text = "Giris";
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(194, 198);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(75, 23);
            this.buttonEkle.TabIndex = 6;
            this.buttonEkle.Text = "EKLE";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // checkBoxAbone
            // 
            this.checkBoxAbone.AutoSize = true;
            this.checkBoxAbone.Location = new System.Drawing.Point(212, 175);
            this.checkBoxAbone.Name = "checkBoxAbone";
            this.checkBoxAbone.Size = new System.Drawing.Size(57, 17);
            this.checkBoxAbone.TabIndex = 5;
            this.checkBoxAbone.Text = "Abone";
            this.checkBoxAbone.UseVisualStyleBackColor = true;
            // 
            // checkBoxKontakVar
            // 
            this.checkBoxKontakVar.AutoSize = true;
            this.checkBoxKontakVar.Location = new System.Drawing.Point(115, 175);
            this.checkBoxKontakVar.Name = "checkBoxKontakVar";
            this.checkBoxKontakVar.Size = new System.Drawing.Size(79, 17);
            this.checkBoxKontakVar.TabIndex = 4;
            this.checkBoxKontakVar.Text = "Kontak Var";
            this.checkBoxKontakVar.UseVisualStyleBackColor = true;
            // 
            // listBoxAracTip
            // 
            this.listBoxAracTip.FormattingEnabled = true;
            this.listBoxAracTip.Location = new System.Drawing.Point(115, 63);
            this.listBoxAracTip.Name = "listBoxAracTip";
            this.listBoxAracTip.Size = new System.Drawing.Size(154, 95);
            this.listBoxAracTip.TabIndex = 3;
            // 
            // textBoxPlaka
            // 
            this.textBoxPlaka.Location = new System.Drawing.Point(115, 37);
            this.textBoxPlaka.Name = "textBoxPlaka";
            this.textBoxPlaka.Size = new System.Drawing.Size(154, 20);
            this.textBoxPlaka.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Arac Tipi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaka :";
            // 
            // groupBoxDurum
            // 
            this.groupBoxDurum.Controls.Add(this.buttonSatisRaporu);
            this.groupBoxDurum.Controls.Add(this.labelUcret);
            this.groupBoxDurum.Controls.Add(this.labelSure);
            this.groupBoxDurum.Controls.Add(this.labelPlaka);
            this.groupBoxDurum.Controls.Add(this.label5);
            this.groupBoxDurum.Controls.Add(this.label4);
            this.groupBoxDurum.Controls.Add(this.label3);
            this.groupBoxDurum.Location = new System.Drawing.Point(12, 249);
            this.groupBoxDurum.Name = "groupBoxDurum";
            this.groupBoxDurum.Size = new System.Drawing.Size(277, 162);
            this.groupBoxDurum.TabIndex = 1;
            this.groupBoxDurum.TabStop = false;
            this.groupBoxDurum.Text = "Durum";
            // 
            // buttonSatisRaporu
            // 
            this.buttonSatisRaporu.Location = new System.Drawing.Point(32, 133);
            this.buttonSatisRaporu.Name = "buttonSatisRaporu";
            this.buttonSatisRaporu.Size = new System.Drawing.Size(221, 23);
            this.buttonSatisRaporu.TabIndex = 6;
            this.buttonSatisRaporu.Text = "Gunluk Satis Raporu";
            this.buttonSatisRaporu.UseVisualStyleBackColor = true;
            this.buttonSatisRaporu.Click += new System.EventHandler(this.buttonSatisRaporu_Click);
            // 
            // labelUcret
            // 
            this.labelUcret.AutoSize = true;
            this.labelUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUcret.Location = new System.Drawing.Point(98, 106);
            this.labelUcret.Name = "labelUcret";
            this.labelUcret.Size = new System.Drawing.Size(37, 17);
            this.labelUcret.TabIndex = 5;
            this.labelUcret.Text = "0 TL";
            // 
            // labelSure
            // 
            this.labelSure.AutoSize = true;
            this.labelSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSure.Location = new System.Drawing.Point(98, 68);
            this.labelSure.Name = "labelSure";
            this.labelSure.Size = new System.Drawing.Size(49, 17);
            this.labelSure.TabIndex = 4;
            this.labelSure.Text = "0 Saat";
            // 
            // labelPlaka
            // 
            this.labelPlaka.AutoSize = true;
            this.labelPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPlaka.Location = new System.Drawing.Point(98, 28);
            this.labelPlaka.Name = "labelPlaka";
            this.labelPlaka.Size = new System.Drawing.Size(74, 17);
            this.labelPlaka.TabIndex = 3;
            this.labelPlaka.Text = "00 XX 000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(29, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ucret";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(29, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(29, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Plaka";
            // 
            // groupBoxOtoparkAraclar
            // 
            this.groupBoxOtoparkAraclar.Controls.Add(this.listBoxOtoparkAraclar);
            this.groupBoxOtoparkAraclar.Location = new System.Drawing.Point(311, 12);
            this.groupBoxOtoparkAraclar.Name = "groupBoxOtoparkAraclar";
            this.groupBoxOtoparkAraclar.Size = new System.Drawing.Size(428, 399);
            this.groupBoxOtoparkAraclar.TabIndex = 2;
            this.groupBoxOtoparkAraclar.TabStop = false;
            this.groupBoxOtoparkAraclar.Text = "Otopark Araclar";
            // 
            // listBoxOtoparkAraclar
            // 
            this.listBoxOtoparkAraclar.ContextMenuStrip = this.contextMenuStrip1;
            this.listBoxOtoparkAraclar.FormattingEnabled = true;
            this.listBoxOtoparkAraclar.Location = new System.Drawing.Point(22, 19);
            this.listBoxOtoparkAraclar.Name = "listBoxOtoparkAraclar";
            this.listBoxOtoparkAraclar.Size = new System.Drawing.Size(385, 368);
            this.listBoxOtoparkAraclar.TabIndex = 0;
            this.listBoxOtoparkAraclar.SelectedIndexChanged += new System.EventHandler(this.listBoxOtoparkAraclar_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cikisYapToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 26);
            // 
            // cikisYapToolStripMenuItem
            // 
            this.cikisYapToolStripMenuItem.Name = "cikisYapToolStripMenuItem";
            this.cikisYapToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cikisYapToolStripMenuItem.Text = "Cikis Yap";
            this.cikisYapToolStripMenuItem.Click += new System.EventHandler(this.CikisYap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 423);
            this.Controls.Add(this.groupBoxOtoparkAraclar);
            this.Controls.Add(this.groupBoxDurum);
            this.Controls.Add(this.groupBoxGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "OTOPARK UYGULAMASI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxGiris.ResumeLayout(false);
            this.groupBoxGiris.PerformLayout();
            this.groupBoxDurum.ResumeLayout(false);
            this.groupBoxDurum.PerformLayout();
            this.groupBoxOtoparkAraclar.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGiris;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.CheckBox checkBoxAbone;
        private System.Windows.Forms.CheckBox checkBoxKontakVar;
        private System.Windows.Forms.ListBox listBoxAracTip;
        private System.Windows.Forms.TextBox textBoxPlaka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxDurum;
        private System.Windows.Forms.Button buttonSatisRaporu;
        private System.Windows.Forms.Label labelUcret;
        private System.Windows.Forms.Label labelSure;
        private System.Windows.Forms.Label labelPlaka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxOtoparkAraclar;
        private System.Windows.Forms.ListBox listBoxOtoparkAraclar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cikisYapToolStripMenuItem;
    }
}

