using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modal;

using System.Data.SqlClient;
using System.Data;

namespace Dal
{
    public class DalClass1d
    {
        public bool  LoginDeatils (int UserId, string Passwords)
        {
           // int res = 0;
            string str = @"Data Source=SURAJ\SQLEXPRESS; Initial Catalog=Client_DB;Integrated Security=True";
            SqlConnection sc = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("LogInProc01", sc);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UserId", UserId);
            cmd.Parameters.AddWithValue("@Passwords", Passwords);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            dt = ds.Tables[0];
            

            if ((dt.Rows.Count) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

            

    }
}
