<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavBar.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="KpopZtation.View.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <br />
        <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
        <br />
        <asp:TextBox ID="emailText" runat="server"></asp:TextBox>
        <div>
            <asp:Label ID="warningEmailLabel" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>
        <br />

        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
        <br />
        <asp:TextBox ID="passwordText" runat="server"></asp:TextBox>
        <div>
            <asp:Label ID="warningPasswordLabel" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>
        <br />

        <asp:CheckBox ID="rememberMe" runat="server" />
        <asp:Label ID="Label3" runat="server" Text="Remember Me"></asp:Label>
        <br />
        <asp:Button ID="login" runat="server" Text="Log in" OnClick="login_Click"/>
        <div>
            <asp:Label ID="failLogin" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>
</asp:Content>
