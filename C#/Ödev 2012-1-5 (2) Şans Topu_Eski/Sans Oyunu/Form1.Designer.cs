namespace Sans_Oyunu
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
            this.txtKolon1 = new System.Windows.Forms.TextBox();
            this.txtKolon2 = new System.Windows.Forms.TextBox();
            this.txtKolon3 = new System.Windows.Forms.TextBox();
            this.txtKolon4 = new System.Windows.Forms.TextBox();
            this.txtKolon5 = new System.Windows.Forms.TextBox();
            this.txtKolon6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKolonEkle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTutunlar = new System.Windows.Forms.Label();
            this.lblSonuclar = new System.Windows.Forms.Label();
            this.btnCekilisYap = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lisOynanan = new System.Windows.Forms.ListBox();
            this.btnOtoOyna = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKolon1
            // 
            this.txtKolon1.Location = new System.Drawing.Point(6, 19);
            this.txtKolon1.Name = "txtKolon1";
            this.txtKolon1.Size = new System.Drawing.Size(30, 20);
            this.txtKolon1.TabIndex = 0;
            // 
            // txtKolon2
            // 
            this.txtKolon2.Location = new System.Drawing.Point(42, 19);
            this.txtKolon2.Name = "txtKolon2";
            this.txtKolon2.Size = new System.Drawing.Size(30, 20);
            this.txtKolon2.TabIndex = 0;
            // 
            // txtKolon3
            // 
            this.txtKolon3.Location = new System.Drawing.Point(78, 19);
            this.txtKolon3.Name = "txtKolon3";
            this.txtKolon3.Size = new System.Drawing.Size(30, 20);
            this.txtKolon3.TabIndex = 0;
            // 
            // txtKolon4
            // 
            this.txtKolon4.Location = new System.Drawing.Point(114, 19);
            this.txtKolon4.Name = "txtKolon4";
            this.txtKolon4.Size = new System.Drawing.Size(30, 20);
            this.txtKolon4.TabIndex = 0;
            // 
            // txtKolon5
            // 
            this.txtKolon5.Location = new System.Drawing.Point(150, 19);
            this.txtKolon5.Name = "txtKolon5";
            this.txtKolon5.Size = new System.Drawing.Size(30, 20);
            this.txtKolon5.TabIndex = 0;
            // 
            // txtKolon6
            // 
            this.txtKolon6.Location = new System.Drawing.Point(205, 19);
            this.txtKolon6.Name = "txtKolon6";
            this.txtKolon6.Size = new System.Drawing.Size(30, 20);
            this.txtKolon6.TabIndex = 0;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKolonEkle);
            this.groupBox1.Controls.Add(this.txtKolon1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtKolon2);
            this.groupBox1.Controls.Add(this.txtKolon3);
            this.groupBox1.Controls.Add(this.txtKolon4);
            this.groupBox1.Controls.Add(this.txtKolon5);
            this.groupBox1.Controls.Add(this.txtKolon6);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 74);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kolon Oyna";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTutunlar);
            this.groupBox2.Controls.Add(this.lblSonuclar);
            this.groupBox2.Location = new System.Drawing.Point(12, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 229);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sonuçlar";
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
            // btnCekilisYap
            // 
            this.btnCekilisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCekilisYap.Location = new System.Drawing.Point(12, 93);
            this.btnCekilisYap.Name = "btnCekilisYap";
            this.btnCekilisYap.Size = new System.Drawing.Size(244, 36);
            this.btnCekilisYap.TabIndex = 4;
            this.btnCekilisYap.Text = "Çekiliş Yap";
            this.btnCekilisYap.UseVisualStyleBackColor = true;
            this.btnCekilisYap.Click += new System.EventHandler(this.btnCekilisYap_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lisOynanan);
            this.groupBox3.Controls.Add(this.btnOtoOyna);
            this.groupBox3.Controls.Add(this.btnTemizle);
            this.groupBox3.Location = new System.Drawing.Point(262, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 352);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Oynanan";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 373);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCekilisYap);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(493, 411);
            this.MinimumSize = new System.Drawing.Size(493, 411);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şans Topu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtKolon1;
        private System.Windows.Forms.TextBox txtKolon2;
        private System.Windows.Forms.TextBox txtKolon3;
        private System.Windows.Forms.TextBox txtKolon4;
        private System.Windows.Forms.TextBox txtKolon5;
        private System.Windows.Forms.TextBox txtKolon6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKolonEkle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCekilisYap;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lisOynanan;
        private System.Windows.Forms.Button btnOtoOyna;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label lblTutunlar;
        private System.Windows.Forms.Label lblSonuclar;
    }
}

