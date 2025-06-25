using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace At_Yarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool oranGuncelMi = false;
        Random rnd = new Random();
        double kasa;
        PictureBox[] ResAtlar = new PictureBox[3];
        Label[] lblAtOranlar = new Label[3];
        string secilenAt;
        double bahisOran, bahisPara;
        private void btnOranGuncelle_Click(object sender, EventArgs e)
        {
            foreach (Label lblAtOran in lblAtOranlar)
                lblAtOran.Text = "1," + rnd.Next(10, 51);
            oranGuncelMi = true;
        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            try
            {
                kasa += Convert.ToDouble(txtKasa.Text);
                lblKasa.Text = kasa.ToString("0.00") +" TL";
                txtKasa.Text = "";
            }
            catch
            {
                MessageBox.Show("Hata: Girdiğiniz değer hatalı!");
            }
        }

        private void btnOyna_Click(object sender, EventArgs e)
        {
            if (!oranGuncelMi)
            {
                MessageBox.Show("Hata: Önce oranı güncelleyiniz!");
            }
            else
            {
                if (kasa < 1)
                {
                    MessageBox.Show("Hata: Kasada hiç paranız yok!");
                }
                else
                {
                    if (cbAtlar.SelectedIndex == -1)
                    {
                        MessageBox.Show("Hata: Hiç at seçmediniz!");
                    }
                    else
                    {
                        try
                        {
                            double gelenPara = Convert.ToDouble(txtBahisPara.Text);
                            if (gelenPara > kasa)
                            {
                                MessageBox.Show("Hata: Kasada sadece " + kasa + " TL bulunmaktadır!\nFakat siz " + gelenPara + " TL yatırmaya çalışıyorsunuz.\nNe iş? Yok öyle 5 kuruşa 2 köfte :|");
                            }
                            else
                            {
                                foreach (PictureBox kosanAt in ResAtlar)
                                    kosanAt.Left = 11;
                                bahisPara = gelenPara;
                                kasa -= gelenPara;
                                lblKasa.Text = kasa.ToString("0.00") +" TL";
                                secilenAt = cbAtlar.SelectedItem.ToString();
                                bahisOran = Convert.ToDouble(lblAtOranlar[cbAtlar.SelectedIndex].Text);
                                txtBahisPara.Text = "";
                                cbAtlar.SelectedIndex = -1;
                                oranGuncelMi = false;
                                foreach (PictureBox ResAt in ResAtlar)
                                    ResAt.Image = Image.FromFile("images/at_aktif.gif");
                                timer1.Start();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Hata: Bahis parası girmediniz!");
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResAtlar[0] = picAt1;
            ResAtlar[1] = picAt2;
            ResAtlar[2] = picAt3;
            lblAtOranlar[0] = lblAt1Oran;
            lblAtOranlar[1] = lblAt2Oran;
            lblAtOranlar[2] = lblAt3Oran;
            cbAtlar.Items.Add("Haydar");
            cbAtlar.Items.Add("Osman");
            cbAtlar.Items.Add("Kamil");
            foreach (PictureBox ResAt in ResAtlar)
                ResAt.Image = Image.FromFile("images/at_pasif.gif");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox ResAt in ResAtlar)
            {
                ResAt.Left += rnd.Next(1, 5);
                if (ResAt.Right >= lblBitis.Left)
                {
                    timer1.Stop();
                    foreach (PictureBox ResAt2 in ResAtlar)
                        ResAt2.Image = Image.FromFile("images/at_pasif.gif");
                    MessageBox.Show(ResAt.Tag.ToString() + " yarışı kazandı!");
                    if (secilenAt == ResAt.Tag.ToString())
                    {
                        kasa += (bahisPara * bahisOran);
                        lblKasa.Text = kasa.ToString("0.00") + " TL";
                        MessageBox.Show("Tebrikler, bu yarışı sizin seçtiğiniz at kazandı!");
                    }
                    else
                    {
                        MessageBox.Show("Malesef seçtiğiniz at bu yarışı kazanamadı!");
                    }
                    break;
                }
            }
        }
    }
}
