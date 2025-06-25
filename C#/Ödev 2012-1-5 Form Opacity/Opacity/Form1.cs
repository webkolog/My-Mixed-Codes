using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Opacity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool acildimi = false;
        double b = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = b;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (acildimi)
            {
                if (b <= 0.1)
                {
                    timer1.Stop();
                    acildimi = false;
                    Application.Exit();
                }
                else
                {
                    b -= 0.1;
                    this.Opacity = b;
                }
            }
            else
            {
                if (b >= 0.9)
                {
                    timer1.Stop();
                    acildimi = true;
                }
                else
                {
                    b += 0.1;
                    this.Opacity = b;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (acildimi)
            {
                e.Cancel = true;
                timer1.Start();
            }
        }
    }
}
