<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar.Master" AutoEventWireup="true" CodeBehind="InsertRamen.aspx.cs" Inherits="PSD_LAB_PROJECT.View.InsertRamen1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="welcome_txt" runat="server" Text="Please create your ramen!"></asp:Label>
            
            <asp:Label ID="rmn_name_lbl" runat="server" Text="Ramen Name   "></asp:Label>
            <asp:TextBox ID="rmn_name_txb" runat="server"></asp:TextBox><br />

            <asp:Label ID="rmn_meat_lbl" runat="server" Text="Meat Type   "></asp:Label>
            <asp:RadioButtonList ID="rmn_meat_opt" runat="server">
                <asp:ListItem Text="Chicken"></asp:ListItem>
                <asp:ListItem Text="Beef"></asp:ListItem>
                <asp:ListItem Text="Pork"></asp:ListItem>
                <asp:ListItem Text="Lamb"></asp:ListItem>
                <asp:ListItem Text="Fish"></asp:ListItem>
                <asp:ListItem Text="No Meat"></asp:ListItem>
            </asp:RadioButtonList><br />

            <asp:Label ID="rmn_broth_lbl" runat="server" Text="Broth   "></asp:Label>
            <asp:TextBox ID="rmn_broth_txb" runat="server"></asp:TextBox><br />

            <asp:Label ID="rmn_price_lbl" runat="server" Text="Price   "></asp:Label>
            <asp:TextBox ID="rmn_price_txb" runat="server"></asp:TextBox><br /><br />

            <asp:Button ID="create_rmn_btn" runat="server" Text="Create Ramen" OnClick="create_rmn_btn_Click" />
            <asp:Button ID="go_back_btn" runat="server" Text="Go Back" /><br />
            <asp:Label ID="status_lbl" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
