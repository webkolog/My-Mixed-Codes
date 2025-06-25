using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication2
{
    public partial class Kategoriler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=.; Database=KuzeyRuzgari; trusted_connection=true");

            if (Request.Form["KategoriAdi"] != null & Request.Form["Aciklama"] != null)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Kategoriler (KategoriAdi,Aciklama) VALUES (@KatAdi,@Aciklama)", conn);
                cmd.Parameters.AddWithValue("@KatAdi", Request.Form["KategoriAdi"]);
                cmd.Parameters.AddWithValue("@Aciklama", Request.Form["Aciklama"]);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Kategoriler ORDER BY KategoriID ASC", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Repeater1.DataSource = dt;
            Repeater1.DataBind();

        }
    }
}