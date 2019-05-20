using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Teest
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=memorialtag;Integrated Security=True;"))
            {
                sqlCon.Open();
                string query = "SELECT COUNT(1) FROM Kunde WHERE Email=@Username AND Password=@Password";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 1)
                {
                    Session["Username"] = txtUsername.Text.Trim();
                    Response.Redirect("./controlpanel.aspx");
                }
                else { labelLoginError.Visible = true; }
            }
        }

        protected void btnBestil_Click(object sender, EventArgs e)
        {
            Response.Redirect("./register.aspx");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Session["Værdi"] = Search.Text;
            Response.Redirect("./search.aspx");
        }
    }
}