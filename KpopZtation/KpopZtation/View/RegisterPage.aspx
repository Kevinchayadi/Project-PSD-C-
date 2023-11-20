<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavBar.Master" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="KpopZtation.View.RegisterPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label> 
        <br />
        <asp:TextBox ID="nameText" runat="server"></asp:TextBox>
            <asp:Label ID="warningName" runat="server" Text="" ForeColor="Red"></asp:Label> 
        <br />

        <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label> 
        <br />
        <asp:TextBox ID="emailText" runat="server"></asp:TextBox>
        <asp:Label ID="warningEmail" runat="server" Text="" ForeColor="Red"></asp:Label> 
        <br />

        <asp:Label ID="Label3" runat="server" Text="Gender"></asp:Label>
        <br />
        <asp:RadioButtonList ID="genderRadio" runat="server">
            <asp:ListItem Value="0" Text="Male"></asp:ListItem>
            <asp:ListItem Value ="1" Text="Female"></asp:ListItem>
        </asp:RadioButtonList>
        <asp:Label ID="warningGender" runat="server" Text="" ForeColor="Red"></asp:Label> 
        <br />

        <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label> 
        <br />
        <asp:TextBox ID="addressText" runat="server"></asp:TextBox>
        <asp:Label ID="warningAddress" runat="server" Text="" ForeColor="Red"></asp:Label> 
        <br />

        <asp:Label ID="Label5" runat="server" Text="Password"></asp:Label>
        <br />
        <asp:TextBox ID="passwordText" runat="server"></asp:TextBox>
        <asp:Label ID="warningPassword" runat="server" Text="" ForeColor="Red"></asp:Label> 
        <br />

        <asp:Label ID="Label7" runat="server" Text="Role"></asp:Label>
        <br />
        <asp:DropDownList ID="roleList" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>Admin</asp:ListItem>
            <asp:ListItem>Customer</asp:ListItem>
            <asp:ListItem>Guest</asp:ListItem>
        </asp:DropDownList>
            <asp:Label ID="warningRole" runat="server" Text="" ForeColor="Red"></asp:Label> 
        <br />

        <asp:Button ID="registerButton" runat="server" Text="Register" OnClick="registerButton_Click"/>
        <br>
        <asp:Label ID="registerSuccess" runat="server" Text=""></asp:Label>
        <br />
</asp:Content>
