using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Teest
{
    public partial class search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Convert.ToString(Session["Værdi"]);
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("./search.aspx");
        }

    }
}