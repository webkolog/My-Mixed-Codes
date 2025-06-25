using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Slot_Oyunu_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasa;
        PictureBox[] Resimler = new PictureBox[3];
        byte[] Sayilar = new byte[3];
        Random rnd = new Random();
        void kasa_guncelle(int para, bool toplama)
        {
            if (toplama)
            {
                kasa += para;
            }
            else
            {
                kasa -= para;
            }
            lblKasa.Text = kasa + " TL";
        }
        private void btnOyna_Click(object sender, EventArgs e)
        {
            if (btnOyna.Text == "BAŞLAT")
            {
                kasa_guncelle(5, false);
                btnOyna.Text = "BİTİR";
                timer1.Start();
            }
            else
            {
                btnOyna.Text = "BAŞLAT";
                timer1.Stop();
                if (kasa < 5)
                {
                    btnOyna.Enabled = false;
                    btnKrediAl.Enabled = true;
                }
                if (Sayilar[0] == Sayilar[1] & Sayilar[0] == Sayilar[2])
                {
                    kasa_guncelle(500, true);
                    MessageBox.Show("Tebrikler, 500 TL kazandınız!");
                }
            }
        }

        private void btnKrediAl_Click(object sender, EventArgs e)
        {
            bool hata_oldumu = false;
            int gelenKredi = 0;
            try
            {
                gelenKredi = Convert.ToInt32(txtKredi.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Hata: Lütfen kredi olarak sayı giriniz!");
                hata_oldumu = true;
            }
            if (!hata_oldumu)
            {
                if (gelenKredi >= 1 & gelenKredi <= 300)
                {
                    kasa_guncelle(gelenKredi, true);
                    if (kasa >= 5)
                    {
                        btnOyna.Enabled = true;
                        btnKrediAl.Enabled = false;
                        txtKredi.Text = "0";
                    }
                }
                else
                {
                    MessageBox.Show("Hata: Lütfen kredi olarak 1-300 TL arası ücret giriniz!");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Resimler[0] = picBox1;
            Resimler[1] = picBox2;
            Resimler[2] = picBox3;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (byte i = 0; i < 3; i++)
            {
                Sayilar[i] = Convert.ToByte(rnd.Next(1, 10));
                Resimler[i].Image = Image.FromFile("img/" + Sayilar[i] + ".png");
            }
        }

        private void txtKredi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKredi_MouseClick(object sender, MouseEventArgs e)
        {
            txtKredi.Text = "";
        }
    }
}
