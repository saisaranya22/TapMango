using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication6.DAL_Classes;
using System.Threading;
using System.Timers;

namespace WebApplication6
{
    public partial class HomeR2 : System.Web.UI.Page
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
            Plant plant = new Plant();
            string status1 = "";
            string status2 = "";
            string status3 = "";
            string status4 = "";
            string status5 = "";
            status1 = plant.Update("Plant1");
            status2 = plant.Update("Plant2");
            status3 = plant.Update("Plant3");
            status4 = plant.Update("Plant4");
            status5 = plant.Update("Plant5");

            Plant1Status.Text = status1;
            Plant2Status.Text = status2;
            Plant3Status.Text = status3;
            Plant4Status.Text = status4;
            Plant5Status.Text = status5;
            Label1.Visible = false;
            Label2.Visible = false;
            Label3.Visible = false;
            Label4.Visible = false;
            Label5.Visible = false;

        }

        protected void Plant1Start_Click(object sender, EventArgs e)
        {          
            Plant plant = new Plant();
            Response.Write("<script>alert('Watering Plant 1 wait for 10 seconds')</script>");
            Thread.Sleep(10000);
            plant.StatusUpdate("Plant1");
            Plant1Status.Text = plant.Update("Plant1");         
            Label1.Visible = true;
            Label1.Text = "Finished";
            
           
           
        }

        protected void Plant2Start_Click(object sender, EventArgs e)
        {
            Plant plant = new Plant();
            Response.Write("<script>alert('Watering Plant 2 wait for 10 seconds')</script>");
            Thread.Sleep(10000);
            plant.StatusUpdate("Plant2");
            Plant2Status.Text = plant.Update("Plant2");
            Label2.Visible = true;
            Label2.Text = "Finished";
        }

        protected void Plant3Start_Click(object sender, EventArgs e)
        {
            Plant plant = new Plant();
            Response.Write("<script>alert('Watering Plant 3 wait for 10 seconds')</script>");
            Thread.Sleep(10000);
            plant.StatusUpdate("Plant3");
            Plant3Status.Text = plant.Update("Plant3");
            Label3.Visible = true;
            Label3.Text = "Finished";
        }

        protected void Plant4Start_Click(object sender, EventArgs e)
        {
            Plant plant = new Plant();
            Response.Write("<script>alert('Watering Plant 4 wait for 10 seconds')</script>");
            Thread.Sleep(10000);
            plant.StatusUpdate("Plant4");
            Plant4Status.Text = plant.Update("Plant4");
            Label4.Visible = true;
            Label4.Text = "Finished";
        }

        protected void Plant5Start_Click(object sender, EventArgs e)
        {
            Plant plant = new Plant();
            Response.Write("<script>alert('Watering Plant 5 wait for 10 seconds')</script>");
            Thread.Sleep(10000);
            plant.StatusUpdate("Plant5");
            Plant5Status.Text = plant.Update("Plant5");
            Label5.Visible = true;
            Label5.Text = "Finished";
        }

        protected void Plant1Stop_Click(object sender, EventArgs e)
        {
           
            Label1.Visible = true;
            Label1.Text = "Stopped";

        }

        protected void Plant2Stop_Click(object sender, EventArgs e)
        {
            Label2.Visible = true;
            Label2.Text = "Stopped";

        }

        protected void Plant3Stop_Click(object sender, EventArgs e)
        {
            Label3.Visible = true;
            Label3.Text = "Stopped";
        }

        protected void Plant4Stop_Click(object sender, EventArgs e)
        {
            Label4.Visible = true;
            Label4.Text = "Stopped";
        }

        protected void Plant5Stop_Click(object sender, EventArgs e)
        {
            Label5.Visible = true;
            Label5.Text = "Stopped";
        }
    }
    }