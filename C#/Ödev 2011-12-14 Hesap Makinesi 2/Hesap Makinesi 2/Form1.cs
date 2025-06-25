using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hesap_Makinesi_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnTopla_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Int32.Parse(txtSayi1.Text);
            sayi2 = Int32.Parse(txtSayi2.Text);
            sonuc = sayi1 + sayi2;
            MessageBox.Show(Convert.ToString(sonuc));
        }

        private void btnCikart_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Int32.Parse(txtSayi1.Text);
            sayi2 = Int32.Parse(txtSayi2.Text);
            sonuc = sayi1 - sayi2;
            MessageBox.Show(Convert.ToString(sonuc));
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Int32.Parse(txtSayi1.Text);
            sayi2 = Int32.Parse(txtSayi2.Text);
            sonuc = sayi1 * sayi2;
            MessageBox.Show(Convert.ToString(sonuc));
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Int32.Parse(txtSayi1.Text);
            sayi2 = Int32.Parse(txtSayi2.Text);
            sonuc = sayi1 / sayi2;
            MessageBox.Show(Convert.ToString(sonuc));
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtSayi1.Text = "";
            txtSayi2.Text = "";
        }

        private void btnKarekok_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            sayi1 = Int32.Parse(txtSayi1.Text);
            sayi2 = Int32.Parse(txtSayi2.Text);
            MessageBox.Show(Convert.ToString(Math.Sqrt(sayi1)));
            //MessageBox.Show(Convert.ToString(Math.Sqrt(sayi2)));
        }
    }
}
