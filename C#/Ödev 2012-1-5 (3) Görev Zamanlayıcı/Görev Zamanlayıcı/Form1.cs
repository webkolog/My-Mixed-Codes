using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;
using Microsoft.Win32;

namespace Görev_Zamanlayıcı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string uygulama_adi = "Görev Zamanlayıcı 1.0";
        RadioButton[] rbIslemler = new RadioButton[5];
        bool sisAktif = false, sesSec;
        string islemStr, islemMesaj;
        DateTime islemTarih;

        private void RunStartup(bool RunOnStartup)
        {
            string path = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
            RegistryKey key = Registry.CurrentUser.OpenSubKey(path, true);
            if (RunOnStartup == true)
            {
                key.SetValue(uygulama_adi, Application.ExecutablePath.ToString());
            }
            else
            {
                key.DeleteValue(uygulama_adi, false);
            }
            key.Close();
        }

        private void ayarlariCek()
        {
            string[] okunanveri = new string[6];
            try
            {
                okunanveri = File.ReadAllText("c:\\ayarlar.txt").Split(';');
                bool kurulum;
                başlangıçtaÇalıştırToolStripMenuItem.Checked = Convert.ToBoolean(okunanveri[0]);
                RunStartup(başlangıçtaÇalıştırToolStripMenuItem.Checked);
                çıkışaBaşıldığındaKapansınToolStripMenuItem.Checked = Convert.ToBoolean(okunanveri[1]);
                islemTarih = Convert.ToDateTime(okunanveri[2]);
                islemStr = okunanveri[3];
                sesSec = Convert.ToBoolean(okunanveri[4]);
                islemMesaj = okunanveri[5];
                kurulum = Convert.ToBoolean(okunanveri[6]);
                dtpKurTarih.Value = Convert.ToDateTime(islemTarih);
                txtKurSaat.Text = islemTarih.Hour.ToString();
                txtKurDakika.Text = islemTarih.Minute.ToString();
                txtKurSaniye.Text = islemTarih.Second.ToString();
                foreach (Control ct in this.groupBox3.Controls)
                {
                    if (ct is RadioButton)
                    {
                        RadioButton rb = ct as RadioButton;
                        if (rb.Text == islemStr)
                            rb.Checked = true;
                    }
                }
                if (sesSec)
                    cbSes.Checked = true;
                txtMesaj.Text = islemMesaj.Replace("\\n", "\n");
                if (kurulum)
                {
                    this.BackColor = btnAyarla.BackColor;
                    btnDurdur.Enabled = true;
                    btnAyarla.Enabled = false;
                    sisAktif = true;
                    timZamanKontrol.Start();
                }
                else
                {
                    this.BackColor = btnDurdur.BackColor;
                    btnDurdur.Enabled = false;
                    btnAyarla.Enabled = true;
                    sisAktif = false;
                    timZamanKontrol.Stop();
                }
            }
            catch
            {
                //islem yok
            }
        }

        void ayarlari_olustur(bool kurulum)
        {
            bool hata = false;
            int intSaat = 0, intDak = 0, intSan = 0;
            if (kurulum)
            {
                try
                {
                    intSaat = Convert.ToByte(txtKurSaat.Text);
                    intDak = Convert.ToByte(txtKurDakika.Text);
                    intSan = Convert.ToByte(txtKurSaniye.Text);
                }
                catch
                {
                    MessageBox.Show("Lütfen Saat, Dakika ve Saniye kutularına sayı değeri giriniz!");
                    hata = true;
                }
                if (intSaat < 0 | intSaat > 23)
                {
                    MessageBox.Show("Saat kutusuna 0 ile 23 arasında değer girebilirsiniz!");
                    hata = true;
                }
                if (intDak < 0 | intDak > 59)
                {
                    MessageBox.Show("Dakika kutusuna 0 ile 59 arasında değer girebilirsiniz!");
                    hata = true;
                }
                if (intSan < 0 | intSan > 59)
                {
                    MessageBox.Show("Saniye kutusuna 0 ile 59 arasında değer girebilirsiniz!");
                    hata = true;
                }
                DateTime islemTarih = new DateTime(dtpKurTarih.Value.Year, dtpKurTarih.Value.Month, dtpKurTarih.Value.Day, intSaat, intDak, intSan);
                if (islemTarih < DateTime.Now)
                {
                    MessageBox.Show("Geçmiş bir tarihe işlem yapamazsınız!");
                    hata = true;
                }
                islemStr = "";
                foreach (Control ct in this.groupBox3.Controls)
                {
                    if (ct is RadioButton)
                    {
                        RadioButton rb = ct as RadioButton;
                        if (rb.Checked)
                        {
                            islemStr = rb.Text;
                        }
                    }
                }
                if (islemStr == "")
                {
                    MessageBox.Show("Hiç işlem seçmediniz!");
                    hata = true;
                }

            }
            if (!hata)
            {
                ayarlari_guncelle(kurulum);
                if (kurulum)
                {
                    this.BackColor = btnAyarla.BackColor;
                    btnDurdur.Enabled = true;
                    btnAyarla.Enabled = false;
                    sisAktif = true;
                    timZamanKontrol.Start();
                }
                else
                {
                    this.BackColor = btnDurdur.BackColor;
                    btnDurdur.Enabled = false;
                    btnAyarla.Enabled = true;
                    sisAktif = false;
                    timZamanKontrol.Stop();
                }
            }
            ayarlariCek();
        }

        void ayarlari_guncelle(bool kurulum)
        {
            File.WriteAllText("c:\\ayarlar.txt", başlangıçtaÇalıştırToolStripMenuItem.Checked + ";" + çıkışaBaşıldığındaKapansınToolStripMenuItem.Checked + ";" + dtpKurTarih.Value.ToString("dd.MM.yyyy") + " " + txtKurSaat.Text + ":" + txtKurDakika.Text + ":" + txtKurSaniye.Text + ";" + islemStr + ";" + cbSes.Checked + ";" + txtMesaj.Text.Replace("\n", "\\n").Replace(";","") + ";" + kurulum);
            RunStartup(başlangıçtaÇalıştırToolStripMenuItem.Checked);
        }

        void islem_gerceklestir()
        {
            if (sesSec)
            {
                SoundPlayer player = new SoundPlayer();
                string path = "C:\\windows\\media\\tada.wav";
                player.SoundLocation = path;
                player.Play();
            }
            switch (islemStr)
            {
                case "Oturumu Kapat":
                    System.Diagnostics.Process.Start("shutdown", "-l -f");
                    break;
                case "Kapat":
                    System.Diagnostics.Process.Start("shutdown", "-s -f");
                    break;
                case "Mesaj At":
                    MessageBox.Show(islemMesaj, "Mesaj:");
                    break;
                case "Yeniden Başlat":
                    System.Diagnostics.Process.Start("shutdown", "-r -f");
                    break;
                case "Hazırda Beklet":
                    System.Diagnostics.Process.Start("shutdown", "-h -f");
                    break;
            }
        }

        private void başlangıçtaÇalıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (başlangıçtaÇalıştırToolStripMenuItem.Checked)
            {
                başlangıçtaÇalıştırToolStripMenuItem.Checked = false;
            }
            else
            {
                başlangıçtaÇalıştırToolStripMenuItem.Checked = true;
            }
            ayarlari_guncelle(sisAktif);
        }

        private void çıkışaBaşıldığındaKapansınToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (çıkışaBaşıldığındaKapansınToolStripMenuItem.Checked)
            {
                çıkışaBaşıldığındaKapansınToolStripMenuItem.Checked = false;
            }
            else
            {
                çıkışaBaşıldığındaKapansınToolStripMenuItem.Checked = true;
            }
            ayarlari_guncelle(sisAktif);
        }

        private void rbIslem3_Click(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (çıkışaBaşıldığındaKapansınToolStripMenuItem.Checked)
            {
                this.Visible = false;
                e.Cancel = true;
            }
        }

        private void dene2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            çıkışaBaşıldığındaKapansınToolStripMenuItem.Checked = false;
            Application.Exit();
        }

        private void denemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void btnAyarla_Click(object sender, EventArgs e)
        {
            ayarlari_olustur(true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbIslemler[0] = rbIslem1;
            rbIslemler[1] = rbIslem2;
            rbIslemler[2] = rbIslem3;
            rbIslemler[3] = rbIslem4;
            rbIslemler[4] = rbIslem5;
            niSagAltKose.ShowBalloonTip(1, uygulama_adi, "Ayarlar kontrol ediliyor", System.Windows.Forms.ToolTipIcon.Info);
            ayarlariCek();
        }

        private void niSagAltKose_BalloonTipClicked(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            ayarlari_olustur(false);
        }

        private void timSimZaman_Tick(object sender, EventArgs e)
        {
            lblSimTarih.Text = DateTime.Now.Date.ToString("dd.MM.yyyy");
            lblSimSaat.Text = DateTime.Now.ToString("T");
        }

        private void timZamanKontrol_Tick(object sender, EventArgs e)
        {
            DateTime simdi = DateTime.Now;
            if (simdi.ToString() == islemTarih.ToString("dd.MM.yyyy HH:mm:ss"))
            {
                islem_gerceklestir();
            }
        }

        private void niSagAltKose_DoubleClick(object sender, EventArgs e)
        {

        }

        private void Form1_Move(object sender, EventArgs e)
        {
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void niSagAltKose_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Visible)
                this.Visible = false;
            else
                this.Visible = true;
        }
    }
}
