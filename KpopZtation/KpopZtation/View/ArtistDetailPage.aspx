<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavBar.Master" AutoEventWireup="true" CodeBehind="ArtistDetailPage.aspx.cs" Inherits="KpopZtation.View.ArtistDetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div><asp:Label ID="artistName" runat="server" Text=""></asp:Label></div>
        <div><asp:Button ID="insertButton" runat="server" Text="Insert" Visible ="false" OnClick="insertButton_Click"/></div>
        <br />
           <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <asp:GridView ID="ArtistAndAlbum" runat="server" OnRowDeleting="ArtistAndAlbum_RowDeleting" AutoGenerateColumns="False" OnRowCommand="ArtistAndAlbum_RowCommand">
            <Columns>
                <asp:CommandField ButtonType="Button" HeaderText="Delete" ShowDeleteButton="True" />
                <asp:ButtonField ButtonType="Button" HeaderText="Update" Text="Update" CommandName="updateBtn"/>
                <asp:BoundField DataField="AlbumId" HeaderText="AlbumID"/>
                <asp:BoundField DataField="AlbumName" HeaderText="Album Name" />
                <asp:BoundField DataField="AlbumPrice" HeaderText="Album Price" />
                <asp:BoundField DataField="AlbumDescription" HeaderText="Album Description" />
                <asp:TemplateField HeaderText="Album Image">
                    <ItemTemplate>
                        <asp:HyperLink ID="albumDetail" runat="server" NavigateUrl='<%# "AlbumDetailPage.aspx?id="+ Eval("AlbumId") %>'>
                        <asp:Image ID="ImageButton1" runat="Server" ImageUrl='<%#Bind("AlbumImage") %>' CommandName="Imageklik" style="max-height: 100px; max-width: 100px;"/>
                        </asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
</div>
</asp:Content>
