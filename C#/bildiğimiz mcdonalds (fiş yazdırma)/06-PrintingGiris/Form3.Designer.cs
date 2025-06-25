namespace _06_PrintingGiris
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btnSecileniSil = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.lblParaUstu = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnFisYazdir = new System.Windows.Forms.Button();
            this.btnMenu01 = new System.Windows.Forms.Button();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnHepsiniSil = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCheeseBurger = new System.Windows.Forms.Button();
            this.btnMenu02 = new System.Windows.Forms.Button();
            this.btnKolaBuyuk = new System.Windows.Forms.Button();
            this.btnPatetesBuyuk = new System.Windows.Forms.Button();
            this.btnKolaOrta = new System.Windows.Forms.Button();
            this.btnPatatesOrta = new System.Windows.Forms.Button();
            this.btnKolaKucuk = new System.Windows.Forms.Button();
            this.btnPatetesKucuk = new System.Windows.Forms.Button();
            this.btnHamburger = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // btnSecileniSil
            // 
            this.btnSecileniSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSecileniSil.Location = new System.Drawing.Point(304, 201);
            this.btnSecileniSil.Name = "btnSecileniSil";
            this.btnSecileniSil.Size = new System.Drawing.Size(75, 56);
            this.btnSecileniSil.TabIndex = 29;
            this.btnSecileniSil.Text = "Secileni Sil";
            this.btnSecileniSil.UseVisualStyleBackColor = true;
            this.btnSecileniSil.Click += new System.EventHandler(this.btnSecileniSil_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(561, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(74, 30);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "0";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Toplam Fiyat";
            this.columnHeader5.Width = 82;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(632, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "TL";
            // 
            // lblParaUstu
            // 
            this.lblParaUstu.AutoSize = true;
            this.lblParaUstu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParaUstu.Location = new System.Drawing.Point(582, 99);
            this.lblParaUstu.Name = "lblParaUstu";
            this.lblParaUstu.Size = new System.Drawing.Size(79, 25);
            this.lblParaUstu.TabIndex = 25;
            this.lblParaUstu.Text = "0.00 TL";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.Location = new System.Drawing.Point(582, 18);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(79, 25);
            this.lblToplamTutar.TabIndex = 26;
            this.lblToplamTutar.Text = "0.00 TL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(386, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 31);
            this.label4.TabIndex = 21;
            this.label4.Text = "Para Ustu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(386, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 31);
            this.label3.TabIndex = 22;
            this.label3.Text = "Alinan Tutar";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Adet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(386, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Toplam Tutar";
            // 
            // btnFisYazdir
            // 
            this.btnFisYazdir.BackColor = System.Drawing.Color.Crimson;
            this.btnFisYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFisYazdir.Location = new System.Drawing.Point(307, 11);
            this.btnFisYazdir.Name = "btnFisYazdir";
            this.btnFisYazdir.Size = new System.Drawing.Size(72, 183);
            this.btnFisYazdir.TabIndex = 20;
            this.btnFisYazdir.Text = "Fiş Yazdır";
            this.btnFisYazdir.UseVisualStyleBackColor = false;
            this.btnFisYazdir.Click += new System.EventHandler(this.btnFisYazdir_Click);
            // 
            // btnMenu01
            // 
            this.btnMenu01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenu01.Location = new System.Drawing.Point(12, 12);
            this.btnMenu01.Name = "btnMenu01";
            this.btnMenu01.Size = new System.Drawing.Size(141, 57);
            this.btnMenu01.TabIndex = 18;
            this.btnMenu01.Text = "Menu01";
            this.btnMenu01.UseVisualStyleBackColor = true;
            this.btnMenu01.Click += new System.EventHandler(this.btnMenu01_Click);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Birim Fiyat";
            this.columnHeader3.Width = 67;
            // 
            // btnHepsiniSil
            // 
            this.btnHepsiniSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHepsiniSil.Location = new System.Drawing.Point(303, 263);
            this.btnHepsiniSil.Name = "btnHepsiniSil";
            this.btnHepsiniSil.Size = new System.Drawing.Size(76, 56);
            this.btnHepsiniSil.TabIndex = 30;
            this.btnHepsiniSil.Text = "Hepsini Sil";
            this.btnHepsiniSil.UseVisualStyleBackColor = true;
            this.btnHepsiniSil.Click += new System.EventHandler(this.btnHepsiniSil_Click);
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
            this.listView1.Location = new System.Drawing.Point(12, 327);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(367, 303);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 38;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Urun Adı";
            this.columnHeader2.Width = 113;
            // 
            // btnCheeseBurger
            // 
            this.btnCheeseBurger.BackColor = System.Drawing.Color.Gold;
            this.btnCheeseBurger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCheeseBurger.Location = new System.Drawing.Point(160, 74);
            this.btnCheeseBurger.Name = "btnCheeseBurger";
            this.btnCheeseBurger.Size = new System.Drawing.Size(141, 57);
            this.btnCheeseBurger.TabIndex = 12;
            this.btnCheeseBurger.Text = "CheeseBurger";
            this.btnCheeseBurger.UseVisualStyleBackColor = false;
            this.btnCheeseBurger.Click += new System.EventHandler(this.btnCheeseBurger_Click);
            // 
            // btnMenu02
            // 
            this.btnMenu02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenu02.Location = new System.Drawing.Point(160, 11);
            this.btnMenu02.Name = "btnMenu02";
            this.btnMenu02.Size = new System.Drawing.Size(141, 57);
            this.btnMenu02.TabIndex = 9;
            this.btnMenu02.Text = "Menu02";
            this.btnMenu02.UseVisualStyleBackColor = true;
            this.btnMenu02.Click += new System.EventHandler(this.btnMenu02_Click);
            // 
            // btnKolaBuyuk
            // 
            this.btnKolaBuyuk.BackColor = System.Drawing.Color.IndianRed;
            this.btnKolaBuyuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKolaBuyuk.Location = new System.Drawing.Point(156, 263);
            this.btnKolaBuyuk.Name = "btnKolaBuyuk";
            this.btnKolaBuyuk.Size = new System.Drawing.Size(141, 57);
            this.btnKolaBuyuk.TabIndex = 10;
            this.btnKolaBuyuk.Text = "Kola (Buyuk)";
            this.btnKolaBuyuk.UseVisualStyleBackColor = false;
            this.btnKolaBuyuk.Click += new System.EventHandler(this.btnKolaBuyuk_Click);
            // 
            // btnPatetesBuyuk
            // 
            this.btnPatetesBuyuk.BackColor = System.Drawing.Color.Khaki;
            this.btnPatetesBuyuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPatetesBuyuk.Location = new System.Drawing.Point(9, 263);
            this.btnPatetesBuyuk.Name = "btnPatetesBuyuk";
            this.btnPatetesBuyuk.Size = new System.Drawing.Size(141, 57);
            this.btnPatetesBuyuk.TabIndex = 13;
            this.btnPatetesBuyuk.Text = "Patetes (Buyuk)";
            this.btnPatetesBuyuk.UseVisualStyleBackColor = false;
            this.btnPatetesBuyuk.Click += new System.EventHandler(this.btnPatetesBuyuk_Click);
            // 
            // btnKolaOrta
            // 
            this.btnKolaOrta.BackColor = System.Drawing.Color.IndianRed;
            this.btnKolaOrta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKolaOrta.Location = new System.Drawing.Point(156, 200);
            this.btnKolaOrta.Name = "btnKolaOrta";
            this.btnKolaOrta.Size = new System.Drawing.Size(141, 57);
            this.btnKolaOrta.TabIndex = 16;
            this.btnKolaOrta.Text = "Kola (Orta)";
            this.btnKolaOrta.UseVisualStyleBackColor = false;
            this.btnKolaOrta.Click += new System.EventHandler(this.btnKolaOrta_Click);
            // 
            // btnPatatesOrta
            // 
            this.btnPatatesOrta.BackColor = System.Drawing.Color.Khaki;
            this.btnPatatesOrta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPatatesOrta.Location = new System.Drawing.Point(9, 200);
            this.btnPatatesOrta.Name = "btnPatatesOrta";
            this.btnPatatesOrta.Size = new System.Drawing.Size(141, 57);
            this.btnPatatesOrta.TabIndex = 17;
            this.btnPatatesOrta.Text = "Patetes (Orta)";
            this.btnPatatesOrta.UseVisualStyleBackColor = false;
            this.btnPatatesOrta.Click += new System.EventHandler(this.btnPatatesOrta_Click);
            // 
            // btnKolaKucuk
            // 
            this.btnKolaKucuk.BackColor = System.Drawing.Color.IndianRed;
            this.btnKolaKucuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKolaKucuk.Location = new System.Drawing.Point(156, 137);
            this.btnKolaKucuk.Name = "btnKolaKucuk";
            this.btnKolaKucuk.Size = new System.Drawing.Size(141, 57);
            this.btnKolaKucuk.TabIndex = 14;
            this.btnKolaKucuk.Text = "Kola (Kucuk)";
            this.btnKolaKucuk.UseVisualStyleBackColor = false;
            this.btnKolaKucuk.Click += new System.EventHandler(this.btnKolaKucuk_Click);
            // 
            // btnPatetesKucuk
            // 
            this.btnPatetesKucuk.BackColor = System.Drawing.Color.Khaki;
            this.btnPatetesKucuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPatetesKucuk.Location = new System.Drawing.Point(12, 137);
            this.btnPatetesKucuk.Name = "btnPatetesKucuk";
            this.btnPatetesKucuk.Size = new System.Drawing.Size(141, 57);
            this.btnPatetesKucuk.TabIndex = 15;
            this.btnPatetesKucuk.Text = "Patetes (Kucuk)";
            this.btnPatetesKucuk.UseVisualStyleBackColor = false;
            this.btnPatetesKucuk.Click += new System.EventHandler(this.btnPatetesKucuk_Click);
            // 
            // btnHamburger
            // 
            this.btnHamburger.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnHamburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHamburger.Location = new System.Drawing.Point(12, 74);
            this.btnHamburger.Name = "btnHamburger";
            this.btnHamburger.Size = new System.Drawing.Size(141, 57);
            this.btnHamburger.TabIndex = 11;
            this.btnHamburger.Text = "Hamburger";
            this.btnHamburger.UseVisualStyleBackColor = false;
            this.btnHamburger.Click += new System.EventHandler(this.btnHamburger_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 636);
            this.Controls.Add(this.btnSecileniSil);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblParaUstu);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFisYazdir);
            this.Controls.Add(this.btnMenu01);
            this.Controls.Add(this.btnHepsiniSil);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnCheeseBurger);
            this.Controls.Add(this.btnMenu02);
            this.Controls.Add(this.btnKolaBuyuk);
            this.Controls.Add(this.btnPatetesBuyuk);
            this.Controls.Add(this.btnKolaOrta);
            this.Controls.Add(this.btnPatatesOrta);
            this.Controls.Add(this.btnKolaKucuk);
            this.Controls.Add(this.btnPatetesKucuk);
            this.Controls.Add(this.btnHamburger);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSecileniSil;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblParaUstu;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFisYazdir;
        private System.Windows.Forms.Button btnMenu01;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnHepsiniSil;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnCheeseBurger;
        private System.Windows.Forms.Button btnMenu02;
        private System.Windows.Forms.Button btnKolaBuyuk;
        private System.Windows.Forms.Button btnPatetesBuyuk;
        private System.Windows.Forms.Button btnKolaOrta;
        private System.Windows.Forms.Button btnPatatesOrta;
        private System.Windows.Forms.Button btnKolaKucuk;
        private System.Windows.Forms.Button btnPatetesKucuk;
        private System.Windows.Forms.Button btnHamburger;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}