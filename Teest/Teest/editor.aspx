<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="editor.aspx.cs" Inherits="Teest.editor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">

<article class="info">
					<br/>
					<h1>Generel Information:</h1>
					<table style="width: 100%; text-align: left;">
					<tr>
						<th>Fornavn:</th>
						<th>Efternavn:</th>
					</tr>
					<tr>
						<td><asp:TextBox class="edit" ID="txtFornavn" runat="server"></asp:TextBox></td>
						<td><asp:TextBox class="edit" ID="txtFødeby" runat="server"></asp:TextBox></td>
					</tr>
					<tr>
						<th>Fødselsdato:</th>
						<th>Dødsdato:</th>
					</tr>
					<tr>
						<td><asp:TextBox class="edit" ID="txtEfternavn" runat="server"></asp:TextBox></td>
						<td><asp:TextBox class="edit" ID="txtSidstebopæl" runat="server"></asp:TextBox></td>
					</tr>
					<tr>
						<th>Fødeby:</th>
						<th>Sidste Bopæl:</th>
					</tr>
					<tr>
						<td><asp:TextBox class="edit" ID="txtFødselsdato" runat="server"></asp:TextBox></td>
						<td><asp:TextBox class="edit" ID="txtStilling" runat="server"></asp:TextBox></td>
					</tr>
					<tr>
						<th>Stilling:</th>
						<th>Nærmeste pårørende:</th>
					</tr>
					<tr>
						<td><asp:TextBox class="edit" ID="txtDødsdato" runat="server"></asp:TextBox></td>
						<td><asp:TextBox class="edit" ID="txtNærmeste" runat="server"></asp:TextBox></td>
					</tr>
                    <tr>
						<th>Facebook Link:</th>
                        <th>MyHeritage Link:</th>
					</tr>
                    <tr>
						<td><asp:TextBox class="edit" ID="TextBox3" runat="server"/></td>
                        <td><asp:TextBox class="edit" ID="TextBox4" runat="server"/></td>
					</tr>
					</table>
					<br/>
            </article>

            <aside class="img" style="float: right; padding: 1vh 1vh 1vh 1vh; height: 43vh; width:25vw;">

                <div style="border: dashed; width: 99%; height: 98%;">
                <center>
                <br/>
                <br/>
                <h1>Profilbillede:</h1>
                <br />
                <br />
                <p>Drag and Drog dit billede</p>
                <br />
                <br /><asp:FileUpload ID="fileUploadProfile" runat="server"></asp:FileUpload>
                <br />
                <br />
                <br/>
                </center>
                <p style="margin-left: 4vw; margin-right: 4vw;">OBS: Billedet vil automatisk blive skaleret op eller ned så det passer bedst muligt i kassen.</p>
                <br />
                <p style="margin-left: 4vw; margin-right: 4vw;">Du kan bruge: jpg, jpeg og png.</p>
                </div>
            </aside>

            <section class="bio">
				    <br />
					<h1>Biografi:</h1>
                    <asp:TextBox id="txtaBiografi" runat="server" TextMode="MultiLine" width="100%" rows="20"></asp:TextBox>
					<br/>
					<h3>Uddannelse:</h3>
                    <asp:TextBox id="txtaUddannelse" runat="server" TextMode="MultiLine" width="100%" rows="20"></asp:TextBox>
					<br>
					<h3>Karriere:</h3>
                    <asp:TextBox id="txtaKarriere" runat="server" TextMode="MultiLine" width="100%" rows="20"></asp:TextBox>
					<br/>
					<h3>Bedrifter:</h3>
                    <asp:TextBox id="txtaBedrifter" runat="server" TextMode="MultiLine" width="100%" rows="20"></asp:TextBox>
            </section>

			<section class="relationer">
			    <br />
				<h1>Relationer:</h1>
				<br>
                <h2>Tilføj familiemedlemer:</h2>
                <table>
                    <tr>
                    <td>Titel:</td>
                    <td><asp:TextBox ID="TextBox1" runat="server" Class="small"></asp:TextBox></td>
                    <td>Navn:</td>
                    <td><asp:TextBox ID="TextBox2" runat="server" Class="small"></asp:TextBox></td>
                    </tr>
                    <tr>
                    <td>Årstal:</td>
                    <td><asp:TextBox ID="TextBox5" runat="server" Class="small"></asp:TextBox></td>
                    <td>Link:</td>
                    <td><asp:TextBox ID="TextBox6" runat="server" Class="small"></asp:TextBox></td>
                    </tr>
                </table>
                <center><asp:Button ID="btnRelationer" runat="server" Class="button" Text="Tilføj" /></center>
                <asp:ListView ID="listRelationer" runat="server"></asp:ListView>
				<br/>
				<br/>
			</section>

			<aside class="timeline">
			    <br />
				<h1>Tidslinje:</h1>
				<br/>
                <h2>Tilføj punkter:</h2>
                <table>
                    <tr>
                    <td>Tekst:</td>
                    <td><asp:TextBox ID="txtT" runat="server" Class="small"></asp:TextBox></td>
                    <td>Årstal:</td>
                    <td><asp:TextBox ID="txtY" runat="server" Class="small"></asp:TextBox></td>
                    </tr>
                    <tr>
                    <td>Besk.:</td>
                    <td colspan="4"><asp:TextBox ID="txtBeskrivelse" runat="server" Class="edit" Style="width: 25.5vw;"></asp:TextBox></td>
                    </tr>
                </table>
                <center><asp:Button ID="btnTidslinje" runat="server" Class="button" Text="Tilføj" /></center>
                <asp:ListView ID="ListView1" runat="server"></asp:ListView>
				<br/>
				<br/>
			</aside>

	<section class="galleri" id="drop">
		<center><h1>Galleri:</h1></center>



  </table>
        
		<br>
	</section>

  <section class="thumbnails">
      <br />
      <br />
    <center><asp:Button ID="btnAfslutRedigering" runat="server" Class="button" Text="Gem Ændringer" /></center>
    <br />
  </section>
</asp:Content>