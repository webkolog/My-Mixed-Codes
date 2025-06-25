using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ay_Bulucu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        byte sayi;
        bool kontrolEtmek = false;
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                sayi = Convert.ToByte(txtAyNo.Text);
                kontrolEtmek = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Hata: Girilen değer sayı olmalı!");
            }
            catch
            {
                MessageBox.Show("Hata: Bilinmeyen bir hata oluştu!");
            }
            if (kontrolEtmek)
            {
                //scope açmamamın sebebi tek satırlık if işlemleri yaptırmam (bu sebepten dolayı gerekli değil)
                if (sayi == 1)
                    MessageBox.Show("Ocak");
                else if (sayi == 2)
                    MessageBox.Show("Şubat");
                else if (sayi == 3)
                    MessageBox.Show("Mart");
                else if (sayi == 4)
                    MessageBox.Show("Nisan");
                else if (sayi == 5)
                    MessageBox.Show("Mayıs");
                else if (sayi == 6)
                    MessageBox.Show("Haziran");
                else if (sayi == 7)
                    MessageBox.Show("Temmuz");
                else if (sayi == 8)
                    MessageBox.Show("Ağustos");
                else if (sayi == 9)
                    MessageBox.Show("Eylül");
                else if (sayi == 10)
                    MessageBox.Show("Ekim");
                else if (sayi == 11)
                    MessageBox.Show("Kasım");
                else if (sayi == 12)
                    MessageBox.Show("Aralık");
                else
                    MessageBox.Show("Hata: Girdiğiniz değere göre ay bulunamadı!");
            }
        }

    }
}
