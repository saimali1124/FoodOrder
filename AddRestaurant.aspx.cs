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

public partial class AddRestaurant : System.Web.UI.Page
{

    public string conString = "Data Source=SAIM-DESKTOP\\SQLEXPRESS;Initial Catalog=FoodOrder1;Integrated Security=True";
    //string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            OpeningRest();
        }
    }

    protected void OpeningRest()
    {
        //using (SqlConnection conn = new SqlConnection(cs))
        {
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Restaurants", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                OpeningRest1.DataSource = dr;
                OpeningRest1.DataBind();
            }
        }
    }

    void clear()
    {
        RestID.Text = "";
        RestName.Text = "";
        RestLocation.Text = "";
        RestStatus.Text = "";
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
       // using (SqlConnection conn = new SqlConnection(cs))
        {
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            //bool bit = bool.Parse(RestStatus.Text);
            SqlCommand cmd = new SqlCommand("insert into Restaurants values('" + RestID.Text + "', '" + RestName.Text + "'," +
                "'" + RestLocation.Text + "', '" + RestStatus.Text + "' , '0')", conn);
            int t = cmd.ExecuteNonQuery();
            if (t > 0)
            {
                OpeningRest();
                Response.Write("<script> alert('Restaurant has been added successfully') </script>");
            }
            clear();
        }
    }

    protected void OpeningRest1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int id = Convert.ToInt32(OpeningRest1.DataKeys[e.RowIndex].Value.ToString());

        //using (SqlConnection conn = new SqlConnection(cs))
        {
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from Restaurants where RestaurantID = '" + id + "'", conn);
            int t = cmd.ExecuteNonQuery();

            if (t > 0)
            {
                Response.Write("<script> alert('Restaurant has been Deleted') </script>");
                OpeningRest1.EditIndex = -1;
                OpeningRest();
            }
        }
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

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/AdminMain.aspx");
    }
}