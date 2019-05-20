using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Teest
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnPayment_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataSource SqlDataSource1 = new SqlDataSource();
                SqlDataSource1.ID = "SqlDataSource1";
                this.Page.Controls.Add(SqlDataSource1);
                SqlDataSource1.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["memorialtagConnectionString"].ConnectionString;
                SqlDataSource1.SelectCommand = "Select Email FROM Kunde";
                DataView dv = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
                if (dv[0]["Email"].ToString().Trim().Equals(txtEmail.Text)) { labError.Visible = true; labError.Text = "Den angive email eksisterer allerede."; }
                else
                {
                    SqlDataSource1.InsertCommand = "INSERT INTO [Kunde] (Fornavn, Efternavn, Telefon, Email, Password, Land, [By], Postnr, Vej) VALUES (@Fornavn, @Efternavn, @Telefon, @Email, @Password, @Land, @By, @Postnr, @Vej)";
                    SqlDataSource1.InsertParameters.Add("Fornavn", txtFornavn.Text);
                    SqlDataSource1.InsertParameters.Add("Efternavn", txtEfternavn.Text);
                    SqlDataSource1.InsertParameters.Add("Telefon", txtTelefon.Text);
                    SqlDataSource1.InsertParameters.Add("Email", txtEmail.Text);
                    SqlDataSource1.InsertParameters.Add("Password", txtPassword.Text);
                    SqlDataSource1.InsertParameters.Add("Land", txtLand.Text);
                    SqlDataSource1.InsertParameters.Add("By", txtBy.Text);
                    SqlDataSource1.InsertParameters.Add("Postnr", txtPostnr.Text);
                    SqlDataSource1.InsertParameters.Add("Vej", txtVej.Text);
                    SqlDataSource1.Insert();
                }
            }
            catch (Exception Ex)
            {
                labError.Visible = true;
            }
        }
    }
}