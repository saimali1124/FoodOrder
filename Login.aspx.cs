using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using System.ComponentModel;

    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string conString = "Data Source=SAIM-DESKTOP\\SQLEXPRESS;Initial Catalog=FoodOrder1;Integrated Security=True";

        protected void Button1_Click(object sender, EventArgs e)
        {
            string query = "execute LogIn @email= '" + TextBox1.Text + "', @password= '" + TextBox2.Text + "'";

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = con;
            int i=cmd.ExecuteNonQuery();
            TextBox1.Text = "";
            TextBox2.Text = "";
            if (i < 1)
            {
                Label3.Text = "Wrong Email or Password! Enter again";
                string queryy = "execute SignOut";
                SqlCommand cmdd = new SqlCommand();
                cmdd.CommandText = queryy;
                cmdd.Connection = con;
                cmdd.ExecuteNonQuery();
            }
            else
            {

                string checkuser2 = "select BlacklistStatus from Users where LoginStatus = 'True'";
                SqlCommand cmddd = new SqlCommand(checkuser2, con);
                string flag2 = cmddd.ExecuteScalar().ToString();
                if (flag2 == "False")
                {
                    string checkuser = "select Admin_ from Users where LoginStatus = 'True'";
                    SqlCommand cmdd = new SqlCommand(checkuser, con);
                    string flag = cmdd.ExecuteScalar().ToString();
                    if (flag == "True")
                    {
                        Response.Redirect("~/AdminMain.aspx");
                        //Response.Write("Admin");

                    }
                    else
                    {
                        Response.Redirect("~/UserMain.aspx");
                        //Response.Write("User");

                    }
                }
                else
                {
                    Label3.Text = "You can not order, you are blacklisted!";

                    string queryy = "execute SignOut";
                    SqlCommand cmdd = new SqlCommand();
                    cmdd.CommandText = queryy;
                    cmdd.Connection = con;
                    cmdd.ExecuteNonQuery();

                    TextBox1.Text = "";
                    TextBox2.Text = "";
                }
            }
        }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Start.aspx");
    }
}