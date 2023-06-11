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
using System.Configuration;

public partial class RestaurantChoose : System.Web.UI.Page
{

    public string conString = "Data Source=SAIM-DESKTOP\\SQLEXPRESS;Initial Catalog=FoodOrder1;Integrated Security=True";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UserBind();
        }
        string query2 = "update Restaurants set Restaurants.RestaurantChosen=0";

        SqlConnection conn = new SqlConnection(conString);
        conn.Open();
        SqlCommand cmdd = new SqlCommand();
        cmdd.CommandText = query2;
        cmdd.Connection = conn;
        cmdd.ExecuteNonQuery();
    }
    protected void UserBind()
    {
        //using (SqlConnection conn = new SqlConnection(cs))
        {
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Restaurants where OpenStatus = '" + 1 + "' ", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                UserPageTable.DataSource = dr;
                UserPageTable.DataBind();
            }
        }
    }



    protected void UserPageTable_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        /*int id = Convert.ToInt32(UserPageTable.DataKeys[e.RowIndex].Value.ToString());

        using (SqlConnection conn = new SqlConnection(cs))
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Food where RestaurantID = '" + id + "' ", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                UserPageTable.DataSource = dr;
                UserPageTable.DataBind();
            }
        }*/
    }

    protected void UserPageTable_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void UserPageTable_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {

    }

    protected void URestID_btn_Click(object sender, EventArgs e)
    {

    }

    protected void URestID_btn_Click1(object sender, EventArgs e)
    {
        int RID = Convert.ToInt32(URestID_txtbox.Text);

        //using (SqlConnection conn = new SqlConnection(cs))
        {
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("update Restaurants set RestaurantChosen = '" + 1 + "' where RestaurantID = '" + RID + "'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
        }

        Server.Transfer("UserSelectsRestaurant.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/UserMain.aspx");
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
}