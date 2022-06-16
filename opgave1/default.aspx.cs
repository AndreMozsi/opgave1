using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace opgave1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        

        protected void btnGa_Click(object sender, EventArgs e)
        {
            if (txtNaam.Text == "")
            {
                Response.Write("<script>alert('Vul alles in!') </script>");

            }
            else
            {
                HttpCookie userInfo = new HttpCookie("userInfo");
                userInfo["Geslacht"] = rbtnGeslacht.SelectedValue.ToString();
                Response.Cookies.Add(userInfo);
                Response.Redirect("prentje.aspx");
            }
        }
    }
}