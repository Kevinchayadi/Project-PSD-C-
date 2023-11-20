<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavBar.Master" AutoEventWireup="true" CodeBehind="InsertAlbumPage.aspx.cs" Inherits="KpopZtation.View.InsertAlbumPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <br />

    <asp:Label ID="Label1" runat="server" Text="Add New Data Album"></asp:Label>
    <br /><br />
    <asp:Label ID="Label2" runat="server" Text="Album Name"></asp:Label><br />
    <asp:TextBox ID="AlbumName" runat="server"></asp:TextBox><br />
    <asp:Label ID="Warningname" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Album Description"></asp:Label><br />
    <asp:TextBox ID="AlbumDesc" runat="server"></asp:TextBox><br />
    <asp:Label ID="WarningDecs" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />
    <asp:Label ID="Label5" runat="server" Text="Price"></asp:Label><br />
    <asp:TextBox ID="albumPrice" runat="server" type="number"></asp:TextBox><br />
    <asp:Label ID="WarningPrice" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />
    <asp:Label ID="Label8" runat="server" Text="Stock"></asp:Label><br />
    <asp:TextBox ID="albumStock" runat="server" type="number"></asp:TextBox><br />
    <asp:Label ID="WarningStock" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br /><br />
    
    <asp:FileUpload ID="fileUpload" runat="server" /><br />
    <asp:Label ID="WarningPhoto" runat="server" Text="" ForeColor="Red"></asp:Label><br />

    <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" /><br />
    <asp:Label ID="notif" runat="server" Text="" ForeColor="Red"></asp:Label>
</asp:Content>
