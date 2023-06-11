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

public partial class PromotionsAdd : System.Web.UI.Page
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
        string query2 = "execute PromotionsAdd @rid= '" + TextBox1.Text + "' , @criteria = '" + TextBox3.Text + "'";

        SqlConnection con = new SqlConnection(conString);
        con.Open();
        SqlCommand cmdd = new SqlCommand();
        cmdd.CommandText = query2;
        cmdd.Connection = con;
        int i=cmdd.ExecuteNonQuery();
        if (i > 0)
        {
            Label6.Text = "Promotion added successfully!";
        }
        else
        {
            Label6.Text = "Incorrect Restaurant ID. Enter again";
        }
        TextBox1.Text="";
        TextBox3.Text = "";
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/AdminMain.aspx");
    }
}