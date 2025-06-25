using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            try
            {
                int sayi = Convert.ToInt32(TextBox1.Text);
                args.IsValid = (0 == sayi % 2);
            }
            catch
            {
                args.IsValid = false;
            }
        }
    }
}