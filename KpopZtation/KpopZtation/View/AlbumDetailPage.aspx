<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavBar.Master" AutoEventWireup="true" CodeBehind="AlbumDetailPage.aspx.cs" Inherits="KpopZtation.View.AlbumDetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br />
 
    <asp:Label ID="Label1" runat="server" Text="Album Name : "></asp:Label>
    <asp:Label ID="AlbumName" runat="server" Text=""></asp:Label><br />
    <asp:Label ID="Label2" runat="server" Text="Album Description : "></asp:Label>
    <asp:Label ID="Albumdesc" runat="server" Text=""></asp:Label><br />
    <asp:Label ID="Label4" runat="server" Text="Album Price : "></asp:Label>
    <asp:Label ID="AlbumPrice" runat="server" Text=""></asp:Label><br />
    <asp:Label ID="Label6" runat="server" Text="Album Stock : "></asp:Label>
    <asp:Label ID="AlbumStock" runat="server" Text=""></asp:Label><br /><br />

    <asp:TextBox ID="input" runat="server" Visible="false"></asp:TextBox><br />
    <asp:Button ID="Button1" runat="server" Text="Add To Cart" Visible="false" OnLoad="Button1_Load" OnClick="Button1_Click" /><br />

    <asp:Label ID="notif" runat="server" Text="" ForeColor="Red"></asp:Label>
</asp:Content>
