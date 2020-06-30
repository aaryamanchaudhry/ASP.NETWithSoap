using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTAaryamanChaudhry
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSearchPublisherByID_Click(object sender, EventArgs e)
        {
            string pub_id = txtSearchPublisherByID.Text;

            ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();

            string[] pub_info = new string[5];

            for (int i = 0; i < 5; i++)
            {

                pub_info[i] = client.returnData(pub_id)[i];

               
            }

            Response.Redirect("Result.aspx?name=" + pub_info[0] + "&city=" + pub_info[1] + "&state=" + pub_info[2] + "&country=" + pub_info[3] + "&empty=" + pub_info[4]);
        }
    }
}