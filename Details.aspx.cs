using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginPageWithData
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int UserId = Convert.ToInt32(Session["UserId"]);

            string str = @"Data Source=SURAJ\SQLEXPRESS; Initial Catalog=Client_DB;Integrated Security=True";
            SqlConnection sc = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("DetailEmp", sc);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UserId", UserId);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            dt = ds.Tables[0];
           

            GridView1.DataSource = dt;
            GridView1.DataBind();

        }

        //protected void Button1_Click(object sender, EventArgs e)
        //{

        //    GridView1.DataSource = Session["GetData"].ToString();
        //    GridView1.DataBind();
        //}
    }
}