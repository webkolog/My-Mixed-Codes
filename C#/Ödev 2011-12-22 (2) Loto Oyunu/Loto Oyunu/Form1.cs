using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Loto_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        byte[] sayilar = new byte[6];
        byte[] CikanSayilar = new byte[6];
        TextBox[] txtSayilar = new TextBox[6];
        Label[] lblSayilar = new Label[6];
        byte tutturma;
        bool kontrol()
        {
            bool hata = false;
            try
            {
                for (byte i = 0; i < txtSayilar.Length; i++)
                    sayilar[i] = Convert.ToByte(txtSayilar[i].Text);

            }
            catch (FormatException)
            {
                MessageBox.Show("Hata: Lütfen sayı giriniz!");
                hata = true;
            }
            /*
            catch (OverflowException) {
            MessageBox.Show("Hata: Fazla değer girdiniz!");
            }
             */
            for (byte i = 0; i < 6; i++)
            {
                if (sayilar[i] < 1 | sayilar[i] > 49)
                {
                    MessageBox.Show("Hata: Lütfen " + (i + 1) + ". kutuya 1 ile 49 arasında sayılar giriniz!");
                    hata = true;
                    break;
                }
                for (byte a = 0; a < 6; a++)
                {
                    if (i > a)
                    {
                        if (sayilar[i] == sayilar[a])
                        {
                            MessageBox.Show("Hata: " + (a + 1) + ". kutudaki sayı ve " + (i + 1) + ". kutudaki sayı aynı!");
                            hata = true;
                            break;
                        }
                    }
                }
            }
            return hata;
        }
        byte[] RasgteleSayilar()
        {
            byte rasSayi = 0;
            byte[] dizi = new byte[6];
            for (byte i = 0; i < 6; i++)
            {
                rasSayi = (byte)rnd.Next(1, 50);
                if (dizi.Contains(rasSayi))
                {
                    i--;
                    continue;
                }
                dizi[i] = rasSayi;
            }
            Array.Sort(dizi);
            return dizi;
        }
        bool txtKontrol()
        {
            bool bosmu = false;
            for (byte i = 0; i < txtSayilar.Length; i++)
            {
                if (txtSayilar[i].Text == "")
                {
                    bosmu = true;
                    break;
                }
            }
            return bosmu;
        }
        private void btnMakOynat_Click(object sender, EventArgs e)
        {
            btnHafCekilisi.Enabled = true;
                sayilar = RasgteleSayilar();
                for (byte i = 0; i < txtSayilar.Length; i++)
                    txtSayilar[i].Text = sayilar[i].ToString();
        }
        private void btnHafCekilisi_Click(object sender, EventArgs e)
        {
            bool hata = kontrol();
            if (!hata)
            {
                CikanSayilar = RasgteleSayilar();
                for (byte i = 0; i < lblSayilar.Length; i++)
                    lblSayilar[i].Text = CikanSayilar[i].ToString();
                btnKacTaneTuttu.Enabled = true;
                btnMakOynat.Enabled = false;
            }
        }

        private void btnKacTaneTuttu_Click(object sender, EventArgs e)
        {
            bool hata = kontrol();
            if (!hata)
            {
                btnKacTaneTuttu.Enabled = false;
                tutturma = 0;
                for (byte i = 0; i < 6; i++)
                {
                    if (CikanSayilar.Contains(sayilar[i]))
                    {
                        tutturma++;
                    }
                }
                if (tutturma > 0)
                    MessageBox.Show(tutturma + " tane sayı tutturdun!");
                else
                    MessageBox.Show("Malesef hiç sayı tutturamadınız!");
                for (byte i = 0; i < txtSayilar.Length; i++)
                {
                    txtSayilar[i].Text = "";
                    lblSayilar[i].Text = "";
                    //sayilar[i] = 0;
                    //CikanSayilar[i] = 0;
                }
                btnHafCekilisi.Enabled = false;
                btnMakOynat.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSayilar[0] = txtSayi1;
            txtSayilar[1] = txtSayi2;
            txtSayilar[2] = txtSayi3;
            txtSayilar[3] = txtSayi4;
            txtSayilar[4] = txtSayi5;
            txtSayilar[5] = txtSayi6;
            lblSayilar[0] = lblSayi1;
            lblSayilar[1] = lblSayi2;
            lblSayilar[2] = lblSayi3;
            lblSayilar[3] = lblSayi4;
            lblSayilar[4] = lblSayi5;
            lblSayilar[5] = lblSayi6;
        }

        private void txtSayi6_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtSayi6_KeyUp(object sender, KeyEventArgs e)
        {
            bool hata = txtKontrol();
            if (!hata)
            {
                btnHafCekilisi.Enabled = true;
            }
            else
            {
                btnHafCekilisi.Enabled = false;
            }
        }
    }
}
