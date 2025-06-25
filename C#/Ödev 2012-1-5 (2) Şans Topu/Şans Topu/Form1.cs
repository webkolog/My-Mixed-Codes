using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Şans_Topu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        int[] RastgeleSayilarDizisi()
        {
            int[] sayilar = new int[6];
            for (byte i = 0; i < sayilar.Length; i++)
            {
                if (i == (sayilar.Length - 1))
                {
                    sayilar[i] = rnd.Next(1, 15);
                }
                else
                {
                    int rasSayi = rnd.Next(1, 35);
                    if (sayilar.Contains(rasSayi))
                    {
                        i--;
                        continue;
                    }
                    else
                    {
                        sayilar[i] = rasSayi;
                    }
                }
            }
            Array.Sort(sayilar, 0, 5);
            return sayilar;
        }

        string listeyeKolonOlustur(int[] dizi)
        {
            string sayilariTopla = null;
            for (byte a = 0; a < dizi.Length; a++)
            {
                if (a == (dizi.Length - 1))
                {
                    sayilariTopla += "+" + dizi[a];
                }
                else
                {
                    if (sayilariTopla == null)
                    {
                        sayilariTopla = dizi[a].ToString();
                    }
                    else
                    {
                        sayilariTopla += "-" + dizi[a];
                    }
                }
            }
            return sayilariTopla;
        }

        private void btnOtoOyna_Click(object sender, EventArgs e)
        {
            for (byte i = 1; i <= 5; i++)
            {
                string eklenecekSayilar = listeyeKolonOlustur(RastgeleSayilarDizisi());
                lisOynanan.Items.Add(eklenecekSayilar);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lisOynanan.Items.Clear();
        }


        private void btnKolonEkle_Click(object sender, EventArgs e)
        {
            byte sayac = 0;
            int[] txtdenSayilar = new int[6];
            try
            {
                foreach (Control ct in this.grpKolonOyna.Controls)
                {
                    if (ct is TextBox)
                    {
                        TextBox tb = ct as TextBox;
                        txtdenSayilar[sayac] = Convert.ToInt32(tb.Text);
                        sayac++;
                    }
                }
                for (byte i = 0; i < (txtdenSayilar.Length - 1); i++)
                {
                    if (txtdenSayilar[i] < 1 | txtdenSayilar[i] > 34)
                    {
                        MessageBox.Show((i + 1) + ". kutudaki sayı 1 ile 34 arasında olmalı!");
                        return;
                    }
                    for (byte a = 0; a < (txtdenSayilar.Length - 1); a++)
                    {
                        if (i < a & txtdenSayilar[i] == txtdenSayilar[a])
                        {
                            MessageBox.Show((i + 1) + ". ve " + (a + 1) + ". kutudaki sayılar aynı!");
                            return;
                        }

                    }
                }
                if (txtdenSayilar[5] < 1 | txtdenSayilar[5] > 14)
                {
                    MessageBox.Show("Artı sayı 1 ile 14 arasında olmalı!");
                    return;
                }
                Array.Sort(txtdenSayilar, 0, 5);
                string eklenecekSayilar = listeyeKolonOlustur(txtdenSayilar);
                lisOynanan.Items.Add(eklenecekSayilar);
                foreach (Control ct in this.grpKolonOyna.Controls)
                {
                    if (ct is TextBox)
                    {
                        TextBox tb = ct as TextBox;
                        tb.Clear();
                        sayac++;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lütfen sayı giriniz!");
            }
        }

        private void btnCekilisYap_Click(object sender, EventArgs e)
        {
            string eklenecekSayilar = listeyeKolonOlustur(RastgeleSayilarDizisi());
            lblSonuclar.Text = eklenecekSayilar;
            byte tutBirArtiBir = 0, tutIkiArtiBir = 0, tutUc = 0, tutUcArtiBir = 0, tutDort = 0, tutDortArtiBir = 0, tutBes = 0, tutBesArtiBir = 0;
            lblTutunlar.Text = "";
            string[] kontrolDiziSonuclar = eklenecekSayilar.Split('+')[0].Split('-');
            for (int i = 0; i < lisOynanan.Items.Count; i++)
            {
                string[] bol = (lisOynanan.Items[i] as string).Split('-', '+');
                byte aynilariTopla = 0, aynilariToplaArti = 0;
                for (int a = 0; a < bol.Length; a++)
                {
                    if (bol.Length == (a + 1))
                    {
                        if (eklenecekSayilar.Split('+')[1] == bol[a])
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
