<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="PSD_LAB_PROJECT.View.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="welcome" runat="server" Text="Welcome to Register Page"></asp:Label>
            <br />

            <asp:Label ID="username_lbl" runat="server" Text="Username   "></asp:Label>
            <asp:TextBox ID="username_txb" runat="server"></asp:TextBox><br />

            <asp:Label ID="email_lbl" runat="server" Text="Email   "></asp:Label>
            <asp:TextBox ID="email_txb" runat="server"></asp:TextBox><br />

            <asp:Label ID="gender_lbl" runat="server" Text="Gender   "></asp:Label>
            <asp:RadioButtonList ID="gender_btn" runat="server">
                <asp:ListItem Text="Male"></asp:ListItem>
                <asp:ListItem Text="Female"></asp:ListItem>
            </asp:RadioButtonList><br />


            <asp:Label ID="password_lbl" runat="server" Text="Password   "></asp:Label>
            <asp:TextBox ID="password_txb" runat="server"></asp:TextBox><br />

            <asp:Label ID="cpassword_lbl" runat="server" Text="Confirm Password   "></asp:Label>
            <asp:TextBox ID="cpassword_txb" runat="server"></asp:TextBox><br /><br /><br />

            <asp:Button ID="register_btn" runat="server" Text="Register" OnClick="register_btn_Click" /> <asp:Button ID="login_btn" runat="server" Text="Login" style="margin-left: 20px" OnClick="login_btn_Click"/><br />
            <asp:Label ID="status_lbl" runat="server" Text="" style="color:red"></asp:Label>

        </div>
    </form>
</body>
</html>
