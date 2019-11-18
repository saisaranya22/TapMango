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
    public partial class Register : System.Web.UI.Page
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

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conn.ConnectionString);
            con.Open();
           
            string selectSQL = "SELECT count(*) FROM dbo.Users WHERE Username='" + TextboxUsername.Text + "'";
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            if (temp != 0)
            {
                Response.Write("User Already Exists");
               
            }
            else
            {
                string insertSQL = "INSERT INTO dbo.Users (Username,Password,UserLevel) VALUES(@uname,@password,@userlevel)";
                SqlCommand insertCmd = new SqlCommand(insertSQL, con);
                insertCmd.Parameters.AddWithValue("@uname", TextboxUsername.Text);
                insertCmd.Parameters.AddWithValue("@password", TextboxPassword.Text);
                insertCmd.Parameters.AddWithValue("@userlevel", DropDownList1.SelectedValue);
                insertCmd.ExecuteNonQuery();

                Response.Write("<script>alert('Registeration is Successful')</script>");
                Response.Redirect("Login.aspx");
                
            }
            con.Close();
        }
    }
}