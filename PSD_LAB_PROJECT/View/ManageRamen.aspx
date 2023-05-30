<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageRamen.aspx.cs" Inherits="PSD_LAB_PROJECT.View.ManageRamen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <navbar>
                <ul style="list-style-type:none; margin:0; padding:10px; display:inline">
                    <li style="display: inline;" id="order_rmn">
                        <asp:Button ID="order_rmn_btn" runat="server" Text="Order Ramen" 
                            style="visibility:hidden; margin: 0px"/>
                    </li>
                    <li style="display: inline;" id="history">
                        <asp:Button ID="history_btn" runat="server" Text="History" 
                            style="visibility:hidden; margin: 0px"/>
                        </li>
                    <li style="display: inline;" id="profile">
                        <asp:Button ID="profile_btn" runat="server" Text="Profile" 
                            style="visibility:hidden; margin: 0px"/>
                        </li>
                    <li style="display: inline;" id="home">
                        <asp:Button ID="home_btn" runat="server" Text="Home" 
                            style="visibility:hidden; margin: 0px"/>
                        </li>
                    <li style="display: inline;" id="manage">
                        <asp:Button ID="manage_rmn_btn" runat="server" Text="Manage Ramen" 
                            style="visibility:hidden; margin: 0px"/>
                    </li>
                    <li style="display: inline;">
                        <asp:Button ID="order_queue_btn" runat="server" Text="Order Queue" 
                            style="visibility:hidden; margin: 0px"/>
                    </li>
                    <li style="display: inline; margin: 20px" id="report">
                        <asp:Button ID="report_btn" runat="server" Text="Report" 
                            style="visibility:hidden; margin: 0px"/>
                        </li>
                    <li style="display: inline;" id="logout">
                        <asp:Button ID="logout_btn" runat="server" Text="Logout" 
                            style="visibility:hidden; margin: 0px" OnClick="logout_btn_Click"/>
                        </li>
                </ul>
            </navbar>

                <br />
            <div>
                <asp:Button ID="insert_rmn_btn" runat="server" Text="Insert Ramen" />
                <asp:GridView ID="GridView1" runat="server">
                    <Columns>
                        <asp:CommandField ButtonType="Button" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" />
                    </Columns>
                </asp:GridView>
            </div>

        </div>
    </form>
</body>
</html>
