<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavBar.Master" AutoEventWireup="true" CodeBehind="TransactionPage.aspx.cs" Inherits="KpopZtation.View.TransactionPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="TransactionID" HeaderText="Transaction ID" SortExpression="TransactionID" />
            <asp:BoundField DataField="TransactionDate" HeaderText="Transaction Date" SortExpression="TransactionDate" />
            <asp:BoundField DataField="TransactionHeader.Customer.CustomerName" HeaderText="Customer Name" SortExpression="TransactionHeader.Customer.CustomerName" />
            <asp:ImageField DataImageUrlField="TransactionHeader.TransactionDetail.Album.AlbumImage" HeaderText="Album Picture">
            </asp:ImageField>
            <asp:BoundField DataField="TransactionHeader.TransactionDetail.Album.AlbumName" HeaderText="Album Name" SortExpression="TransactionHeader.TransactionDetail.Album.AlbumName" />
            <asp:BoundField DataField="TransactionHeader.TransactionDetail.Qty" HeaderText="Album Quantity" SortExpression="TransactionHeader.TransactionDetail.Qty" />
            <asp:BoundField DataField="TransactionHeader.TransactionDetail.Album.AlbumPrice" HeaderText="Album Price" SortExpression="TransactionHeader.TransactionDetail.Album.AlbumPrice" />
            
        </Columns>
    </asp:GridView>
</asp:Content>
