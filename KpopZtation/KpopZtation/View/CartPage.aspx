<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavBar.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="KpopZtation.View.CartPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" OnRowDeleting="GridView1_RowDeleting">
        <Columns>
            <asp:ImageField DataImageUrlField="AlbumImage"  HeaderText="Album Picture">
            </asp:ImageField>
            <asp:BoundField DataField="AlbumName" HeaderText="Album Name" SortExpression="AlbumName" />
            <asp:BoundField DataField="AlbumStock" HeaderText="Album Quantity" SortExpression="AlbumStock" />
            <asp:BoundField DataField="AlbumPrice" HeaderText="Album price" SortExpression="AlbumPrice" />
            <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>
    <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" />
</asp:Content>
