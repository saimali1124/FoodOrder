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

public partial class UserSelectsRestaurant : System.Web.UI.Page
{

    public string conString = "Data Source=SAIM-DESKTOP\\SQLEXPRESS;Initial Catalog=FoodOrder1;Integrated Security=True";
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            UserBind();
        }
    }

    protected void UserBind()
    {
        int Rid = -1;

        //using (SqlConnection conn = new SqlConnection(cs))
        {
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("OpenRestaurantID", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter outputParameter = new SqlParameter();
            outputParameter.ParameterName = "@RestID";
            outputParameter.SqlDbType = System.Data.SqlDbType.Int;
            outputParameter.Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add(outputParameter);

            SqlDataReader dr = cmd.ExecuteReader();

            Rid = (int)outputParameter.Value;
        }

        //using (SqlConnection conn = new SqlConnection(cs))
        {
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Food where RestaurantID = '" + Rid + "'", conn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows == true)
            {
                GridView_UserSelectedRest.DataSource = dr;
                GridView_UserSelectedRest.DataBind();
            }
        }
    }

    protected void GridView_UserSelectedRest_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btn_Back_UserSelectedRest_Click(object sender, EventArgs e)
    {
        string query2 = "update Restaurants set Restaurants.RestaurantChosen=0";

        SqlConnection conn = new SqlConnection(conString);
        conn.Open();
        SqlCommand cmdd = new SqlCommand();
        cmdd.CommandText = query2;
        cmdd.Connection = conn;
        cmdd.ExecuteNonQuery();
        Response.Redirect("RestaurantChoose.aspx");
    }

    //protected void FoodBind()
    //{
    //    int OrderLID_1 = -1;

    //    using (SqlConnection conn = new SqlConnection(cs))
    //    {
    //        conn.Open();
    //        SqlCommand cmd = new SqlCommand("TopOrderListID", conn);
    //        cmd.CommandType = System.Data.CommandType.StoredProcedure;

    //        SqlParameter outputParameter = new SqlParameter();
    //        outputParameter.ParameterName = "@topID";
    //        outputParameter.SqlDbType = System.Data.SqlDbType.Int;
    //        outputParameter.Direction = System.Data.ParameterDirection.Output;
    //        cmd.Parameters.Add(outputParameter);

    //        SqlDataReader dr = cmd.ExecuteReader();

    //        OrderLID_1 = (int)outputParameter.Value;
    //    }

    //    using (SqlConnection conn = new SqlConnection(cs))
    //    {
    //            conn.Open();
    //            SqlCommand cmd = new SqlCommand("select * from OrderList where OrderListID = '" + OrderLID_1 + "' ", conn);
    //            SqlDataReader dr = cmd.ExecuteReader();
    //            if (dr.HasRows == true)
    //            {
    //                GridView_ChoosenFoods.DataSource = dr;
    //                GridView_ChoosenFoods.DataBind();
    //            }
    //    }
    //}
    protected void GridView_ChoosenFoods_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void bttn_Submit_OrderList_Click(object sender, EventArgs e)
    {
        int Rid = -1;
        int OrderLID_1 = -1;

        //using (SqlConnection conn = new SqlConnection(cs))
        {
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("TopOrderListID", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter outputParameter = new SqlParameter();
            outputParameter.ParameterName = "@topID";
            outputParameter.SqlDbType = System.Data.SqlDbType.Int;
            outputParameter.Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add(outputParameter);

            SqlDataReader dr = cmd.ExecuteReader();

            OrderLID_1 = (int)outputParameter.Value;
        }

        //using (SqlConnection conn = new SqlConnection(cs))
        {
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("OpenRestaurantID", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter outputParameter = new SqlParameter();
            outputParameter.ParameterName = "@RestID";
            outputParameter.SqlDbType = System.Data.SqlDbType.Int;
            outputParameter.Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add(outputParameter);

            SqlDataReader dr = cmd.ExecuteReader();

            Rid = (int)outputParameter.Value;
        }

        //using (SqlConnection conn = new SqlConnection(cs))
        {
            SqlConnection conn = new SqlConnection(conString);
            int FoodID = Convert.ToInt32(txtbox_Foods_UserSelectedRest.Text);
            int FoodQuantity = Convert.ToInt32(txtbox_FoodsQuantity_UserSelectedRest.Text);

            //outputParameter.Value is timestamp
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into OrderList values('" + OrderLID_1 + "','" + FoodID + "', '" + FoodQuantity + "')", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            //FoodBind();
        }

        if (txtbox_UserSPaymentType.Text == "Cash")
        {
            int FoodID = Convert.ToInt32(txtbox_Foods_UserSelectedRest.Text);
            int FoodQuantity = Convert.ToInt32(txtbox_FoodsQuantity_UserSelectedRest.Text);

            //using (SqlConnection conn = new SqlConnection(cs))
            {
                SqlConnection conn = new SqlConnection(conString);
                conn.Open();

                string OrderMethod = txtbox_UserSOrderMethod.Text;
                string PaymentType = txtbox_UserSPaymentType.Text;

                SqlCommand cmd = new SqlCommand("insertOrder", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FoodID", FoodID);
                cmd.Parameters.AddWithValue("@FoodQuantity", FoodQuantity);
                cmd.Parameters.AddWithValue("@RestID", Rid);
                cmd.Parameters.AddWithValue("@OrderMethod", OrderMethod);
                cmd.Parameters.AddWithValue("@PaymentType", PaymentType);
                cmd.Parameters.AddWithValue("@OrderListID", OrderLID_1);
                cmd.Parameters.AddWithValue("@PaymentStatus", 0);

                int t = cmd.ExecuteNonQuery();
                if (t > 0)
                {
                    Response.Write("<script> alert('Order has been placed successfully') </script>");
                }
            }
        }
        else if (txtbox_UserSPaymentType.Text == "Card")
        {
            int check = 0;
            int FoodID = Convert.ToInt32(txtbox_Foods_UserSelectedRest.Text);
            int FoodQuantity = Convert.ToInt32(txtbox_FoodsQuantity_UserSelectedRest.Text);
            int PIN = Convert.ToInt32(txtbox_UserSPin.Text);
            int CardID = Convert.ToInt32(txtbox_UserSCardID.Text);

            //using (SqlConnection conn = new SqlConnection(cs))
            {
                SqlConnection conn = new SqlConnection(conString);

                conn.Open();
                SqlCommand cmd = new SqlCommand("CardPayment", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FoodID", FoodID);
                cmd.Parameters.AddWithValue("@FoodQuantity", FoodQuantity);
                cmd.Parameters.AddWithValue("@PIN", PIN);
                cmd.Parameters.AddWithValue("@CardID", CardID);

                SqlParameter outputParameter = new SqlParameter();
                outputParameter.ParameterName = "@check";
                outputParameter.SqlDbType = System.Data.SqlDbType.Int;
                outputParameter.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(outputParameter);

                SqlDataReader dr = cmd.ExecuteReader();

                check = (int)outputParameter.Value;
            }

            if (check == 1)
            {
                //using (SqlConnection conn = new SqlConnection(cs))
                {
                    SqlConnection conn = new SqlConnection(conString);
                    conn.Open();

                    string OrderMethod = txtbox_UserSOrderMethod.Text;
                    string PaymentType = txtbox_UserSPaymentType.Text;

                    SqlCommand cmd = new SqlCommand("insertOrder", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@FoodID", FoodID);
                    cmd.Parameters.AddWithValue("@FoodQuantity", FoodQuantity);
                    cmd.Parameters.AddWithValue("@RestID", Rid);
                    cmd.Parameters.AddWithValue("@OrderMethod", OrderMethod);
                    cmd.Parameters.AddWithValue("@PaymentType", PaymentType);
                    cmd.Parameters.AddWithValue("@OrderListID", OrderLID_1);
                    cmd.Parameters.AddWithValue("@PaymentStatus", 1);

                    int t = cmd.ExecuteNonQuery();
                    if (t > 0)
                    {
                        Response.Write("<script> alert('Order has been placed successfully') </script>");
                    }
                }
            }
            else
            {
                Response.Write("<script> alert('Order not placed successfully, Credit Card Payment Rejected') </script>");
            }
        }
        else if (txtbox_UserSPaymentType.Text == "Card")
        {
            int check = 0;
            int FoodID = Convert.ToInt32(txtbox_Foods_UserSelectedRest.Text);
            int FoodQuantity = Convert.ToInt32(txtbox_FoodsQuantity_UserSelectedRest.Text);
            int PIN = Convert.ToInt32(txtbox_UserSPin.Text);
            int CardID = Convert.ToInt32(txtbox_UserSCardID.Text);

            //using (SqlConnection conn = new SqlConnection(cs))
            {
                SqlConnection conn = new SqlConnection(conString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("CardPayment", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FoodID", FoodID);
                cmd.Parameters.AddWithValue("@FoodQuantity", FoodQuantity);
                cmd.Parameters.AddWithValue("@PIN", PIN);
                cmd.Parameters.AddWithValue("@CardID", CardID);

                SqlParameter outputParameter = new SqlParameter();
                outputParameter.ParameterName = "@check";
                outputParameter.SqlDbType = System.Data.SqlDbType.Int;
                outputParameter.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(outputParameter);

                SqlDataReader dr = cmd.ExecuteReader();

                check = (int)outputParameter.Value;
            }

            if (check == 1)
            {
                //using (SqlConnection conn = new SqlConnection(cs))
                {
                    SqlConnection conn = new SqlConnection(conString);
                    conn.Open();

                    string OrderMethod = txtbox_UserSOrderMethod.Text;
                    string PaymentType = txtbox_UserSPaymentType.Text;

                    SqlCommand cmd = new SqlCommand("insertOrder", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@RestID", Rid);
                    cmd.Parameters.AddWithValue("@OrderMethod", OrderMethod);
                    cmd.Parameters.AddWithValue("@PaymentType", PaymentType);
                    cmd.Parameters.AddWithValue("@OrderListID", OrderLID_1);
                    cmd.Parameters.AddWithValue("@PaymentStatus", 1);

                    int t = cmd.ExecuteNonQuery();
                    if (t > 0)
                    {
                        Response.Write("<script> alert('Order has been placed successfully') </script>");
                    }
                }
            }
            else
            {
                Response.Write("<script> alert('Order not placed successfully, Credit Card Payment Rejected') </script>");
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
}