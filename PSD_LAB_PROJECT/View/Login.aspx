<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PSD_LAB_PROJECT.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="welcome" runat="server" Text="Welcome to Login Page"></asp:Label>
            <br />

            <asp:Label ID="username_lbl" runat="server" Text="Username   "></asp:Label>
            <asp:TextBox ID="username_txb" runat="server"></asp:TextBox><br />

            <asp:Label ID="password_lbl" runat="server" Text="Password   "></asp:Label>
            <asp:TextBox ID="password_txb" runat="server"></asp:TextBox><br />

            <asp:Button ID="login_btn" runat="server" Text="Login" OnClick="login_btn_Click" /> <asp:Button ID="register_btn" runat="server" Text="Register" style="margin-left:20px" OnClick="register_btn_Click"/><br />
            <asp:CheckBox ID="remember_me_chck" runat="server" /><asp:Label ID="remember_me_lbl" runat="server" Text="  Remember me"></asp:Label><br />
            <asp:Label ID="status_lbl" runat="server" Text="" style="color:red"></asp:Label>
        </div>
    </form>
</body>
</html>
