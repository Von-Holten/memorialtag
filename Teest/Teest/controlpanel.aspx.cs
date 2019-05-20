using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Teest
{
    public partial class controlpanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string User = Convert.ToString(Session["Username"]);
            labUserOverskrift.Text = "Hej, " + User;

            SqlDataSource SqlDataSource1 = new SqlDataSource();
            SqlDataSource1.ID = "SqlDataSource1";
            this.Page.Controls.Add(SqlDataSource1);
            SqlDataSource1.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["memorialtagConnectionString"].ConnectionString;
            SqlDataSource1.SelectCommand = "SELECT [Fornavn], [Efternavn], [Telefon], [Email], [Land], [By], [Postnr], [Vej], [KundeID] FROM [Kunde] WHERE ([Email] = '" + User + "')";

            try
            {
                DataView test = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
                labFornavn.Text = test.Table.Rows[0][0].ToString();
                labEfternavn.Text = test.Table.Rows[0][1].ToString();
                labTelefon.Text = test.Table.Rows[0][2].ToString();
                labEmail.Text = test.Table.Rows[0][3].ToString();
                labLand.Text = test.Table.Rows[0][4].ToString();
                labBy.Text = test.Table.Rows[0][5].ToString();
                labPostnr.Text = test.Table.Rows[0][6].ToString();
                labVej.Text = test.Table.Rows[0][7].ToString();
                kundeID.Text = "Kunde ID: " + test.Table.Rows[0][8].ToString();


                DataTable dt = test.ToTable();
                
            }
            catch
            {
                Response.Redirect("./template.aspx?id=1");
            }
        

        }

    }
}