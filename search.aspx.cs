using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace FriendsToSupport.com
{
    public partial class temp3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string bloodgrp = Request.Form["D1"];
            string country = Request.Form["D2"];
            string state = Request.Form["D3"];
            string district = Request.Form["D4"];
            string city = Request.Form["D5"];

            MySqlConnection conn = new MySqlConnection("host=localhost; port=3306; username=root;password=Vamshi@5848; database=F2S");
            conn.Open();

             string query = $"select name,mobile_no,city from users where bloodgrp='{bloodgrp}' and country='{country}'and state='{state}' and district='{district}' and city='{city}'";
            
            MySqlCommand cmd = new MySqlCommand(query, conn);

            
            MySqlDataReader reader = cmd.ExecuteReader();
            
            GridView1.DataSource= reader;
            GridView1.DataBind();

            conn.Close();
        }
    }
}