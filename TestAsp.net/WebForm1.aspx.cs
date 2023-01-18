using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestAsp.net
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

       
        protected void Button2_Click1(object sender, EventArgs e)
        {
            String mainconn = ConfigurationManager.ConnectionStrings["MyCon"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "Insert into [dbo].[Position] (cPositionCode,vDescription,iBudgetedStrength,siYear,iCurrentStrength) values (@PositionCode,@Description,@BudgetedStrength,@Year,@CurrentStrength)";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);



            sqlcomm.Parameters.AddWithValue("@PositionCode", TxtPositioncode.Text);
            sqlcomm.Parameters.AddWithValue("@Description", TextBox1.Text);
            sqlcomm.Parameters.AddWithValue("@BudgetedStrength", TextBox2.Text);
            sqlcomm.Parameters.AddWithValue("@Year", TextBox3.Text);
            sqlcomm.Parameters.AddWithValue("@CurrentStrength", TextBox4.Text);



            sqlconn.Open();
            sqlcomm.ExecuteNonQuery();



            sqlconn.Close();

        }
    }
}

       