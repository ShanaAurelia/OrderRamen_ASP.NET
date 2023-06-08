<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="PSD_LAB_PROJECT.View.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="welcome_lbl" runat="server" Text="Here is your current data"></asp:Label><br />

        <asp:Label ID="curr_username" runat="server" Text="Current Username: "></asp:Label>
        <asp:Label ID="curr_username_lbl" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="new_username_lbl" runat="server" Text="New Username:   "></asp:Label>
        <asp:TextBox ID="new_username_txb" runat="server"></asp:TextBox><br />

        <asp:Label ID="curr_email_lbl" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="new_email_lbl" runat="server" Text="New Email:   "></asp:Label>
        <asp:TextBox ID="new_email_txb" runat="server"></asp:TextBox><br />

        <asp:Label ID="curr_gender_lbl" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="new_gender_lbl" runat="server" Text="New Gender:   "></asp:Label>
        <asp:RadioButtonList ID="gender_btn" runat="server">
                <asp:ListItem Text="Male"></asp:ListItem>
                <asp:ListItem Text="Female"></asp:ListItem>
            </asp:RadioButtonList><br />

        <asp:Label ID="curr_password_lbl" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="new_password_lbl" runat="server" Text="New Password:   "></asp:Label>
        <asp:TextBox ID="new_password_txb" runat="server"></asp:TextBox><br /><br />

        <asp:Button ID="update_btn" runat="server" Text="Update" OnClick="update_btn_Click" /><br />
        <asp:Label ID="status_lbl" runat="server" Text="" style="color:red"></asp:Label>

    </div>
</asp:Content>
