namespace Görev_Zamanlayıcı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.windowsÇalıştığındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.başlangıçtaÇalıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışaBaşıldığındaKapansınToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSagTikMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.denemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dene2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSimSaat = new System.Windows.Forms.Label();
            this.lblSimTarih = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpKurTarih = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKurSaniye = new System.Windows.Forms.TextBox();
            this.txtKurDakika = new System.Windows.Forms.TextBox();
            this.txtKurSaat = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbSes = new System.Windows.Forms.CheckBox();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.rbIslem5 = new System.Windows.Forms.RadioButton();
            this.rbIslem4 = new System.Windows.Forms.RadioButton();
            this.rbIslem3 = new System.Windows.Forms.RadioButton();
            this.rbIslem2 = new System.Windows.Forms.RadioButton();
            this.rbIslem1 = new System.Windows.Forms.RadioButton();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.btnAyarla = new System.Windows.Forms.Button();
            this.niSagAltKose = new System.Windows.Forms.NotifyIcon(this.components);
            this.timSimZaman = new System.Windows.Forms.Timer(this.components);
            this.timZamanKontrol = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.cmsSagTikMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowsÇalıştığındaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(255, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // windowsÇalıştığındaToolStripMenuItem
            // 
            this.windowsÇalıştığındaToolStripMenuItem.Checked = true;
            this.windowsÇalıştığındaToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.windowsÇalıştığındaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.başlangıçtaÇalıştırToolStripMenuItem,
            this.çıkışaBaşıldığındaKapansınToolStripMenuItem});
            this.windowsÇalıştığındaToolStripMenuItem.Name = "windowsÇalıştığındaToolStripMenuItem";
            this.windowsÇalıştığındaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.windowsÇalıştığındaToolStripMenuItem.Text = "Ayarlar";
            // 
            // başlangıçtaÇalıştırToolStripMenuItem
            // 
            this.başlangıçtaÇalıştırToolStripMenuItem.Name = "başlangıçtaÇalıştırToolStripMenuItem";
            this.başlangıçtaÇalıştırToolStripMenuItem.Size = new System.Drawing.Size(337, 22);
            this.başlangıçtaÇalıştırToolStripMenuItem.Text = "Windows başlangıcında otomatik çalıştır";
            this.başlangıçtaÇalıştırToolStripMenuItem.Click += new System.EventHandler(this.başlangıçtaÇalıştırToolStripMenuItem_Click);
            // 
            // çıkışaBaşıldığındaKapansınToolStripMenuItem
            // 
            this.çıkışaBaşıldığındaKapansınToolStripMenuItem.Checked = true;
            this.çıkışaBaşıldığındaKapansınToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.çıkışaBaşıldığındaKapansınToolStripMenuItem.Name = "çıkışaBaşıldığındaKapansınToolStripMenuItem";
            this.çıkışaBaşıldığındaKapansınToolStripMenuItem.Size = new System.Drawing.Size(337, 22);
            this.çıkışaBaşıldığındaKapansınToolStripMenuItem.Text = "Kapatmaya basıldığında sistem çubuğunda küçült";
            this.çıkışaBaşıldığındaKapansınToolStripMenuItem.Click += new System.EventHandler(this.çıkışaBaşıldığındaKapansınToolStripMenuItem_Click);
            // 
            // cmsSagTikMenu
            // 
            this.cmsSagTikMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.denemeToolStripMenuItem,
            this.dene2ToolStripMenuItem});
            this.cmsSagTikMenu.Name = "cmsSagTikMenu";
            this.cmsSagTikMenu.Size = new System.Drawing.Size(161, 48);
            // 
            // denemeToolStripMenuItem
            // 
            this.denemeToolStripMenuItem.Name = "denemeToolStripMenuItem";
            this.denemeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.denemeToolStripMenuItem.Text = "Programı Göster";
            this.denemeToolStripMenuItem.Click += new System.EventHandler(this.denemeToolStripMenuItem_Click);
            // 
            // dene2ToolStripMenuItem
            // 
            this.dene2ToolStripMenuItem.Name = "dene2ToolStripMenuItem";
            this.dene2ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.dene2ToolStripMenuItem.Text = "Programdan Çık";
            this.dene2ToolStripMenuItem.Click += new System.EventHandler(this.dene2ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSimSaat);
            this.groupBox1.Controls.Add(this.lblSimTarih);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 83);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şuanki Tarih ve Saat";
            // 
            // lblSimSaat
            // 
            this.lblSimSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSimSaat.Location = new System.Drawing.Point(6, 40);
            this.lblSimSaat.Name = "lblSimSaat";
            this.lblSimSaat.Size = new System.Drawing.Size(218, 41);
            this.lblSimSaat.TabIndex = 1;
            this.lblSimSaat.Text = "00:00:00";
            this.lblSimSaat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSimTarih
            // 
            this.lblSimTarih.Location = new System.Drawing.Point(6, 16);
            this.lblSimTarih.Name = "lblSimTarih";
            this.lblSimTarih.Size = new System.Drawing.Size(218, 24);
            this.lblSimTarih.TabIndex = 0;
            this.lblSimTarih.Text = "00.00.0000";
            this.lblSimTarih.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpKurTarih);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtKurSaniye);
            this.groupBox2.Controls.Add(this.txtKurDakika);
            this.groupBox2.Controls.Add(this.txtKurSaat);
            this.groupBox2.Location = new System.Drawing.Point(12, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 79);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Görev Çalışma Zamanı";
            // 
            // dtpKurTarih
            // 
            this.dtpKurTarih.Location = new System.Drawing.Point(6, 19);
            this.dtpKurTarih.Name = "dtpKurTarih";
            this.dtpKurTarih.Size = new System.Drawing.Size(218, 20);
            this.dtpKurTarih.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = ":";
            // 
            // txtKurSaniye
            // 
            this.txtKurSaniye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKurSaniye.Location = new System.Drawing.Point(149, 47);
            this.txtKurSaniye.Name = "txtKurSaniye";
            this.txtKurSaniye.Size = new System.Drawing.Size(24, 20);
            this.txtKurSaniye.TabIndex = 2;
            this.txtKurSaniye.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKurDakika
            // 
            this.txtKurDakika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKurDakika.Location = new System.Drawing.Point(102, 47);
            this.txtKurDakika.Name = "txtKurDakika";
            this.txtKurDakika.Size = new System.Drawing.Size(24, 20);
            this.txtKurDakika.TabIndex = 2;
            this.txtKurDakika.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKurSaat
            // 
            this.txtKurSaat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKurSaat.Location = new System.Drawing.Point(53, 47);
            this.txtKurSaat.Name = "txtKurSaat";
            this.txtKurSaat.Size = new System.Drawing.Size(24, 20);
            this.txtKurSaat.TabIndex = 2;
            this.txtKurSaat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbSes);
            this.groupBox3.Controls.Add(this.txtMesaj);
            this.groupBox3.Controls.Add(this.rbIslem5);
            this.groupBox3.Controls.Add(this.rbIslem4);
            this.groupBox3.Controls.Add(this.rbIslem3);
            this.groupBox3.Controls.Add(this.rbIslem2);
            this.groupBox3.Controls.Add(this.rbIslem1);
            this.groupBox3.Location = new System.Drawing.Point(12, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 115);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İşlemler";
            // 
            // cbSes
            // 
            this.cbSes.AutoSize = true;
            this.cbSes.Location = new System.Drawing.Point(9, 90);
            this.cbSes.Name = "cbSes";
            this.cbSes.Size = new System.Drawing.Size(62, 17);
            this.cbSes.TabIndex = 6;
            this.cbSes.Text = "Ses Çal";
            this.cbSes.UseVisualStyleBackColor = true;
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(77, 64);
            this.txtMesaj.Multiline = true;
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(147, 43);
            this.txtMesaj.TabIndex = 5;
            // 
            // rbIslem5
            // 
            this.rbIslem5.AutoSize = true;
            this.rbIslem5.Location = new System.Drawing.Point(112, 44);
            this.rbIslem5.Name = "rbIslem5";
            this.rbIslem5.Size = new System.Drawing.Size(94, 17);
            this.rbIslem5.TabIndex = 4;
            this.rbIslem5.TabStop = true;
            this.rbIslem5.Text = "Hazırda Beklet";
            this.rbIslem5.UseVisualStyleBackColor = true;
            this.rbIslem5.Click += new System.EventHandler(this.rbIslem3_Click);
            // 
            // rbIslem4
            // 
            this.rbIslem4.AutoSize = true;
            this.rbIslem4.Location = new System.Drawing.Point(112, 20);
            this.rbIslem4.Name = "rbIslem4";
            this.rbIslem4.Size = new System.Drawing.Size(96, 17);
            this.rbIslem4.TabIndex = 3;
            this.rbIslem4.TabStop = true;
            this.rbIslem4.Text = "Yeniden Başlat";
            this.rbIslem4.UseVisualStyleBackColor = true;
            this.rbIslem4.Click += new System.EventHandler(this.rbIslem3_Click);
            // 
            // rbIslem3
            // 
            this.rbIslem3.AutoSize = true;
            this.rbIslem3.Location = new System.Drawing.Point(9, 67);
            this.rbIslem3.Name = "rbIslem3";
            this.rbIslem3.Size = new System.Drawing.Size(66, 17);
            this.rbIslem3.TabIndex = 2;
            this.rbIslem3.TabStop = true;
            this.rbIslem3.Text = "Mesaj At";
            this.rbIslem3.UseVisualStyleBackColor = true;
            this.rbIslem3.Click += new System.EventHandler(this.rbIslem3_Click);
            // 
            // rbIslem2
            // 
            this.rbIslem2.AutoSize = true;
            this.rbIslem2.Location = new System.Drawing.Point(9, 44);
            this.rbIslem2.Name = "rbIslem2";
            this.rbIslem2.Size = new System.Drawing.Size(53, 17);
            this.rbIslem2.TabIndex = 1;
            this.rbIslem2.TabStop = true;
            this.rbIslem2.Text = "Kapat";
            this.rbIslem2.UseVisualStyleBackColor = true;
            this.rbIslem2.Click += new System.EventHandler(this.rbIslem3_Click);
            // 
            // rbIslem1
            // 
            this.rbIslem1.AutoSize = true;
            this.rbIslem1.Location = new System.Drawing.Point(9, 20);
            this.rbIslem1.Name = "rbIslem1";
            this.rbIslem1.Size = new System.Drawing.Size(96, 17);
            this.rbIslem1.TabIndex = 0;
            this.rbIslem1.TabStop = true;
            this.rbIslem1.Text = "Oturumu Kapat";
            this.rbIslem1.UseVisualStyleBackColor = true;
            this.rbIslem1.Click += new System.EventHandler(this.rbIslem3_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDurdur.Enabled = false;
            this.btnDurdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDurdur.Location = new System.Drawing.Point(12, 322);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(96, 36);
            this.btnDurdur.TabIndex = 4;
            this.btnDurdur.Text = "Durdur";
            this.btnDurdur.UseVisualStyleBackColor = false;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // btnAyarla
            // 
            this.btnAyarla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAyarla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAyarla.Location = new System.Drawing.Point(114, 322);
            this.btnAyarla.Name = "btnAyarla";
            this.btnAyarla.Size = new System.Drawing.Size(128, 36);
            this.btnAyarla.TabIndex = 5;
            this.btnAyarla.Text = "Ayarla";
            this.btnAyarla.UseVisualStyleBackColor = false;
            this.btnAyarla.Click += new System.EventHandler(this.btnAyarla_Click);
            // 
            // niSagAltKose
            // 
            this.niSagAltKose.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.niSagAltKose.ContextMenuStrip = this.cmsSagTikMenu;
            this.niSagAltKose.Icon = ((System.Drawing.Icon)(resources.GetObject("niSagAltKose.Icon")));
            this.niSagAltKose.Text = "Görev Zamanlayıcı 1.0";
            this.niSagAltKose.Visible = true;
            this.niSagAltKose.BalloonTipClicked += new System.EventHandler(this.niSagAltKose_BalloonTipClicked);
            this.niSagAltKose.DoubleClick += new System.EventHandler(this.niSagAltKose_DoubleClick);
            this.niSagAltKose.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.niSagAltKose_MouseDoubleClick);
            // 
            // timSimZaman
            // 
            this.timSimZaman.Enabled = true;
            this.timSimZaman.Interval = 1000;
            this.timSimZaman.Tick += new System.EventHandler(this.timSimZaman_Tick);
            // 
            // timZamanKontrol
            // 
            this.timZamanKontrol.Interval = 1000;
            this.timZamanKontrol.Tick += new System.EventHandler(this.timZamanKontrol_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(255, 369);
            this.Controls.Add(this.btnAyarla);
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Görev Zamanlayıcı 1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Move += new System.EventHandler(this.Form1_Move);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cmsSagTikMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem windowsÇalıştığındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem başlangıçtaÇalıştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışaBaşıldığındaKapansınToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSimSaat;
        private System.Windows.Forms.Label lblSimTarih;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtKurSaniye;
        private System.Windows.Forms.TextBox txtKurDakika;
        private System.Windows.Forms.TextBox txtKurSaat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbSes;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.RadioButton rbIslem5;
        private System.Windows.Forms.RadioButton rbIslem4;
        private System.Windows.Forms.RadioButton rbIslem3;
        private System.Windows.Forms.RadioButton rbIslem2;
        private System.Windows.Forms.RadioButton rbIslem1;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Button btnAyarla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpKurTarih;
        private System.Windows.Forms.ContextMenuStrip cmsSagTikMenu;
        public System.Windows.Forms.NotifyIcon niSagAltKose;
        private System.Windows.Forms.ToolStripMenuItem denemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dene2ToolStripMenuItem;
        private System.Windows.Forms.Timer timSimZaman;
        private System.Windows.Forms.Timer timZamanKontrol;
    }
}

