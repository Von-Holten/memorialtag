<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="Teest.register" MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" Runat="Server">

    <article id="main" class="main">
        <br />
        <div class="div">
            <h3>1. Bestil</h3>
            <h3>2. Log ind</h3>
            <h3>3. Udfyld</h3>
        </div>

        <div class="div">
            <img src="./images/order.jpg" alt="Billede"  style="width: 20vw; height: 30vh;"/>
            <img src="./images/login.jpg" alt="Billede"  style="width: 20vw; height: 30vh;"/>
            <img src="./images/edit.png" alt="Billede"  style="width: 20vw; height: 30vh;"/>
        </div>
        <div class="div">
            <p>Tekst her</p>
            <p>Tekst her</p>
            <p>Tekst her</p>
        </div>

    </article>

		<div class="subMain">	
			<section action="#" method="post" class="register">
                <center><br><h2 >Bestil et Memorial Tag:</h2>
				<input placeholder="Fornavn" name="name" type="text" required="">
				<input placeholder="Efternavn" name="name" type="text" required="">
				<input placeholder="Telefon" name="phone"type="text" required="">
				<input placeholder="Email" name="email" type="email" required="">
				<input  placeholder="Kodeord" name="Password" type="password" required="">
                <input  placeholder="Gentag kodeord" name="Password"type="password" required=""><br>
                <input  placeholder="Land" name="Country"type="text" required="" style="width: 11.5vw;">
                <input  placeholder="By" name="City"type="text" required="" style="width: 15vw;">
                <input  placeholder="Postnr" name="zip"type="text" required="" style="width: 3vw;">
                <input  placeholder="Vej" name="address"type="text" required="" style="width: 23.5vw;"><br>
			    <asp:Button Class="button" ID="btnPayment" runat="server" Text="Udfør" OnClick="btnPayment_Click"/></center>
			</section>
		</div>
    </article>

    <form>
    </form>

    <aside>
    </aside>
</asp:Content>