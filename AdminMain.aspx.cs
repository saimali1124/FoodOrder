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

public partial class AdminMain : System.Web.UI.Page
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

    protected void Button8_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Blacklist.aspx");
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Delivered.aspx");
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Payment.aspx");
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/AdminCreditCard.aspx");
    }

    protected void Button9_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/PromotionsAdd.aspx");
    }

    protected void Button10_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/ProfileEdit.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/RestaurantOpen.aspx");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/RestaurantClose.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/AddRestaurant.aspx");
    }
}