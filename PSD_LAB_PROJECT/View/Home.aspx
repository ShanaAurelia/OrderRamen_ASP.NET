<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="PSD_LAB_PROJECT.View.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="welcome" runat="server" Text="Welcome!!"></asp:Label><br />
        <asp:Label ID="username_label" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="role_label" runat="server" Text=""></asp:Label> <br /><br />

        <asp:GridView ID="GV_For_Staff" runat="server"></asp:GridView>
    </div>
</asp:Content>


