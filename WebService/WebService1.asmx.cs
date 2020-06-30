using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        string cs = WebConfigurationManager.ConnectionStrings["DBPubAuthor"].ConnectionString;
        SqlConnection conn;
        SqlDataReader reader;
        SqlCommand cmd;

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string[] returnData(string pub_id)
        {

            conn = new SqlConnection(cs);
            string query = "Select pub_name, city, state, country from publishers where pub_id = '" + pub_id + "'";

            cmd = new SqlCommand(query, conn);
            string[] returnfields = new string[5];

            using (conn)
            {
                conn.Open();
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        returnfields[0] = reader.GetString(0);
                        returnfields[1] = reader.GetString(1);
                        returnfields[2] = reader.GetString(2);
                        returnfields[3] = reader.GetString(3);
                        returnfields[4] = "";
                        reader.Close();

                    }
                }
                else
                {
                    returnfields[0] = "";
                    returnfields[1] = "";
                    returnfields[2] = "";
                    returnfields[3] = "";

                    returnfields[4] = "";

                }
            }




            conn.Close();


            return returnfields;
        }
    }
}
