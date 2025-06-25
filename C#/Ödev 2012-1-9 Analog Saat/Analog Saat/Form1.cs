using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Analog_Saat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Refresh();
            Pen MaviKalem = new Pen(Color.Blue, 10f);
            Pen KirmiziKalem = new Pen(Color.Red, 8f);
            Pen SariKalem = new Pen(Color.Yellow, 4f);
            Graphics akrep = panel1.CreateGraphics();
            Graphics yelkova = panel1.CreateGraphics();
            Graphics saniye = panel1.CreateGraphics();
            int i_saat = System.DateTime.Now.Hour;
            int i_dak = DateTime.Now.Minute;
            int i_san = DateTime.Now.Second;
            int Yarisi = panel1.Width / 2;
            akrep.TranslateTransform(Yarisi, Yarisi);
            akrep.RotateTransform(Convert.ToInt32(Math.Round((double)i_saat / 12 * 360, 0)));
            akrep.DrawLine(MaviKalem, 0, 0, 0, -60);
            yelkova.TranslateTransform(180, 180);
            yelkova.RotateTransform(Convert.ToInt32(Math.Round((double)i_dak / 60 * 360, 0)));
            yelkova.DrawLine(KirmiziKalem, 0, 0, 0, -90);
            saniye.TranslateTransform(180, 180);
            saniye.RotateTransform(Convert.ToInt32(Math.Round((double)i_san / 60 * 360, 0)));
            saniye.DrawLine(SariKalem, 0, 0, 0, -110);
            
        }
    }
}
