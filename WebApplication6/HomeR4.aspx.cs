using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication6.DAL_Classes;
using System.Timers;

namespace WebApplication6
{
    public partial class HomeR4 : System.Web.UI.Page
    {
        Plant plant = new Plant();
        private System.Timers.Timer timer = new System.Timers.Timer(10000) { AutoReset = false };

        protected void Page_Load(object sender, EventArgs e)
        {
           
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

        }


        protected async void Plant1Start_Click(object sender, EventArgs e)
        {
            DateTime oDate = Convert.ToDateTime(plant.Update("Plant1"));
            var diff = DateTime.Now.Subtract(oDate);
            if(diff.Seconds<30)
            {
                Response.Write("<script>alert('Plants cannot be watered again within 30 seconds of watering')</script>");
                return;
            }
            else
            {
                plant.StatusUpdate("Plant1");
                Plant1Status.Text = plant.Update("Plant1");
                await MyMethodAsync(sender, e);
            }                                      
        }
     
     

        protected async void Plant2Start_Click(object sender, EventArgs e)
        {
            DateTime oDate = Convert.ToDateTime(plant.Update("Plant2"));
            var diff = DateTime.Now.Subtract(oDate);
            if (diff.Seconds < 30)
            {
                Response.Write("<script>alert('Plants cannot be watered again within 30 seconds of watering')</script>");
                return;
            }
            else
            {
                plant.StatusUpdate("Plant2");
                Plant2Status.Text = plant.Update("Plant2");
                await MyMethodAsync(sender, e);
            }
            


        }
        protected async void Plant3Start_Click(object sender, EventArgs e)
        {
            DateTime oDate = Convert.ToDateTime(plant.Update("Plant3"));
            var diff = DateTime.Now.Subtract(oDate);
            if (diff.Seconds < 30)
            {
                Response.Write("<script>alert('Plants cannot be watered again within 30 seconds of watering')</script>");
                return;
            }
            else
            {
                plant.StatusUpdate("Plant3");
                Plant3Status.Text = plant.Update("Plant3");
                await MyMethodAsync(sender, e);
            }

            


        }
        protected async void Plant4Start_Click(object sender, EventArgs e)
        {
            DateTime oDate = Convert.ToDateTime(plant.Update("Plant4"));
            var diff = DateTime.Now.Subtract(oDate);
            if (diff.Seconds < 30)
            {
                Response.Write("<script>alert('Plants cannot be watered again within 30 seconds of watering')</script>");
                return;
            }
            else
            {
                plant.StatusUpdate("Plant4");
                Plant4Status.Text = plant.Update("Plant4");
                await MyMethodAsync(sender, e);
            }
          


        }
        protected async void Plant5Start_Click(object sender, EventArgs e)
        {
            DateTime oDate = Convert.ToDateTime(plant.Update("Plant5"));
            var diff = DateTime.Now.Subtract(oDate);
            if (diff.Seconds < 30)
            {
                Response.Write("<script>alert('Plants cannot be watered again within 30 seconds of watering')</script>");
                return;
            }
            else
            {
                plant.StatusUpdate("Plant5");
                Plant5Status.Text = plant.Update("Plant5");
                await MyMethodAsync(sender, e);
            }
          


        }
        private async Task MyMethodAsync(object sender, EventArgs e)
        {
            await Task.Delay(10000);

        }
     

    
    }
}