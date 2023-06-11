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

public partial class Blacklist : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public string conString = "Data Source=SAIM-DESKTOP\\SQLEXPRESS;Initial Catalog=FoodOrder1;Integrated Security=True";

    protected void Button1_Click(object sender, EventArgs e)
    {
        string query = "execute SignOut";

        SqlConnection con = new SqlConnection(conString);
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = query;
        cmd.Connection = con;
        cmd.ExecuteNonQuery();

        Response.Redirect("~/Start.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string query = "execute Blacklist @email= '" + TextBox1.Text + "'";

        SqlConnection con = new SqlConnection(conString);
        con.Open();
        SqlCommand cmdd = new SqlCommand();
        cmdd.CommandText = query;
        cmdd.Connection = con;
        int i=cmdd.ExecuteNonQuery();

        TextBox1.Text = "";
        if(i>0)
        {
            Label3.Text = "Customer has been blacklisted!";
        }
        else
        {
            Label3.Text = "Email does not exist!";
        }

        //string black = "select UserEmail from Users where UserEmail= '" + TextBox1.Text + "'";
        //SqlCommand cmddd = new SqlCommand(black, con);
        //string flag2 = "empty";
        //flag2= cmddd.ExecuteScalar().ToString();
        //if (flag2 == TextBox1.Text)
        //{
        //    Label3.Text = "User successfully blacklisted!";
        //}
        //else
        //{
        //    Label3.Text = "User does not exist";
        //}
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/AdminMain.aspx");
    }
}