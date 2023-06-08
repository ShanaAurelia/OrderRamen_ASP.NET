<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar.Master" AutoEventWireup="true" CodeBehind="updateRamen.aspx.cs" Inherits="PSD_LAB_PROJECT.View.updateRamen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="welcome_lbl" runat="server" Text="Update Ramen Page"></asp:Label><br />
        <asp:Label ID="label1" runat="server" Text="Current data is: "></asp:Label><br />
        <asp:Label ID="curr_name_lbl" runat="server" Text="Ramen Name: "></asp:Label><br />
        <asp:Label ID="curr_meat_lbl" runat="server" Text="Meat Type: "></asp:Label><br />
        <asp:Label ID="curr_broth_lbl" runat="server" Text="Broth: "></asp:Label><br />
        <asp:Label ID="curr_price_lbl" runat="server" Text="Price: "></asp:Label><br /><br />
        
        <asp:Label ID="edited_name_lbl" runat="server" Text="New Name:   "></asp:Label>
        <asp:TextBox ID="edited_name_txb" runat="server"></asp:TextBox><br />

        <asp:Label ID="edited_meat_lbl" runat="server" Text="New Meat Type:"></asp:Label><br />
        <asp:RadioButtonList ID="rmn_meat_opt" runat="server">
                <asp:ListItem Text="Chicken"></asp:ListItem>
                <asp:ListItem Text="Beef"></asp:ListItem>
                <asp:ListItem Text="Pork"></asp:ListItem>
                <asp:ListItem Text="Lamb"></asp:ListItem>
                <asp:ListItem Text="Fish"></asp:ListItem>
                <asp:ListItem Text="No Meat"></asp:ListItem>
            </asp:RadioButtonList><br />

        <asp:Label ID="edited_broth_lbl" runat="server" Text="New Broth:   "></asp:Label>
        <asp:TextBox ID="edited_broth_txb" runat="server"></asp:TextBox><br />

        <asp:Label ID="edited_price_lbl" runat="server" Text="New Price:   "></asp:Label>
        <asp:TextBox ID="edited_price_txb" runat="server"></asp:TextBox><br /><br />

        <asp:Button ID="update_btn" runat="server" Text="Edit Ramen" OnClick="update_btn_Click" />
        <asp:Button ID="back_btn" runat="server" Text="Go Back" OnClick="GoBack_btn_Click" /><br />
        <asp:Label ID="status_lbl" runat="server" Text="" style="color:red"></asp:Label>
    </div>
</asp:Content>
