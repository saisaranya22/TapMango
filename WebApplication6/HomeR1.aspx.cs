using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication6.DAL_Classes;

namespace WebApplication6
{
    public partial class HomeR1 : System.Web.UI.Page
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





        }
    }
}