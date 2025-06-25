using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Odev_CB_Valudaor_kontrol
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool seciliMi = false;
            foreach (Control ct in Page.Form.Controls)
            {
                if (ct is CheckBox)
                {
                    CheckBox cb = ct as CheckBox;
                    if (cb.Checked)
                    {
                        seciliMi = true;
                    }
                }
            }
            CustomValidator1.IsValid = seciliMi == true ? true : false;
        }
    }
}