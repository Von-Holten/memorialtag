<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="template.aspx.cs" Inherits="Teest.template" MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" Runat="Server">

			    <article class="info">
					<br>
					<h1>Fulde navn på afdøde</h1>
					<table style="width: 100%; text-align: left;">
					<tr>
						<th>Fornavn:</th>
						<th>Efternavn:</th>
					</tr>
					<tr>
						<td>Tekst</td>
						<td>Tekst</td>
					</tr>
					<tr>
						<th>Fødselsdato:</th>
						<th>Dødsdato:</th>
					</tr>
					<tr>
						<td>Tekst</td>
						<td>Tekst</td>
					</tr>
					<tr>
						<th>Fødeby:</th>
						<th>Sidste Bopæl:</th>
					</tr>
					<tr>
						<td>Tekst</td>
						<td>Tekst</td>
					</tr>
					<tr>
						<th>Stilling:</th>
						<th>Nærmeste pårørende:</th>
					</tr>
					<tr>
						<td>Tekst</td>
						<td>Tekst</td>
					</tr>
					</table>
					<br>
					<p>Ikoner til f.eks. FB mindeside og My Heritage side her</p>
            </article>

	
            <aside class="img" style="float: right; background: url(./images/avatar.png); background-repeat: no-repeat; background-position: center; background-size: 100% 100%;">
			<br>

            </aside>

            <section class="bio">
				<br />
					<h1>Biografi:</h1>
					<br>
					<h3>Uddannelse:</h3>
					<br>
					<h3>Karriere:</h3>
					<br>
					<h3>Bedrifter:</h3>
            </section>

			<section class="relationer">
							<br />
					<h1>Relationer:</h1>
					<br>
					<br>
			</section>
			<aside class="timeline">
							<br />
					<h1>Tidslinje:</h1>
					<br>
					<br>
			</aside>

	<section class="galleri">
		<center><h1>Galleri:</h1></center>
		<table style="width: 100%; height: 85%">
		<tr>
		<td><a><img src="./Images/arrowleft.png" alt="Billede" style="width:8vw; height:20vh;"/></a></td>
		<td width="80%" style="background: url(./Images/imgplaceholder.png); background-repeat: no-repeat; background-position: center; background-size: 90% 90%;"></td>
		<td><a><img src="./Images/arrowright.png" alt="Billede" style="width:8vw; height:20vh;"/></a></td>
		</tr>
  </table>
		<br>
    <center><a>Billede</a> | <a>Video</a> | <a>Audio</a></center>
	</section>

  <section class="thumbnails">
    <br>
    <br>
    <center><p>Thumbnails af billeder her</p></center>
    <br>
    <br>
  </section>
    </asp:Content>