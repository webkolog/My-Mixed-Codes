using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Slot_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnOyna.Enabled = false;
        }
        int intKasa;
        byte i;
        byte slot1 = 1, slot2 = 1, slot3 = 1;
        Random rnd = new Random();
        private void btnKrediAl_Click(object sender, EventArgs e)
        {
            bool hatayok = true;
            int gelenKredi = 0;
            try
            {
                gelenKredi = Int32.Parse(txtKredi.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Hata: Lütfen sayı giriniz!");
                hatayok = false;
            }
            /*
             * txtKredi.MaxLength değerini 3 olarak ayarlamıştım zaten :)
            catch(OverflowException) {
                MessageBox.Show("Hata: Çok fazla rakam girdiniz!");    
                }
            */
            catch
            {
                MessageBox.Show("Hata: Bilinmeyen bir hata ile karşılaşıldı!");
            }
            if (hatayok)
            {
                if (gelenKredi < 1 | gelenKredi > 300)
                {
                    MessageBox.Show("Hata: 1 ile 300 arasında rakam girmelisiniz!");
                }
                else
                {
                    intKasa += gelenKredi;
                    lblKasa.Text = "Kasa: " + intKasa + " $";
                    if (intKasa >= 5)
                    {
                        btnKrediAl.Enabled = false;
                        txtKredi.Enabled = false;
                        btnOyna.Enabled = true;
                    }
                }
            }
            txtKredi.Text = "";
        }

        private void btnOyna_Click(object sender, EventArgs e)
        {
            intKasa -= 5;
            lblKasa.Text = "Kasa: " + intKasa + " $";
            i = 1;
            btnOyna.Enabled = false;
            lblSayi1.BackColor = Color.LightBlue;
            lblSayi2.BackColor = Color.LightBlue;
            lblSayi3.BackColor = Color.LightBlue;
            timer1.Interval = 50;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i <= 45)
            {
                slot3 = (byte)(rnd.Next(1, 10));
                lblSayi3.Text = Convert.ToString(slot3);
            }
            if (i <= 30)
            {
                slot2 = (byte)(rnd.Next(1, 10));
                lblSayi2.Text = Convert.ToString(slot2);
            }
            else
            {
                switch (slot2)
                {
                    case 7:
                        {
                            lblSayi2.BackColor = Color.Red;
                            break;
                        }
                    default:
                        {
                            lblSayi2.BackColor = Color.Yellow;
                            break;
                        }
                }
            }
            if (i <= 15)
            {
                slot1 = (byte)(rnd.Next(1, 10));
                lblSayi1.Text = Convert.ToString(slot1);
            }
            else
            {
                switch (slot1)
                {
                    case 7:
                        {
                            lblSayi1.BackColor = Color.Red;
                            break;
                        }
                    default:
                        {
                            lblSayi1.BackColor = Color.Yellow;
                            break;
                        }
                }
            }
            if (i == 45)
            {
                switch (slot3)
                {
                    case 7:
                        {
                            lblSayi3.BackColor = Color.Red;
                            break;
                        }
                    default:
                        {
                            lblSayi3.BackColor = Color.Yellow;
                            break;
                        }
                }
                btnOyna.Enabled = true;
                timer1.Stop();
                if (slot1 == 7 & slot2 == 7 & slot3 == 7)
                {
                    intKasa += 500;
                    MessageBox.Show("Tebrikler, 500$ kazandın!");
                }
                else if (slot2 == 7 & slot3 == 7)
                {
                    intKasa += 50;
                    MessageBox.Show("Tebrikler, 50$ kazandın!");
                }
                lblKasa.Text = "Kasa: " + intKasa + " $";
                if (intKasa < 5)
                {
                    btnOyna.Enabled = false;
                    btnKrediAl.Enabled = true;
                    txtKredi.Enabled = true;
                }
            }
            i++;
        }
    }
}
