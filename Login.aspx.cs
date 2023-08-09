using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Tls;

namespace FriendsToSupport.com
{
    public partial class temp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string user=TextBox1.Text;
            string password =TextBox2.Text;

            MySqlConnection conn = new MySqlConnection("host=localhost; port=3306; username=root;password=Vamshi@5848; database=F2S");
            conn.Open();

            string query = $"select * from users where username='{user}' and upassword='{password}'";
            MySqlCommand cmd = new MySqlCommand(query,conn);

            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();

            if(reader.HasRows)
            {
                Response.Write("<script>alert('Login successfully')</script>");
            }
            else
            {
                Response.Write("<script>alert('Incorrect Credentials')</script>");
            }
            conn.Close();
        }
    }
}