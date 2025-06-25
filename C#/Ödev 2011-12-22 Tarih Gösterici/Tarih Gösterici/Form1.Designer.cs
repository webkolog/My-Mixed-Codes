namespace Tarih_Gösterici
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
            this.cbGun = new System.Windows.Forms.ComboBox();
            this.cbAy = new System.Windows.Forms.ComboBox();
            this.cbYil = new System.Windows.Forms.ComboBox();
            this.btnTarihGoster = new System.Windows.Forms.Button();
            this.lblTarih1 = new System.Windows.Forms.Label();
            this.lblTarih2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbGun
            // 
            this.cbGun.FormattingEnabled = true;
            this.cbGun.Location = new System.Drawing.Point(8, 12);
            this.cbGun.Name = "cbGun";
            this.cbGun.Size = new System.Drawing.Size(53, 21);
            this.cbGun.TabIndex = 0;
            // 
            // cbAy
            // 
            this.cbAy.FormattingEnabled = true;
            this.cbAy.Location = new System.Drawing.Point(67, 12);
            this.cbAy.Name = "cbAy";
            this.cbAy.Size = new System.Drawing.Size(53, 21);
            this.cbAy.TabIndex = 1;
            // 
            // cbYil
            // 
            this.cbYil.FormattingEnabled = true;
            this.cbYil.Location = new System.Drawing.Point(126, 12);
            this.cbYil.Name = "cbYil";
            this.cbYil.Size = new System.Drawing.Size(61, 21);
            this.cbYil.TabIndex = 2;
            // 
            // btnTarihGoster
            // 
            this.btnTarihGoster.Location = new System.Drawing.Point(8, 39);
            this.btnTarihGoster.Name = "btnTarihGoster";
            this.btnTarihGoster.Size = new System.Drawing.Size(75, 25);
            this.btnTarihGoster.TabIndex = 3;
            this.btnTarihGoster.Text = "Tarih Göster";
            this.btnTarihGoster.UseVisualStyleBackColor = true;
            this.btnTarihGoster.Click += new System.EventHandler(this.btnTarihGoster_Click);
            // 
            // lblTarih1
            // 
            this.lblTarih1.AutoSize = true;
            this.lblTarih1.Location = new System.Drawing.Point(12, 67);
            this.lblTarih1.Name = "lblTarih1";
            this.lblTarih1.Size = new System.Drawing.Size(10, 13);
            this.lblTarih1.TabIndex = 4;
            this.lblTarih1.Text = ".";
            // 
            // lblTarih2
            // 
            this.lblTarih2.AutoSize = true;
            this.lblTarih2.Location = new System.Drawing.Point(98, 67);
            this.lblTarih2.Name = "lblTarih2";
            this.lblTarih2.Size = new System.Drawing.Size(10, 13);
            this.lblTarih2.TabIndex = 5;
            this.lblTarih2.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 88);
            this.Controls.Add(this.lblTarih2);
            this.Controls.Add(this.lblTarih1);
            this.Controls.Add(this.btnTarihGoster);
            this.Controls.Add(this.cbYil);
            this.Controls.Add(this.cbAy);
            this.Controls.Add(this.cbGun);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarih Gösterici";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGun;
        private System.Windows.Forms.ComboBox cbAy;
        private System.Windows.Forms.ComboBox cbYil;
        private System.Windows.Forms.Button btnTarihGoster;
        private System.Windows.Forms.Label lblTarih1;
        private System.Windows.Forms.Label lblTarih2;
    }
}

