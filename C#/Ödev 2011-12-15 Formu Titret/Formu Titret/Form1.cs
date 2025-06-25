using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Formu_Titret
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Left = this.Left + 9000;
            this.Left = this.Left - 9000;
            this.Top = this.Top + 9000;
            this.Top = this.Top - 9000;
        }
    }
}
