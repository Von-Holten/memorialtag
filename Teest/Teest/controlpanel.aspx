<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="controlpanel.aspx.cs" Inherits="Teest.controlpanel" MaintainScrollPositionOnPostback="true" %>

<%-- Vores indhold starter ved dette tag, head, header og footer defineres i site.master filen --%>
<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">
    
    <%-- Vores artikel der indeholder informationer om brugeren der er logget ind --%>
    <article>
        					<br/>
                        <div class="div">
                        <h1><asp:Label ID="labUserOverskrift" runat="server" Text=""></asp:Label></h1>
                        <p></p>
                        <h2><asp:Label ID="kundeID" runat="server" Text="Label" Style="width: 25%;"/></h2>
                            </div>
					<br/>
					<table style="width: 100%; text-align: left;">
					<tr>
						<th>Fornavn:</th>
						<th>Efternavn:</th>
					</tr>
					<tr>
						<td><asp:Label ID="labFornavn" runat="server" Text="Label"></asp:Label></td>
						<td><asp:Label ID="labEfternavn" runat="server" Text="Label"></asp:Label></td>
					</tr>
					<tr>
						<th>Telefon:</th>
						<th>Email:</th>
					</tr>
					<tr>
						<td><asp:Label ID="labTelefon" runat="server" Text="Label"></asp:Label></td>
						<td><asp:Label ID="labEmail" runat="server" Text="Label"></asp:Label></td>
					</tr>
					<tr>
						<th>Land:</th>
						<th>By:</th>
					</tr>
					<tr>
						<td><asp:Label ID="labLand" runat="server" Text="Label"></asp:Label></td>
						<td><asp:Label ID="labBy" runat="server" Text="Label"></asp:Label></td>
					</tr>
                    <tr>
						<th>Postnr:</th>
						<th>Vej:</th>
					</tr>
                    <tr>
						<td><asp:Label ID="labPostnr" runat="server" Text="Label"></asp:Label></td>
						<td><asp:Label ID="labVej" runat="server" Text="Label"></asp:Label></td>
					</tr>
					</table>
					<br/>
    </article>

        <%-- Vores sektion der viser de memorial tags der er tilknytter brugeren med et listview --%>
        <section>
            <br />
            <h1>Memorial Tags:</h1>
            <asp:ListView ID="ListView1" runat="server"></asp:ListView>
            <br />

        </section>
</asp:Content>