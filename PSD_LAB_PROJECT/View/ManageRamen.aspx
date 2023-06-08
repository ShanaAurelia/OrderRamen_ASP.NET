<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar.Master" AutoEventWireup="true" CodeBehind="ManageRamen.aspx.cs" Inherits="PSD_LAB_PROJECT.View.ManageRamen1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Button ID="insert_rmn_btn" runat="server" Text="Insert Ramen" OnClick="insert_rmn_btn_Click" />
        <asp:GridView ID="GridView1" runat="server" >
            <Columns>
                <asp:CommandField ButtonType="Button" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
