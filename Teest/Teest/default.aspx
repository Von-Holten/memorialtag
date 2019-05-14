<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Teest._default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" Runat="Server">


    <article class="main">
        <br />
        <div class="div">
            <h3>NFC</h3>
            <h3>QR</h3>
            <h3>Browser</h3>
        </div>

        <div class="div">
            <img src="./images/nfc.jpg" alt="Billede" style="width: 20vw; height: 30vh;"/>
            <img src="./images/qr.jpg" alt="Billede" style="width: 20vw; height: 30vh;"/>
            <img src="./images/browser.jpg" alt="Billede" style="width: 20vw; height: 30vh;"/>
        </div>
        <div class="div">
            <p>Tekst her</p>
            <p>Tekst her</p>
            <p>Tekst her</p>
        </div>
    </article>

    <article id="soeg" class="search">
        <div class="div">
        <center>
        <input type="text" name="Search" placeholder="Søg f.eks. på ID, Navn, Årstal, By eller Kirkegård..." id="Search" style="width: 40vw; height: 1vh;" class="wrapper" autofocus>
        <asp:Button ID="btnSearch" runat="server" Text="Søg" style="margin-left: -28vh;" OnClick="btnSearch_Click" Class="button"/></center>
        </div>
    </article>

    <section class="login" runat="server">
        <center><h2>Log ind</h2></center>
        <p></p>
        <label for="email"><b>E-Mail:</b></label>
        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        <label for="password"><b>Kodeord:</b></label>
        <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
        <div class="div">
            <p>Husk mig:<input type="checkbox" name="remember" id="remember" checked="checked" /></p>
            <asp:Button ID="btnLogin" runat="server" Text="Godkend" OnClick="btnLogin_Click" Class="button"/>
            <p>Glemt <a href="#">kodeord?</a></p>
        </div>
        <center><asp:Label ID="labelLoginError" runat="server" Text="Angiv veligst korrekt brugernavn og kode!" Visible="false" ForeColor="#CC0000"></asp:Label></center>
    </section>

    <aside class="buy" runat="server">
        <center><h2>Bestil et Memorial Tag</h2></center>
        <p></p>
        <label><b>Hvad er det?</b></label>
        <ul>
            <li>Et jordspyd med NFC og QR tag</li>
            <li>En eller flere personlige mindesider</li>
            <li>Et efterliv i skyen til dine kære</li>
        </ul>
        <center><h3>Fra 299,95 kr.-</h3></center>
        <center><asp:Button runat="server" Class="button" text="Bestil Memorial Tag" ID="btnBestil" OnClick="btnBestil_Click"/></center>
    </aside> 

</asp:Content>