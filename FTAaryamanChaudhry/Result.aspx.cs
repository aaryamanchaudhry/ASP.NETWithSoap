using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTAaryamanChaudhry
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["name"] != "")
            {
                string name = Request.QueryString["name"];
                string city = Request.QueryString["city"];
                string state = Request.QueryString["state"];
                string country = Request.QueryString["country"];
                lblResults.Text = "Name =" + name + " " + "City =" + city + " " + "State =" + state + " " + "Country =" + country;

            }

            else {
                lblResults.Text = " Invalid Publisher ID";
            }
        }

        
    }
}