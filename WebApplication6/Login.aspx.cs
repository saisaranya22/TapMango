using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication6
{
    public partial class Login : System.Web.UI.Page
    {
        
        SqlConnection conn = new SqlConnection(
    new SqlConnectionStringBuilder()
    {
        DataSource = "KM_KARTHIK\\SAI_SQL",
        InitialCatalog = "WaterMango",
        UserID = "sai",
        Password = "WaterMango"
    }.ConnectionString
);
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button_Login_Click(object sender, EventArgs e)
        {
            

            string selectSQL = "SELECT count(*) FROM dbo.Users WHERE Username='" + TextboxUsername.Text+"'";
            SqlConnection con = new SqlConnection(conn.ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            con.Close();
            if(temp==1)
            {
                con.Open();
                string checkPassword = "SELECT Password from dbo.Users WHERE Username='" + TextboxUsername.Text + "'";
                SqlCommand passwordCmd = new SqlCommand(checkPassword, con);
                string password = passwordCmd.ExecuteScalar().ToString().Trim();
                if(password==TextboxPassword.Text)
                {
                    Session["New"] = TextboxUsername.Text;
                    Response.Write("Password is Correct");
                    string checkUserLevel = "SELECT UserLevel from dbo.Users WHERE Username='" + TextboxUsername.Text + "'";
                    SqlCommand userLevelCmd = new SqlCommand(checkUserLevel, con);
                    int userLevel = Convert.ToInt32(userLevelCmd.ExecuteScalar().ToString());
                    if(userLevel==1)
                    {
                        Response.Redirect("HomeR1.aspx");
                    }else if (userLevel == 2)
                    {
                        Response.Redirect("HomeR2.aspx");
                    }
                    else if (userLevel == 3)
                    {
                        Response.Redirect("HomeR3.aspx");
                    }
                    else if (userLevel == 4)
                    {
                        Response.Redirect("HomeR4.aspx");
                    }
                    else if (userLevel == 5)
                    {
                        Response.Redirect("HomeR5.aspx");
                    }

                }
                else
                {
                    Response.Write("Password is Not Correct");
                }

            }
            else
            {
                Response.Write("Username is Not Correct");
            }
        }

        protected void Button_Register_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}