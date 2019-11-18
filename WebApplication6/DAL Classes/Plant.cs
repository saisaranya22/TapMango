using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication6.DAL_Classes
{
    public class Plant
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
        public void Insert(String PlantName,String Status)
        {
            SqlConnection con = new SqlConnection(conn.ConnectionString);
            con.Open();
            string insertSQL = "INSERT INTO dbo.Plants (PlantName,Status) VALUES(@plantName,@plantStatus)";
            SqlCommand insertCmd = new SqlCommand(insertSQL, con);
            insertCmd.Parameters.AddWithValue("@plantName", PlantName);
            insertCmd.Parameters.AddWithValue("@plantStatus", Status);
            insertCmd.ExecuteNonQuery();
            con.Close();
            

        }
        public string Update(string PlantName)
        {
            string selectSQL = "SELECT count(*) FROM dbo.Plants WHERE PlantName='"+PlantName+"'";
            SqlConnection con = new SqlConnection(conn.ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            string status = "";
            string dateTime = Convert.ToString(DateTime.Now);
            int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            if (temp == 1)
            {
                string plantStatus = "SELECT Status FROM dbo.Plants WHERE PlantName='" + PlantName + "'";
                SqlCommand plantStatusCmd = new SqlCommand(plantStatus, con);
                status = plantStatusCmd.ExecuteScalar().ToString().Trim();               
            }
            else
            {
                
               Insert(PlantName, dateTime);
                status = dateTime;
            }
            con.Close();
            return status;
        }
        public void StatusUpdate(string PlantName)
        {

            string insertSQL = "Update dbo.Plants SET Status='" + Convert.ToString(DateTime.Now) + "'" + " where PlantName='" + PlantName+"'";
            SqlConnection con = new SqlConnection(conn.ConnectionString);
            con.Open();
            SqlCommand insertCmd = new SqlCommand(insertSQL, con);
            insertCmd.ExecuteNonQuery();
            con.Close();
          
        }
        }
}