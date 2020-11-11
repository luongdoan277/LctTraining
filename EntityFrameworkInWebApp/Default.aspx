<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EntityFrameworkInWebApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>LCT Training</h1>
        <p>Add By Name:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
        </p>
        <p>&nbsp;</p>
        <p style="text-decoration: underline"><strong>RESULT:</strong></p>
        <p>Id:
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
        <p>Training Name:
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </p>
        <p>Training Provider:<asp:Label ID="Label3" runat="server"></asp:Label>
        </p>
        <p class="lead">&nbsp;</p>
    </div>

    </asp:Content>
