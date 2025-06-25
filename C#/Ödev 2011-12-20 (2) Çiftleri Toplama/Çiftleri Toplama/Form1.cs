using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Çiftleri_Toplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string konu = "1 ile 3000 arasında ki çift sayıların toplamı: ";
        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1, toplam = 0;
            while (i <= 2000)
            {
                if (i % 2 == 0) toplam += i;
                i++;
            }
            MessageBox.Show(konu+toplam.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 1, toplam = 0;
            do {
                if (i % 2 == 0) toplam += i;
                i++;
            } while(i<=2000);
            MessageBox.Show(konu+toplam.ToString());
        }
    }
}
