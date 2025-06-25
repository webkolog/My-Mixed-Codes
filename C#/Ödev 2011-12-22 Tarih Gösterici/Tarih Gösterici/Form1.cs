using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tarih_Gösterici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (byte i = 1; i <= 31; i++)
                cbGun.Items.Add(i);
            for (byte i = 1; i <= 12; i++)
                cbAy.Items.Add(i);
            for (int i = 2011; i >= 1900; i--)
                cbYil.Items.Add(i);
        }

        private void btnTarihGoster_Click(object sender, EventArgs e)
        {
            if (cbGun.SelectedIndex == -1)
                MessageBox.Show("Hata: Hiç gün seçmediniz!");
            else if (cbAy.SelectedIndex == -1)
                MessageBox.Show("Hata: Hiç ay seçmediniz!");
            else if (cbYil.SelectedIndex == -1)
                MessageBox.Show("Hata: Hiç yıl seçmediniz!");
            else
            {
                byte bytGun, bytAy;
                int intYil;
                string[] Aylar = new string[] { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };
                bytGun = (byte)cbGun.SelectedItem;
                bytAy = (byte)cbAy.SelectedItem;
                intYil = (int)cbYil.SelectedItem;
                lblTarih1.Text = bytGun + "-" + bytAy + "-" + intYil;
                lblTarih2.Text = bytGun + " " + Aylar[bytAy - 1] + " " + intYil;
            }
        }
    }
}
