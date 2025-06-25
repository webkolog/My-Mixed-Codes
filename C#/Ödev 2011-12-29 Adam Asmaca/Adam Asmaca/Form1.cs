using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Adam_Asmaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int puan;
        byte tahminHata, tahminHataKapasite, boslukSayisi, kelimeSayisi;
        byte[] cikanKelimeler = new byte[0];
        string[] kelimeler = { "Portekiz", "ispanya", "ingiltere", "iskocya", "irlanda", "Galler", "Norvec", "isvec", "Finlandiya", "italya", "Fransa", "Almanya", "isvicre", "Hollanda", "Luksemburk", "Slovenya", "Hirvatistan", "Bosna Hersek", "Sirbistan", "Makedonya", "Arnavutluk", "Kosova", "Yunanistan", "Bulgaritan", "Romanya", "Ukrayna", "Moldova", "Letonya", "Litvanya", "Polonya", "Estonya", "Belarus", "Rusya", "cek Cumhuriyeti", "Slovakya", "Macaristan", "Azerbaycan", "Ermenistan", "Gurcistan", "Turkmenistan", "Kazakistan", "Pakistan", "Afganistan", "Hindistan", "Kirgizistan", "Tajikistan", "ozbekistan", "cin", "Guney Kore", "Japonya", "Mogolistan", "Tayland", "Tayvan", "Vietnam", "Laos", "Kambocya", "Banglades", "Peru", "Kolombiya", "Ekvador", "Brezilya", "Arjantin", "Venezuella", "sili", "Panama", "Kosta Rika", "Meksika", "Amerika", "iran", "irak", "Suriye", "urdun", "Lubnan", "israil", "Filistin", "Sudi Arabistan", "Uman", "Yemen", "Katar", "Libya", "Tunus", "Fas", "Misir", "Nijerya", "istanbul", "Ankara", "izmir", "Kayseri", "Kastamonu", "Kars", "Erzurum", "Elazig", "Bursa", "Hakkari", "Hatay", "Malatya", "Adana", "Trabzon", "Antalya", "Konya", "Kocaeli", "Nigde", "Van", "Zonguldak", "Rize", "canakkale", "Sakarya", "Paris", "Roma", "Monako", "Berlin", "Londra", "Madrid", "Saray Bosna", "Jakarta", "Bangkok", "Ho Chi Minh City", "Prag", "Kalem", "Dolap", "Apartman", "Araba", "Kamyon", "Sokak", "sehir", "Deniz", "Dunya", "corap", "Oturma Grubu", "Resim", "Sandalye", "Kagit", "Portakal", "Elma", "Armut", "Karpuz", "cilek", "Patlican", "Salatalik" };
        void gostergeGuncelle()
        {
            lblKelimeSayisi.Text = "Kelime: " + kelimeSayisi + "/10";
            lblHak.Text = "Hak: " + tahminHata + "/" + tahminHataKapasite;
            lblPuan.Text = "Puan: " + puan;
        }

        void oyunuKaybet()
        {
            this.flowLayoutPanel2.Controls.Clear();
            foreach (Control ct in this.flowLayoutPanel1.Controls)
            {
                if (ct is Button)
                {
                    Button btn = (Button)ct;
                    btn.Enabled = false;
                }
            }
            btnOyna.Enabled = true;
            btnYenile.Enabled = false;
            MessageBox.Show("Malesef Oyunu Kaybettiniz!\nPuanınız: " + puan + "\nBildiğiniz Kelime Sayısı: " + (kelimeSayisi - 1));
            puan = 0;
            kelimeSayisi = 0;
            tahminHata = 0;
            tahminHataKapasite = 0;
            gostergeGuncelle();
        }

        void oyunLevelAtla()
        {
            if (kelimeSayisi == 10)
            {
                MessageBox.Show("Tebrikler Oyunu Bitirdiniz!\nPuanınız: " + puan + "\nBildiğiniz Kelime Sayısı: " + (kelimeSayisi - 1));
            }
            else
            {
                kelimeSayisi += 1;
                tahminHata = 0;
                kelimeOlustur();
            }
        }

        void oyunuYenile()
        {
            btnOyna.Enabled = false;
            btnYenile.Enabled = true;
            puan = 0;
            kelimeSayisi = 1;
            gostergeGuncelle();
            kelimeOlustur();
        }

        void kelimeOlustur()
        {
            this.flowLayoutPanel2.Controls.Clear();
            byte karakter = Convert.ToByte(' ');
            boslukSayisi = 0;
            string kelime = kelimeler[rnd.Next(0, kelimeler.Length)];
            foreach (char klm in kelime)
            {
                Label lbl = new Label();
                if (klm == karakter)
                {
                    lbl.Text = " ";
                    boslukSayisi += 1;
                }
                else
                {
                    lbl.Text = "_";
                }
                lbl.Tag = klm.ToString();
                lbl.BackColor = Color.White;
                lbl.Width = 15;
                lbl.Height = 15;
                this.flowLayoutPanel2.Controls.Add(lbl);
            }
            if ((this.flowLayoutPanel2.Controls.Count - boslukSayisi) >= 6)
                tahminHataKapasite = 4;
            else
                tahminHataKapasite = 3;
            gostergeGuncelle();
            foreach (Button btn in this.flowLayoutPanel1.Controls)
            {
                btn.Enabled = true;
            }
        }

        void kelimeKontrol()
        {
            byte acikHarfSay = 0;
            foreach (Control ct in this.flowLayoutPanel2.Controls)
            {
                if (ct is Label)
                {
                    Label lbl = (Label)ct;
                    if (lbl.Text != "_")
                        acikHarfSay++;
                }
            }
            if ((this.flowLayoutPanel2.Controls.Count -boslukSayisi) == acikHarfSay)
            {
                if (tahminHata >= 2)
                {
                    puan += 5;
                }
                else
                {
                    puan += 10;
                }
                gostergeGuncelle();
                MessageBox.Show("Tebrikler, kelimeyi Buldunuz!");
                oyunLevelAtla();
            }
        }

        void hataYaptir()
        {
            tahminHata += 1;
            if (tahminHata == tahminHataKapasite)
                oyunuKaybet();
            gostergeGuncelle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (byte i = 65; i < 91; i++)
            {
                Button btn = new Button();
                btn.Enabled = false;
                btn.Text = Convert.ToChar(i).ToString();
                btn.Width = 50;
                btn.Height = 25;
                this.flowLayoutPanel1.Controls.Add(btn);
                btn.Click += new EventHandler(btn_Click);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            bool hata = true;
            Button bton = (Button)sender;
            string secilenHarf = bton.Text;
            foreach (Control kont in this.flowLayoutPanel2.Controls)
            {
                if (kont is Label)
                {
                    Label lbl = (Label)kont;
                    string harf = (string)lbl.Tag;
                    if (harf.Equals(secilenHarf, StringComparison.OrdinalIgnoreCase))
                    {
                        lbl.Text = secilenHarf;
                        hata = false;
                    }
                }
            }
            bton.Enabled = false;
            kelimeKontrol();
            if (hata)
                hataYaptir();
        }

        private void btnOyna_Click(object sender, EventArgs e)
        {
            oyunuYenile();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            oyunuYenile();
        }
    }
}
