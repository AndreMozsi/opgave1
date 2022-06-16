using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace opgave1
{
    public partial class prentje : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

            string geslacht = string.Empty;
            HttpCookie reqCookies = Request.Cookies["userInfo"];
            if (reqCookies != null)
            {
                geslacht = reqCookies["Geslacht"].ToString();
            }
            switch (geslacht)
            {
                case "M":
                    form1.Style.Add("background-color", "#ff0000");
                    break;
                case "V":
                    form1.Style.Add("background-color", "#00FF00");
                    break;
                case "X":
                    form1.Style.Add("background-color", "#0000FF");
                    break;
                default:
                    form1.Style.Add("background-color", "#000");
                    break;
            }

        }
    }
}