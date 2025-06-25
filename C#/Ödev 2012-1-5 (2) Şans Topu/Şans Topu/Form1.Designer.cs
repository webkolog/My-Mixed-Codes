namespace Şans_Topu
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
            this.grpOynanan = new System.Windows.Forms.GroupBox();
            this.lisOynanan = new System.Windows.Forms.ListBox();
            this.btnOtoOyna = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnCekilisYap = new System.Windows.Forms.Button();
            this.grpSonuclar = new System.Windows.Forms.GroupBox();
            this.lblTutunlar = new System.Windows.Forms.Label();
            this.lblSonuclar = new System.Windows.Forms.Label();
            this.grpKolonOyna = new System.Windows.Forms.GroupBox();
            this.btnKolonEkle = new System.Windows.Forms.Button();
            this.txtKolon1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKolon2 = new System.Windows.Forms.TextBox();
            this.txtKolon3 = new System.Windows.Forms.TextBox();
            this.txtKolon4 = new System.Windows.Forms.TextBox();
            this.txtKolon5 = new System.Windows.Forms.TextBox();
            this.txtKolon6 = new System.Windows.Forms.TextBox();
            this.grpOynanan.SuspendLayout();
            this.grpSonuclar.SuspendLayout();
            this.grpKolonOyna.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOynanan
            // 
            this.grpOynanan.Controls.Add(this.lisOynanan);
            this.grpOynanan.Controls.Add(this.btnOtoOyna);
            this.grpOynanan.Controls.Add(this.btnTemizle);
            this.grpOynanan.Location = new System.Drawing.Point(262, 12);
            this.grpOynanan.Name = "grpOynanan";
            this.grpOynanan.Size = new System.Drawing.Size(200, 352);
            this.grpOynanan.TabIndex = 9;
            this.grpOynanan.TabStop = false;
            this.grpOynanan.Text = "Oynanan";
            // 
            // lisOynanan
            // 
            this.lisOynanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lisOynanan.FormattingEnabled = true;
            this.lisOynanan.ItemHeight = 20;
            this.lisOynanan.Location = new System.Drawing.Point(6, 19);
            this.lisOynanan.Name = "lisOynanan";
            this.lisOynanan.Size = new System.Drawing.Size(188, 264);
            this.lisOynanan.TabIndex = 4;
            // 
            // btnOtoOyna
            // 
            this.btnOtoOyna.Location = new System.Drawing.Point(6, 321);
            this.btnOtoOyna.Name = "btnOtoOyna";
            this.btnOtoOyna.Size = new System.Drawing.Size(188, 23);
            this.btnOtoOyna.TabIndex = 3;
            this.btnOtoOyna.Text = "Otomatik Oyna";
            this.btnOtoOyna.UseVisualStyleBackColor = true;
            this.btnOtoOyna.Click += new System.EventHandler(this.btnOtoOyna_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(6, 292);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(188, 23);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnCekilisYap
            // 
            this.btnCekilisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCekilisYap.Location = new System.Drawing.Point(12, 93);
            this.btnCekilisYap.Name = "btnCekilisYap";
            this.btnCekilisYap.Size = new System.Drawing.Size(244, 36);
            this.btnCekilisYap.TabIndex = 8;
            this.btnCekilisYap.Text = "Çekiliş Yap";
            this.btnCekilisYap.UseVisualStyleBackColor = true;
            this.btnCekilisYap.Click += new System.EventHandler(this.btnCekilisYap_Click);
            // 
            // grpSonuclar
            // 
            this.grpSonuclar.Controls.Add(this.lblTutunlar);
            this.grpSonuclar.Controls.Add(this.lblSonuclar);
            this.grpSonuclar.Location = new System.Drawing.Point(12, 135);
            this.grpSonuclar.Name = "grpSonuclar";
            this.grpSonuclar.Size = new System.Drawing.Size(244, 229);
            this.grpSonuclar.TabIndex = 6;
            this.grpSonuclar.TabStop = false;
            this.grpSonuclar.Text = "Sonuçlar";
            // 
            // lblTutunlar
            // 
            this.lblTutunlar.BackColor = System.Drawing.Color.White;
            this.lblTutunlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutunlar.Location = new System.Drawing.Point(7, 50);
            this.lblTutunlar.Name = "lblTutunlar";
            this.lblTutunlar.Size = new System.Drawing.Size(231, 171);
            this.lblTutunlar.TabIndex = 1;
            this.lblTutunlar.Text = "\r\n";
            this.lblTutunlar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSonuclar
            // 
            this.lblSonuclar.BackColor = System.Drawing.Color.White;
            this.lblSonuclar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuclar.Location = new System.Drawing.Point(6, 16);
            this.lblSonuclar.Name = "lblSonuclar";
            this.lblSonuclar.Size = new System.Drawing.Size(232, 22);
            this.lblSonuclar.TabIndex = 0;
            this.lblSonuclar.Text = "\r\n";
            this.lblSonuclar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpKolonOyna
            // 
            this.grpKolonOyna.Controls.Add(this.btnKolonEkle);
            this.grpKolonOyna.Controls.Add(this.txtKolon1);
            this.grpKolonOyna.Controls.Add(this.label8);
            this.grpKolonOyna.Controls.Add(this.txtKolon2);
            this.grpKolonOyna.Controls.Add(this.txtKolon3);
            this.grpKolonOyna.Controls.Add(this.txtKolon4);
            this.grpKolonOyna.Controls.Add(this.txtKolon5);
            this.grpKolonOyna.Controls.Add(this.txtKolon6);
            this.grpKolonOyna.Location = new System.Drawing.Point(12, 12);
            this.grpKolonOyna.Name = "grpKolonOyna";
            this.grpKolonOyna.Size = new System.Drawing.Size(244, 74);
            this.grpKolonOyna.TabIndex = 7;
            this.grpKolonOyna.TabStop = false;
            this.grpKolonOyna.Text = "Kolon Oyna";
            // 
            // btnKolonEkle
            // 
            this.btnKolonEkle.Location = new System.Drawing.Point(6, 45);
            this.btnKolonEkle.Name = "btnKolonEkle";
            this.btnKolonEkle.Size = new System.Drawing.Size(229, 23);
            this.btnKolonEkle.TabIndex = 3;
            this.btnKolonEkle.Text = "Kolon Ekle";
            this.btnKolonEkle.UseVisualStyleBackColor = true;
            this.btnKolonEkle.Click += new System.EventHandler(this.btnKolonEkle_Click);
            // 
            // txtKolon1
            // 
            this.txtKolon1.Location = new System.Drawing.Point(6, 19);
            this.txtKolon1.MaxLength = 2;
            this.txtKolon1.Name = "txtKolon1";
            this.txtKolon1.Size = new System.Drawing.Size(30, 20);
            this.txtKolon1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(186, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "+";
            // 
            // txtKolon2
            // 
            this.txtKolon2.Location = new System.Drawing.Point(42, 19);
            this.txtKolon2.MaxLength = 2;
            this.txtKolon2.Name = "txtKolon2";
            this.txtKolon2.Size = new System.Drawing.Size(30, 20);
            this.txtKolon2.TabIndex = 0;
            // 
            // txtKolon3
            // 
            this.txtKolon3.Location = new System.Drawing.Point(78, 19);
            this.txtKolon3.MaxLength = 2;
            this.txtKolon3.Name = "txtKolon3";
            this.txtKolon3.Size = new System.Drawing.Size(30, 20);
            this.txtKolon3.TabIndex = 0;
            // 
            // txtKolon4
            // 
            this.txtKolon4.Location = new System.Drawing.Point(114, 19);
            this.txtKolon4.MaxLength = 2;
            this.txtKolon4.Name = "txtKolon4";
            this.txtKolon4.Size = new System.Drawing.Size(30, 20);
            this.txtKolon4.TabIndex = 0;
            // 
            // txtKolon5
            // 
            this.txtKolon5.Location = new System.Drawing.Point(150, 19);
            this.txtKolon5.MaxLength = 2;
            this.txtKolon5.Name = "txtKolon5";
            this.txtKolon5.Size = new System.Drawing.Size(30, 20);
            this.txtKolon5.TabIndex = 0;
            // 
            // txtKolon6
            // 
            this.txtKolon6.Location = new System.Drawing.Point(205, 19);
            this.txtKolon6.MaxLength = 2;
            this.txtKolon6.Name = "txtKolon6";
            this.txtKolon6.Size = new System.Drawing.Size(30, 20);
            this.txtKolon6.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 373);
            this.Controls.Add(this.grpOynanan);
            this.Controls.Add(this.btnCekilisYap);
            this.Controls.Add(this.grpSonuclar);
            this.Controls.Add(this.grpKolonOyna);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(489, 411);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(489, 411);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.grpOynanan.ResumeLayout(false);
            this.grpSonuclar.ResumeLayout(false);
            this.grpKolonOyna.ResumeLayout(false);
            this.grpKolonOyna.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOynanan;
        private System.Windows.Forms.ListBox lisOynanan;
        private System.Windows.Forms.Button btnOtoOyna;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnCekilisYap;
        private System.Windows.Forms.GroupBox grpSonuclar;
        private System.Windows.Forms.Label lblTutunlar;
        private System.Windows.Forms.Label lblSonuclar;
        private System.Windows.Forms.GroupBox grpKolonOyna;
        private System.Windows.Forms.Button btnKolonEkle;
        private System.Windows.Forms.TextBox txtKolon1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKolon2;
        private System.Windows.Forms.TextBox txtKolon3;
        private System.Windows.Forms.TextBox txtKolon4;
        private System.Windows.Forms.TextBox txtKolon5;
        private System.Windows.Forms.TextBox txtKolon6;
    }
}

