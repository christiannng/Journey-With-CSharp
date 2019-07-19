<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Assignment2_NguyenVanHa.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style5 {
            width: 1000px;
        }
        .auto-style6 {
            width: 119px;
        }
        .auto-style7 {
            width: 236px;
        }
    </style>

    <link href="main.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblLoginBanner" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" Text="Welcome to Our Cinema!"></asp:Label>
            <br />
            <br />
            <table class="auto-style5">
                <tr>
                    <td id="userInfo" class="auto-style6">
                        <asp:Label runat="server" Text="Username: " ID="Label3"></asp:Label>
                    </td>
                    <td class="auto-style7">
                        <asp:TextBox ID="tbUsername" runat="server" Width="149px"></asp:TextBox>
                    </td>
                    <td>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbUsername" ErrorMessage="Username can not be empty." ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td id="userInfo" class="auto-style6">
                        <asp:Label ID="Label2" runat="server" Text="Password: "></asp:Label>
                    </td>
                    <td class="auto-style7"><asp:TextBox ID="tbPassword" runat="server" Width="149px" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbPassword" ErrorMessage="Password cannot be empty." ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td id="userInfo" class="auto-style6">&nbsp;</td>
                    <td class="auto-style7">
                        <asp:Label ID="lblLoginStatus" runat="server" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td id="userInfo" class="auto-style6">
                        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
                    </td>
                    <td class="auto-style7">
                        <asp:Button ID="btnCreateAcc" runat="server" OnClick="btnCreateAcc_Click" Text="Want An Account?" CausesValidation="False" />
                    </td>
                    <td>
                        <asp:Button ID="btnCountinueWithoutAcc" runat="server" Text="Continue Without Account" Width="206px" OnClick="btnCountinueWithoutAcc_Click" CausesValidation="False" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
