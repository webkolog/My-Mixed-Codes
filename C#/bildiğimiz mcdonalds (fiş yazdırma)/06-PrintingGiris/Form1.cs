using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _06_PrintingGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UrunEkle(string UrunAdi, string Fiyat)
        {
            ListViewItem li = null;
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[1].Text == UrunAdi)
                {
                    li = item;
                    break;
                }
            }

            if (li == null)
            {
                li = new ListViewItem();
                li.Text = (listView1.Items.Count + 1).ToString();
                li.SubItems.Add(UrunAdi);
                li.SubItems.Add(Fiyat);
                li.SubItems.Add("1");
                li.SubItems.Add(Fiyat);
                listView1.Items.Add(li);
            }
            else
            {
                int MevcutAdet = Convert.ToInt32(li.SubItems[3].Text);
                li.SubItems[3].Text = (MevcutAdet + 1).ToString();

                double GecerliAdet = Convert.ToDouble(li.SubItems[3].Text);
                double BirimFiyat = Convert.ToDouble(li.SubItems[2].Text);
                li.SubItems[4].Text = (GecerliAdet * BirimFiyat).ToString();
            }

            ToplamTutarGoster();
        }

        private void btnMenu01_Click(object sender, EventArgs e)
        {
            UrunEkle("Menu 01", "14,95");
        }

        private void btnMenu02_Click(object sender, EventArgs e)
        {
            UrunEkle("Menu 02", "8,95");
        }

        private void btnHamburger_Click(object sender, EventArgs e)
        {
            UrunEkle("Hamburger", "2,95");
        }

        private void btnCheeseBurger_Click(object sender, EventArgs e)
        {
            UrunEkle("CheeseBurger", "5,95");
        }

        private void btnPatetesKucuk_Click(object sender, EventArgs e)
        {
            UrunEkle("Patates (Kucuk)", "2,95");
        }

        private void btnPatatesOrta_Click(object sender, EventArgs e)
        {
            UrunEkle("Patates (Orta)", "3,95");
        }

        private void btnPatetesBuyuk_Click(object sender, EventArgs e)
        {
            UrunEkle("Patates (Buyuk)", "4,95");
        }

        private void btnKolaKucuk_Click(object sender, EventArgs e)
        {
            UrunEkle("Kola (Kucuk)", "2,95");
        }

        private void btnKolaOrta_Click(object sender, EventArgs e)
        {
            UrunEkle("Kola (Orta)", "3,95");
        }

        private void btnKolaBuyuk_Click(object sender, EventArgs e)
        {
            UrunEkle("Kola (Buyuk)", "4,95");
        }

        private void btnHepsiniSil_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Tum Urunleri Silmek istediğinize Emin Misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                listView1.Items.Clear();
                ToplamTutarGoster();
            }
        }

        private void btnSecileniSil_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem li in listView1.SelectedItems)
            {
                DialogResult dr = MessageBox.Show(li.SubItems[1].Text + " Adlı Silmek istediğinize Emin Misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    listView1.Items.Remove(li);
                }
            }
            ToplamTutarGoster();
        }

        private void ToplamTutarGoster()
        {
            double ToplamTutar = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                ToplamTutar += Convert.ToDouble(item.SubItems[4].Text);
            }
            lblToplamTutar.Text = ToplamTutar.ToString("N2") + " TL";
        }

        private void btnFisYazdir_Click(object sender, EventArgs e)
        {
            
            YazimYuksekligi = 0;
            Graphics gr = panel1.CreateGraphics();
            gr.FillRectangle(Brushes.White, 0, 0, panel1.Width, panel1.Height);

            #region Logo Çizdirme
            gr.DrawImage(Properties.Resources._20061213mcdonalds, 10, 10, 280, 100);
            //Graphics xxxx = this.CreateGraphics();
            //Yazdir(xxxx, "Kadıkoy Vergi Dai. 1234564535634", "Arial", 13f, FontStyle.Regular, 10, 10, true);

            YazimYuksekligi += 110; // Resmi 10 asagıdan baslattık + 100 de resim yuksekliği 
            #endregion

            #region Adres Ve Falan filan Bilgisi
            Yazdir(gr, "Kadıkoy Vergi Dai. 1234564535634", "Arial", 13f, FontStyle.Regular, 10, YazimYuksekligi, true);

            SizeF YaziB = gr.MeasureString("Sogutlu cesme mah no: 45", new Font("Arial", 10f, FontStyle.Regular));
            float YaziGEnislik = YaziB.Width;
            float PnlGenislik = Convert.ToSingle(panel1.Width);
            float PanelOrta = PnlGenislik / 2;
            float YazininYarisi = YaziGEnislik / 2;
            float YazdirmaNoktasi = PanelOrta - YazininYarisi;
            Yazdir(gr, "Sogutlu cesme mah no: 45", "Arial", 10f, FontStyle.Regular, YazdirmaNoktasi, YazimYuksekligi, true);
            #endregion

            #region Ara Çizgi
            YazimYuksekligi += 5f;
            gr.DrawLine(Pens.Black, 10, YazimYuksekligi, 290, YazimYuksekligi);//çizgi
            YazimYuksekligi += 5f;
            #endregion

            foreach (ListViewItem item in listView1.Items)
            {
                #region Kolon1
                Yazdir(gr, item.Text, "Arial", 10f, FontStyle.Regular, 10, YazimYuksekligi, false); 
                #endregion

                #region Kolon2
                Yazdir(gr, item.SubItems[1].Text, "Arial", 10f, FontStyle.Regular, 30, YazimYuksekligi, false);
                #endregion

                #region Kolon3
                YaziB = gr.MeasureString(item.SubItems[3].Text + "x", new Font("Arial", 10f, FontStyle.Regular));
                float YaziGenislik = YaziB.Width;
                float YazimNoktasi = 210;
                Yazdir(gr, item.SubItems[3].Text + "x", "Arial", 10f, FontStyle.Regular, YazimNoktasi - YaziGenislik, YazimYuksekligi, false);
                #endregion

                #region Kolon4
                YaziB = gr.MeasureString(item.SubItems[2].Text + "TL", new Font("Arial", 10f, FontStyle.Regular));
                YaziGenislik = YaziB.Width;
                YazimNoktasi = 280;
                Yazdir(gr, item.SubItems[2].Text + "TL", "Comic Sans MS", 10f, FontStyle.Regular, YazimNoktasi - YaziGenislik, YazimYuksekligi, true);
                #endregion
            }

            #region Ara Çizgi
            YazimYuksekligi += 5f;
            gr.DrawLine(Pens.Black, 10, YazimYuksekligi, 290, YazimYuksekligi);//çizgi
            YazimYuksekligi += 5f; 
            #endregion

            #region Toplam Bilgisi Yazdırma
            //Bilgileri Hesaplama
            double AraToplam = Convert.ToDouble(lblToplamTutar.Text.Replace("TL", "")) / 1.18;
            double KDV = Convert.ToDouble(lblToplamTutar.Text.Replace("TL", "")) - AraToplam;
            double GenelToplam = Convert.ToDouble(lblToplamTutar.Text.Replace("TL", ""));
            double ParaUstu = Convert.ToDouble(textBox1.Text) - GenelToplam;
            lblParaUstu.Text = ParaUstu.ToString() + " TL";

            //Bilgileri Yazdırma
            Yazdir(gr, "Ara Toplam", "Tahoma", 10f, FontStyle.Bold, 120, YazimYuksekligi, false);
            Yazdir(gr, AraToplam.ToString("N2") + " TL", "Tahoma", 10f, FontStyle.Regular, 220, YazimYuksekligi, true);

            Yazdir(gr, "KDV", "Tahoma", 10f, FontStyle.Bold, 120, YazimYuksekligi, false);
            Yazdir(gr, KDV.ToString("N2") + " TL", "Tahoma", 10f, FontStyle.Regular, 220, YazimYuksekligi, true);

            Yazdir(gr, "Genel Toplam", "Tahoma", 10f, FontStyle.Bold, 120, YazimYuksekligi, false);
            Yazdir(gr, GenelToplam.ToString("N2") + " TL", "Tahoma", 10f, FontStyle.Regular, 220, YazimYuksekligi, true);

            Yazdir(gr, "Para Ustu", "Tahoma", 10f, FontStyle.Bold, 120, YazimYuksekligi, false);
            Yazdir(gr, ParaUstu.ToString("N2") + " TL", "Tahoma", 10f, FontStyle.Regular, 220, YazimYuksekligi, true); 
            #endregion
        }

        float YazimYuksekligi = 0;
        private void Yazdir(Graphics gr, string Yazi, string FontAilesi, float FontBoyut, FontStyle FontStili, float SoldanMesafe, float YukardanMesafe, bool SatirAtlasinMi)
        {
            gr.DrawString(Yazi, new Font(FontAilesi, FontBoyut, FontStili), Brushes.Black, SoldanMesafe, YukardanMesafe);
            if (SatirAtlasinMi == true)
            {
                SizeF YaziBoyut = gr.MeasureString(Yazi, new Font(FontAilesi, FontBoyut, FontStili));
                YazimYuksekligi += YaziBoyut.Height;
            }
        }
    }
}
