using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modal;
using Bal;
using System.Data.SqlClient;
using System.Data;

namespace LoginPageWithData
{
    public partial class LoginPage : System.Web.UI.Page
    {
        ModalClass1 mod = new ModalClass1();
        BalClass1 bal = new BalClass1();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            Session["UserId"] = TextBox1.Text.ToString();

            int UserId =Convert.ToInt32( TextBox1.Text);
            string Passwords = TextBox2.Text;
            DataTable dt = new DataTable();

            

            // Response.Redirect("Details.aspx");

            if (bal.LoginDeatils(UserId, Passwords))
            {
                Response.Redirect("Details.aspx");
            }
            else
            {
                Response.Write("<script>alert('Invalid User...!')</script>");
            }

            

                //if (LoginDeatils(UserName, Passwords))
                //{
                //    Response.Redirect("Details.aspx");
                //}
                //else
                //{
                //    Response.Write("<script>alert('Invalid User...!')</script>");
                //}

            }
    }
}

