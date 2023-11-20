<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavBar.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="KpopZtation.View.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowDeleting="GridView1_RowDeleting" OnRowUpdating="GridView1_RowUpdating"  OnRowCommand="GridView1_RowCommand">
    <Columns>
        <asp:TemplateField HeaderText="Artist Image">
                    <ItemTemplate>
                        <asp:HyperLink ID="albumDetail" runat="server" NavigateUrl='<%# "ArtistDetailPage.aspx?id="+ Eval("ArtistID") %>'>
                        <asp:Image ID="ImageButton1" runat="Server" ImageUrl='<%#Bind("ArtistImage") %>' CommandName="Imageklik" style="max-height: 100px; max-width: 100px;"/>
                        </asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
        <asp:BoundField DataField="ArtistName" HeaderText="Artist Name" SortExpression="ArtistName" />
        <asp:CommandField ButtonType="Button" EditText="Update" ShowDeleteButton="True" ShowEditButton="True"  />
        
    </Columns>
    </asp:GridView>

    <asp:Button ID="btnTombol" runat="server" Text="Add Artist" OnLoad="btnTombol_Load" Visible="false" OnClick="btnTombol_Click" />


</asp:Content>

