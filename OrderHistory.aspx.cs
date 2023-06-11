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

public partial class OrderHistory : System.Web.UI.Page
{

    public string conString = "Data Source=SAIM-DESKTOP\\SQLEXPRESS;Initial Catalog=FoodOrder1;Integrated Security=True";
    protected void Page_Load(object sender, EventArgs e)
    {
        string query = "select Orders.OrderID, Restaurants.RestaurantName, Orders.PaymentAmount, Orders.OrderMethod, Orders.PaymentType, Orders.PaymentStatus, Orders.OrderDelivered, Orders.OrderDate from (Orders join Restaurants on Orders.RestaurantID=Restaurants.RestaurantID) join Users on Users.UserID= Orders.UserID where Users.LoginStatus=1";

        SqlConnection con = new SqlConnection(conString);
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = query;
        cmd.Connection = con;

        SqlDataReader reader = cmd.ExecuteReader();
        GridView1.DataSource = reader;
        GridView1.DataBind();




        string query2 = "select * from Reviews";

        SqlConnection conn = new SqlConnection(conString);
        conn.Open();
        SqlCommand cmdd = new SqlCommand();
        cmdd.CommandText = query2;
        cmdd.Connection = conn;

        SqlDataReader readerr = cmdd.ExecuteReader();
        GridView2.DataSource = readerr;
        GridView2.DataBind();
    }
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
        Response.Redirect("~/UserMain.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        string query = "execute AddReview @rev = '" + TextBox3.Text + "', @ord = '" + TextBox2.Text + "', @rest = '"+ TextBox1.Text + "'";

        SqlConnection con = new SqlConnection(conString);
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = query;
        cmd.Connection = con;
        int i=cmd.ExecuteNonQuery();

        if (i > 0)
        {
            Label7.Text = "Review added!";
        }
        else
        {
            Label7.Text = "Error! Wrong Restaurant or Order ID!";
        }

        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
    }
}