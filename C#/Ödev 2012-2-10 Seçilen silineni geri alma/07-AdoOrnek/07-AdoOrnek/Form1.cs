using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _07_AdoOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dt;
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("server=.; Database=KuzeyRuzgari; trusted_connection=true");
            SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM Urunler", cnn);
            dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            //Flan = 323 OR Filan= 'ABS'
            try
            {
                dv.RowFilter = "UrunAdi LIKE '%" + textBox1.Text + "%' OR Fiyat = " + textBox1.Text;
            }
            catch
            {
                dv.RowFilter = "UrunAdi LIKE '%" + textBox1.Text + "%'";
            }
            //"UrunAdi LIKE 'gra%'"
            dataGridView1.DataSource = dv;
        }

        private void btnSilinenleriGoster_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowStateFilter = DataViewRowState.Deleted;
            dataGridView2.DataSource = dv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dataGridView2.SelectedRows)
            {
                int i = 0;
                foreach (DataRow dc in dt.Rows)
                {
                    if (dc.RowState == DataRowState.Deleted)
                    {
                        if (dgvr.Index == i)
                        {
                            dc.RejectChanges();
                        }
                        i++;
                    }
                }
            }
        }
    }
}
