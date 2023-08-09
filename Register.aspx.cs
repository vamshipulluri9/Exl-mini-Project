using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;


namespace FriendsToSupport.com
{
    public partial class temp2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            string bloodgrp = Request.Form["D1"];
            long mobile_no = Convert.ToInt64(TextBox2.Text);
            string country = Request.Form["D2"];
            string state = Request.Form["D3"];
            string district = Request.Form["D4"];
            string city = Request.Form["D5"];
            string email_id = TextBox3.Text;
            string username = TextBox4.Text;
            string password = TextBox5.Text;
            string availability = Request.Form["D6"];



            MySqlConnection conn = new MySqlConnection("host=localhost; port=3306; username=root;password=Vamshi@5848; database=F2S");
            conn.Open();

            string query = $"insert into users values ('{name}','{bloodgrp}','{mobile_no}','{country}','{state}','{district}','{city}','{email_id}','{username}','{password}','{availability}')";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.ExecuteNonQuery();

            Response.Write("<script>alert('inserted Values successfully')</script>");

            conn.Close();
        }
    }
}