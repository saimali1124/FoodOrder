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

public partial class SignUp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public string conString = "Data Source=SAIM-DESKTOP\\SQLEXPRESS;Initial Catalog=FoodOrder1;Integrated Security=True";

    protected void Button1_Click1(object sender, EventArgs e)
    {
        int i = 0;
        if(DropDownList1.SelectedItem.Value=="User")
        {
            i = 0;
        }
        else
        {
            i = 1;
        }
        string query = "execute SignUp @email= '" + TextBox2.Text + "', @name = '" + TextBox1.Text + "', @phone = '" + TextBox3.Text + "', @address = '" + TextBox4.Text + "', @password = '" + TextBox5.Text + "', @admin = '" + i + "'";
        SqlConnection con = new SqlConnection(conString);
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = query;
        cmd.Connection = con;
        cmd.ExecuteNonQuery();
        
        Label3.Text = "Sign Up Successful! - Thanks For Registration";
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Start.aspx");
    }
}
