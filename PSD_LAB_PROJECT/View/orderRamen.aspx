<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar.Master" AutoEventWireup="true" CodeBehind="orderRamen.aspx.cs" Inherits="PSD_LAB_PROJECT.View.orderRamen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <br />
        <br />
        <asp:GridView ID="RamenView" runat="server" caption="Ramen Menu" OnRowDeleting="RamenView_RowDeleting" OnRowEditing="RamenView_RowEditing" >
            <Columns>
                <asp:CommandField ButtonType="Button" DeleteText="-" EditText="+" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True"/>
            </Columns>
        </asp:GridView>
        <asp:Label ID="menu_status_lbl" runat="server" Text="" style="color:red"></asp:Label>
        <br />
        <br />

            <asp:GridView ID="CartView" runat="server" Caption="Shopping Cart">
                <Columns>
                </Columns>
            </asp:GridView>
            <br /><br />
            <asp:Button ID="buy_cart_btn" runat="server" Text="Buy Cart" style="visibility:hidden" OnClick="buy_cart_btn_Click"/> 
            <asp:Button ID="clear_cart_btn" runat="server" Text="Clear Cart" style="visibility:hidden" OnClick="clear_cart_btn_Click"/>

    </div>
</asp:Content>
