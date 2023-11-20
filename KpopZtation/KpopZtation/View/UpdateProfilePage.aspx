<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavBar.Master" AutoEventWireup="true" CodeBehind="UpdateProfilePage.aspx.cs" Inherits="KpopZtation.View.UpdateProfilePage" %>
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

            <asp:Label ID="warningRole" runat="server" Text="" ForeColor="Red"></asp:Label> 
        <br />

        <asp:Button ID="UpdateButton" runat="server" Text="Update" OnClick="UpdateButton_Click"/>
        <br>
</asp:Content>
