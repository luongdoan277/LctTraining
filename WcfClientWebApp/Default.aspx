<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WcfClientWebApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Message from WCF client Application: </h1>
        <p>
            <asp:TextBox ID="MessageTextBox" runat="server"></asp:TextBox>
            <asp:Button ID="ShowButton" runat="server" OnClick="ShowButton_Click" Text="Show" />
            Message:
            <asp:Label ID="MessageLabelFromService" runat="server"></asp:Label>
        </p>
    </div>

    <div class="row">
    </div>

</asp:Content>
