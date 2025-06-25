using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtSayi1.Text + "+" + txtSayi2.Text + "=" + Convert.ToString(Int32.Parse(txtSayi1.Text) + Int32.Parse(txtSayi2.Text)));
        }

        private void btnCikart_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtSayi1.Text + "-" + txtSayi2.Text + "=" + Convert.ToString(Int32.Parse(txtSayi1.Text) - Int32.Parse(txtSayi2.Text)));
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtSayi1.Text + "*" + txtSayi2.Text + "=" + Convert.ToString(Int32.Parse(txtSayi1.Text) * Int32.Parse(txtSayi2.Text)));
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtSayi1.Text + "/" + txtSayi2.Text + "=" + Convert.ToString(Int32.Parse(txtSayi1.Text) / Int32.Parse(txtSayi2.Text)));
        }
    }
}
