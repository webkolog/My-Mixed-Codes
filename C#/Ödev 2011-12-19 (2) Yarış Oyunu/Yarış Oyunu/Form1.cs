using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Yarış_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int arb1Left, arb2Left;
        Random rnd = new Random();
        private void btnYaristir_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnYaristir.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            arb1Left = rnd.Next(1, 10);
            arb2Left = rnd.Next(1, 10);
            picAraba1.Left += arb1Left;
            picAraba2.Left += arb2Left;
            if (picAraba1.Right >= lblFinish.Left & picAraba1.Right == picAraba2.Right)
            {
                timer1.Stop();
                MessageBox.Show(picAraba1.Tag + " ve " + picAraba2.Tag + " aynı zamanda yarışı bitirdi!");
                btnYenile.Enabled = true;
            }
            else if (picAraba1.Right >= lblFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show(picAraba1.Tag + " 1. oldu!");
                btnYenile.Enabled = true;
            }
            else if (picAraba2.Right >= lblFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show(picAraba2.Tag + " 1. oldu!");
                btnYenile.Enabled = true;
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            picAraba1.Left = 12;
            picAraba2.Left = 12;
            btnYenile.Enabled = false;
            btnYaristir.Enabled = true;
        }
    }
}
