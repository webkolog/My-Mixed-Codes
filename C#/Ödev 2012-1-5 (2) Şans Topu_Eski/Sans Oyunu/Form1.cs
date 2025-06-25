using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Sans_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        TextBox[] txtKolonlar = new TextBox[6];
        private void btnKolonEkle_Click(object sender, EventArgs e)
        {
            byte[] kolonSayilar = new byte[6];
            try
            {
                bool hata = false;
                for (int i = 0; i < 5; i++)
                {
                    kolonSayilar[i] = Convert.ToByte(txtKolonlar[i].Text);
                }
                for (int i = 0; i < 5; i++)
                {
                    if (i < 5)
                    {
                        if (kolonSayilar[i] < 1 | kolonSayilar[i] > 34)
                        {
                            MessageBox.Show(i + ". kutuya 1 ile 34 arasında sayı girebilirsiniz!");
                            hata = true;
                        }
                        for (int a = 0; a < 5; a++)
                        {
                            if (i > a)
                            {
                                if (kolonSayilar[i] == kolonSayilar[a])
                                {
                                    MessageBox.Show((a + 1) + ". ve " + (i + 1) + ". kutudaki sayılar aynı!");
                                    hata = true;
                                }
                            }
                        }
                    }
                }
                byte artiSayi = 0;
                artiSayi = Convert.ToByte(txtKolon6.Text);
                if (artiSayi < 1 | artiSayi > 14)
                {
                    MessageBox.Show(" + sayı 1 ile 14 arasında olmalı!");
                    hata = true;
                }
                if (!hata)
                {
                    lisOynanan.Items.Add(kolonSayilar[0] + "-" + kolonSayilar[1] + "-" + kolonSayilar[2] + "-" + kolonSayilar[3] + "-" + kolonSayilar[4] + "+" + artiSayi);
                    foreach (TextBox tb in txtKolonlar)
                    {
                        tb.Clear();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lütfen sayı giriniz!");
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lisOynanan.Items.Clear();
        }

        private void btnOtoOyna_Click(object sender, EventArgs e)
        {
            lblSonuclar.Text = "";
            lblTutunlar.Text = "";
            byte[] kolonSayilar = new byte[5];
            byte rasSayi = 0, artiSayi = 0;
            for (int i = 1; i <= 5; i++)
            {
                for (int a = 0; a < 5; a++)
                {
                    rasSayi = Convert.ToByte(rnd.Next(1, 35));

                    if (!kolonSayilar.Contains(rasSayi))
                    {
                        kolonSayilar[a] = rasSayi;
                    }
                    else
                    {
                        a--;
                        continue;
                    }

                }
                Array.Sort(kolonSayilar);
                artiSayi = Convert.ToByte(rnd.Next(1, 15));
                lisOynanan.Items.Add(kolonSayilar[0] + "-" + kolonSayilar[1] + "-" + kolonSayilar[2] + "-" + kolonSayilar[3] + "-" + kolonSayilar[4] + "+" + artiSayi);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtKolonlar[0] = txtKolon1;
            txtKolonlar[1] = txtKolon2;
            txtKolonlar[2] = txtKolon3;
            txtKolonlar[3] = txtKolon4;
            txtKolonlar[4] = txtKolon5;
            txtKolonlar[5] = txtKolon6;
        }

        private void btnCekilisYap_Click(object sender, EventArgs e)
        {
            byte[] kolonSayilar = new byte[5];
            byte rasSayi = 0, artiSayi = 0;
            for (int a = 0; a < 5; a++)
            {
                rasSayi = Convert.ToByte(rnd.Next(1, 35));
                if (!kolonSayilar.Contains(rasSayi))
                {
                    kolonSayilar[a] = rasSayi;
                }
                else
                {
                    a--;
                    continue;
                }
            }
            Array.Sort(kolonSayilar);
            artiSayi = Convert.ToByte(rnd.Next(1, 15));
            lblSonuclar.Text = (kolonSayilar[0] + "-" + kolonSayilar[1] + "-" + kolonSayilar[2] + "-" + kolonSayilar[3] + "-" + kolonSayilar[4] + "+" + artiSayi);
            byte tutBirArtiBir = 0, tutIkiArtiBir = 0, tutUc = 0, tutUcArtiBir = 0, tutDort = 0, tutDortArtiBir = 0, tutBes = 0, tutBesArtiBir = 0;
            lblTutunlar.Text = "";
            string[] kontrolDiziSonuclar = lblSonuclar.Text.Split('+')[0].Split('-');
            for (int i = 0; i < lisOynanan.Items.Count; i++)
            {
                string[] bol = (lisOynanan.Items[i] as string).Split('-', '+');
                byte aynilariTopla = 0, aynilariToplaArti = 0;
                for (int a = 0; a < bol.Length; a++)
                {
                    if (bol.Length == (a + 1))
                    {
                        if (lblSonuclar.Text.Split('+')[1] == bol[a])
                            aynilariToplaArti += 1;
                    }
                    else
                    {
                        if (kontrolDiziSonuclar.Contains(bol[a]))
                            aynilariTopla += 1;
                    }
                }
                switch (aynilariTopla)
                {
                    case 1:
                        if (aynilariToplaArti == 1)
                            tutBirArtiBir += 1;
                        break;
                    case 2:
                        if (aynilariToplaArti == 1)
                            tutIkiArtiBir += 1;
                        break;
                    case 3:
                        if (aynilariToplaArti == 1)
                            tutUcArtiBir += 1;
                        else
                            tutUc += 1;
                        break;
                    case 4:
                        if (aynilariToplaArti == 1)
                            tutDortArtiBir += 1;
                        else
                            tutDort += 1;
                        break;
                    case 5:
                        if (aynilariToplaArti == 1)
                            tutBesArtiBir += 1;
                        else
                            tutBes += 1;
                        break;
                }
            }
            lblTutunlar.Text = tutBirArtiBir + " tane 1+1 bildiniz\n" + tutIkiArtiBir + " tane 2+1 bildiniz\n" + tutUc + " tane 3 bildiniz\n" + tutUcArtiBir + " tane 3+1 bildiniz\n" + tutDort + " tane 4 bildiniz\n" + tutDortArtiBir + " tane 4+1 bildiniz\n" + tutBes + " tane 5 bildiniz\n" + tutBesArtiBir + " tane 5+1 bildiniz";
        }
    }
}
