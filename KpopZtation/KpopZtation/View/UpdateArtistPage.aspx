<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavBar.Master" AutoEventWireup="true" CodeBehind="UpdateArtistPage.aspx.cs" Inherits="KpopZtation.View.UpdateArtistPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <asp:Label ID="Label1" runat="server" Text="Update Artis Data"></asp:Label>
    <br /><br />
    <asp:Label ID="Label2" runat="server" Text="Artis Name"></asp:Label><br />
    <asp:TextBox ID="ArtisName" runat="server"></asp:TextBox><br />
    <asp:Label ID="WarningNameArtis" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />
    <asp:FileUpload ID="fileUpload" runat="server" /><br />
    <asp:Label ID="WarningPhoto" runat="server" Text="" ForeColor="Red"></asp:Label><br />

    <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" /><br />
    <asp:Label ID="notif" runat="server" Text="" ForeColor="Red"></asp:Label>
</asp:Content>
