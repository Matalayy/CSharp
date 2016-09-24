namespace OOP.Delegate_And_Event
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
            this.btnDelegate = new System.Windows.Forms.Button();
            this.labelDelegate = new System.Windows.Forms.Label();
            this.txtDelegate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDelegate
            // 
            this.btnDelegate.Location = new System.Drawing.Point(96, 60);
            this.btnDelegate.Name = "btnDelegate";
            this.btnDelegate.Size = new System.Drawing.Size(93, 23);
            this.btnDelegate.TabIndex = 0;
            this.btnDelegate.Text = "Delegate";
            this.btnDelegate.UseVisualStyleBackColor = true;
            this.btnDelegate.Click += new System.EventHandler(this.btnDelegate_Click);
            // 
            // labelDelegate
            // 
            this.labelDelegate.AutoSize = true;
            this.labelDelegate.Location = new System.Drawing.Point(93, 113);
            this.labelDelegate.Name = "labelDelegate";
            this.labelDelegate.Size = new System.Drawing.Size(50, 13);
            this.labelDelegate.TabIndex = 1;
            this.labelDelegate.Text = "Delegate";
            // 
            // txtDelegate
            // 
            this.txtDelegate.Location = new System.Drawing.Point(96, 159);
            this.txtDelegate.Name = "txtDelegate";
            this.txtDelegate.Size = new System.Drawing.Size(93, 20);
            this.txtDelegate.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtDelegate);
            this.Controls.Add(this.labelDelegate);
            this.Controls.Add(this.btnDelegate);
            this.Name = "Form1";
            this.Text = "DelegateAndEvent";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelegate;
        private System.Windows.Forms.Label labelDelegate;
        private System.Windows.Forms.TextBox txtDelegate;
    }
}

