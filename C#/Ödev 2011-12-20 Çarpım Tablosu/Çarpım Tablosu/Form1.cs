using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Çarpım_Tablosu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1, i2 = 1;
            listBox1.Items.Clear();
            while (i <= 10)
            {
                while (i2 <= 10)
                {
                    listBox1.Items.Add(i + " X " + i2 + " = " + (i * i2));
                    i2++;
                }
                i2 = 1;
                i++;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 1, i2 = 1;
            listBox1.Items.Clear();
            do
            {
                do
                {
                    listBox1.Items.Add(i + " X " + i2 + " = " + (i * i2));
                    i2++;
                } while (i2 <= 10);
                i2 = 1;
                i++;
            } while (i <= 10);
        }


    }
}
