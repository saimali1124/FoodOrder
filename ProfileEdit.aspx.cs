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

public partial class ProfileEdit : System.Web.UI.Page
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
        string query2 = "execute ProfileEditing @email = '" + TextBox1.Text + "' , @name = '" + TextBox2.Text + "' , @phone = '" + TextBox3.Text + "' , @address = '" + TextBox4.Text + "'";

        SqlConnection conn = new SqlConnection(conString);
        conn.Open();
        SqlCommand cmdd = new SqlCommand();
        cmdd.CommandText = query2;
        cmdd.Connection = conn;
        int i=cmdd.ExecuteNonQuery();
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        if (i > 0)
        {
            Label5.Text = "Profile updated successfully!";
        }
    }
}