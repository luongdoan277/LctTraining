<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CosmosDBWebApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>LCT Training Cosmos DB</h1>
        <p>Query for a database:</p>
        <p>Database Id:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Check" />
        </p>
        <p>&nbsp;</p>
        <p style="text-decoration: underline"><strong>Result:</strong></p>
        <p>Database
            <asp:Label ID="Label1" runat="server"></asp:Label>
&nbsp;Exists</p>
    </div>

    </asp:Content>
