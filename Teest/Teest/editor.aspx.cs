using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using AjaxControlToolkit;

namespace Teest
{
    public partial class editor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                SqlDataSource SqlDataSource1 = new SqlDataSource();
                SqlDataSource1.ID = "SqlDataSource1";
                this.Page.Controls.Add(SqlDataSource1);
                SqlDataSource1.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["memorialtagConnectionString"].ConnectionString;
                SqlDataSource1.SelectCommand = "SELECT [Fornavn], [Efternavn], [Fødselsdato], [Dødsdato], [Fødeby], [SidsteBopæl], [Stilling], [NærmestePårørende], [FacebookLink], [MyHeritageLink], [Biografi], [Uddannelse], [Karriere], [Bedrifter] FROM [memorialtag].[dbo].[Grav] WHERE (GravID = '1')";

                try
                {
                    DataView test = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
                    txtFornavn.Text = test.Table.Rows[0][0].ToString();
                    txtEfternavn.Text = test.Table.Rows[0][1].ToString();
                    DateTime føsdag = DateTime.Parse(test.Table.Rows[0][2].ToString());
                    txtFødselsdato.Text = føsdag.ToShortDateString();
                    DateTime dødsdato = DateTime.Parse(test.Table.Rows[0][3].ToString());
                    txtDødsdato.Text = dødsdato.ToShortDateString();
                    txtFødeby.Text = test.Table.Rows[0][4].ToString();
                    txtSidsteBopæl.Text = test.Table.Rows[0][5].ToString();
                    txtStilling.Text = test.Table.Rows[0][6].ToString();
                    txtNærmestePårørende.Text = test.Table.Rows[0][7].ToString();
                    txtFacebookLink.Text = test.Table.Rows[0][8].ToString();
                    txtMyHeritageLink.Text = test.Table.Rows[0][9].ToString();
                    txtaBiografi.Text = test.Table.Rows[0][10].ToString();
                    txtaUddannelse.Text = test.Table.Rows[0][11].ToString();
                    txtaKarriere.Text = test.Table.Rows[0][12].ToString();
                    txtaBedrifter.Text = test.Table.Rows[0][13].ToString();
                }
                catch
                {
                    labError.Visible = true;
                    labError.Text = "Der er sket en fejl, prøv venligst igen.";
                }
            }
            
        }

            protected void btnAfslutRedigering_Click(object sender, EventArgs e)
        {
            if(fileUploadProfile.HasFile)
            {
                try
                {
                    int filesize = 5000 * 1024;
                    if (fileUploadProfile.PostedFile.ContentType == "image/jpeg" || fileUploadProfile.PostedFile.ContentType == "image/png")
                    {
                        if (fileUploadProfile.PostedFile.ContentLength < filesize)
                        {
                            string filenameProfile = Path.GetFileName(fileUploadProfile.FileName);
                            fileUploadProfile.SaveAs(Server.MapPath("./Uploads/1/profile.jpg"));
                        }
                        else
                        {
                            StatusLabelProfile.Text = "Fejl: Billedet skal være under 4 MB!";
                            StatusLabelProfile.Visible = true;
                        }
                    }
                    else
                    {
                        StatusLabelProfile.Text = "Fejl: Billedet skal være jpg, jpeg eller png!";
                        StatusLabelProfile.Visible = true;
                    }
                }
                catch(Exception ex)
                {
                    StatusLabelProfile.Visible = true;
                    StatusLabelProfile.Text = "Fejl:" + ex.Message;
                }

            }

            try
            {
                SqlDataSource SqlDataSource2 = new SqlDataSource();
                SqlDataSource2.ID = "SqlDataSource2";
                this.Page.Controls.Add(SqlDataSource2);
                SqlDataSource2.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["memorialtagConnectionString"].ConnectionString;
                //SqlDataSource2.InsertCommand = "INSERT INTO [Grav] ([Fornavn], [Efternavn], [Fødselsdato], [Dødsdato], [Fødeby], [SidsteBopæl], [Stilling], [NærmestePårørende], [FacebookLink], [MyHeritageLink], [Biografi], [Uddannelse], [Karriere], [Bedrifter]) VALUES (@KirkeID, @Fornavn, @Efternavn, @Fødselsdato, @Dødsdato, @Fødeby, @SidsteBopæl, @Stilling, @NærmestePårørende, @FacebookLink, @MyHeritageLink, @Biografi, @Uddannelse, @Karriere, @Bedrifter)";
                //SqlDataSource2.InsertParameters.Add("Fornavn", txtFornavn.Text);
                //SqlDataSource2.InsertParameters.Add("Efternavn", txtEfternavn.Text);
                //SqlDataSource2.InsertParameters.Add("Fødselsdato", txtFødselsdato.Text);
                //SqlDataSource2.InsertParameters.Add("Dødsdato", txtDødsdato.Text);
                //SqlDataSource2.InsertParameters.Add("Fødeby", txtFødeby.Text);
                //SqlDataSource2.InsertParameters.Add("SidsteBopæl", txtSidsteBopæl.Text);
                //SqlDataSource2.InsertParameters.Add("Stilling", txtStilling.Text);
                //SqlDataSource2.InsertParameters.Add("NærmestePårørende", txtNærmestePårørende.Text);
                //SqlDataSource2.InsertParameters.Add("FacebookLink", txtFacebookLink.Text);
                //SqlDataSource2.InsertParameters.Add("MyHeritageLink", txtMyHeritageLink.Text);
                //SqlDataSource2.InsertParameters.Add("Biografi", txtaBiografi.Text);
                //SqlDataSource2.InsertParameters.Add("Uddannelse", txtaUddannelse.Text);
                //SqlDataSource2.InsertParameters.Add("Karriere", txtaKarriere.Text);
                //SqlDataSource2.InsertParameters.Add("Bedrifter", txtaBedrifter.Text);
                //SqlDataSource2.Insert();
                SqlDataSource2.UpdateCommand = @"UPDATE [memorialtag].[dbo].[Grav] SET [Fornavn] = @Fornavn, [Efternavn] = @Efternavn, [Fødselsdato] = @Fødselsdato, [Dødsdato] = @Dødsdato, [Fødeby] = @Fødeby, [SidsteBopæl] = @SidsteBopæl, [Stilling] = @Stilling, [NærmestePårørende] = @NærmestePårørende, [FacebookLink] = @FacebookLink, [MyHeritageLink] = @MyHeritageLink, [Biografi] = @Biografi, [Uddannelse] = @Uddannelse, [Karriere] = @Karriere, [Bedrifter] = @Bedrifter WHERE ([GravID] = 1)";
                SqlDataSource2.UpdateParameters.Add("Fornavn", txtFornavn.Text);
                SqlDataSource2.UpdateParameters.Add("Efternavn", txtEfternavn.Text);
                SqlDataSource2.UpdateParameters.Add("Fødselsdato", txtFødselsdato.Text);
                SqlDataSource2.UpdateParameters.Add("Dødsdato", txtDødsdato.Text);
                SqlDataSource2.UpdateParameters.Add("Fødeby", txtFødeby.Text);
                SqlDataSource2.UpdateParameters.Add("SidsteBopæl", txtSidsteBopæl.Text);
                SqlDataSource2.UpdateParameters.Add("Stilling", txtStilling.Text);
                SqlDataSource2.UpdateParameters.Add("NærmestePårørende", txtNærmestePårørende.Text);
                SqlDataSource2.UpdateParameters.Add("FacebookLink", txtFacebookLink.Text);
                SqlDataSource2.UpdateParameters.Add("MyHeritageLink", txtMyHeritageLink.Text);
                SqlDataSource2.UpdateParameters.Add("Biografi", txtaBiografi.Text);
                SqlDataSource2.UpdateParameters.Add("Uddannelse", txtaUddannelse.Text);
                SqlDataSource2.UpdateParameters.Add("Karriere", txtaKarriere.Text);
                SqlDataSource2.UpdateParameters.Add("Bedrifter", txtaBedrifter.Text);
                SqlDataSource2.Update();
            }
            catch(Exception ex)
            {
                labError.Visible = true;
                //labError.Text = ex.ToString();
                labError.Text = "Der er desværre sket en fejl!";
            }
        }

        protected void AjaxFileUpload1_UploadComplete(object sender, AjaxFileUploadEventArgs e)
        {
            string filename = e.FileName;
            if (filename.Contains(".jpg") || filename.Contains(".jpeg") || filename.Contains(".png"))
            {
                if (!(System.IO.File.Exists(Server.MapPath("/Uploads/1/pic1.jpg")))) { AjaxFileUpload1.SaveAs(Server.MapPath("./Uploads/1/pic1.jpg")); }
                else if (!(System.IO.File.Exists(Server.MapPath("/Uploads/1/pic2.jpg")))) { AjaxFileUpload1.SaveAs(Server.MapPath("./Uploads/1/pic2.jpg")); }
                else if (!(System.IO.File.Exists(Server.MapPath("/Uploads/1/pic3.jpg")))) { AjaxFileUpload1.SaveAs(Server.MapPath("./Uploads/1/pic3.jpg")); }
                else if (!(System.IO.File.Exists(Server.MapPath("/Uploads/1/pic4.jpg")))) { AjaxFileUpload1.SaveAs(Server.MapPath("./Uploads/1/pic4.jpg")); }
                else if (!(System.IO.File.Exists(Server.MapPath("/Uploads/1/pic5.jpg")))) { AjaxFileUpload1.SaveAs(Server.MapPath("./Uploads/1/pic5.jpg")); }
                else if (!(System.IO.File.Exists(Server.MapPath("/Uploads/1/pic6.jpg")))) { AjaxFileUpload1.SaveAs(Server.MapPath("./Uploads/1/pic6.jpg")); }
                else if (!(System.IO.File.Exists(Server.MapPath("/Uploads/1/pic7.jpg")))) { AjaxFileUpload1.SaveAs(Server.MapPath("./Uploads/1/pic7.jpg")); }
                else if (!(System.IO.File.Exists(Server.MapPath("/Uploads/1/pic8.jpg")))) { AjaxFileUpload1.SaveAs(Server.MapPath("./Uploads/1/pic8.jpg")); }
                else { labError.Text = "Du må max uploade 8 billeder i alt!"; }
            }
            else if (filename.Contains(".mp4")) { if (!(System.IO.File.Exists(Server.MapPath("/Uploads/1/vid1.mp4"))))
                { AjaxFileUpload1.SaveAs(Server.MapPath("./Uploads/1/vid1.mp4"));}
                else { labError.Text = "Du må max uploade 1 video!"; }
            } 
            else if (filename.Contains(".mp3")) { if (!(System.IO.File.Exists(Server.MapPath("/Uploads/1/aud1.mp3"))))
                { AjaxFileUpload1.SaveAs(Server.MapPath("./Uploads/1/aud1.mp3")); }
                else { labError.Text = "Du må max uploade 1 lydfil!"; }
            }
        }
    }
}