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

public partial class Start : System.Web.UI.Page
{

    public string conString = "Data Source=SAIM-DESKTOP\\SQLEXPRESS;Initial Catalog=FoodOrder1;Integrated Security=True";
    protected void Page_Load(object sender, EventArgs e)
    {
        string query = "execute SignOut";

        SqlConnection con = new SqlConnection(conString);
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = query;
        cmd.Connection = con;
        cmd.ExecuteNonQuery();

        string query2 = "update Restaurants set Restaurants.RestaurantChosen=0";

        SqlConnection conn = new SqlConnection(conString);
        conn.Open();
        SqlCommand cmdd = new SqlCommand();
        cmdd.CommandText = query2;
        cmdd.Connection = conn;
        cmdd.ExecuteNonQuery();
    }
}