<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="Assignment2_NguyenVanHa.AdminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style4 {
            width: 206px;
        }
        .auto-style6 {
            width: 872px;
        }
        .auto-style7 {
            width: 142px;
        }
        .auto-style8 {
            width: 53%;
        }
        .auto-style9 {
            width: 29%;
        }
    </style>
    <link href="main.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblUserDB" runat="server" Text="Users Database" Font-Bold="True" Font-Size="X-Large"></asp:Label>
                    <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnMovieList" runat="server" OnClick="btnMovieList_Click" Text="Get to Movie List" />
            <br />
            <br />
                        <table class="auto-style1">
                            <tr>
                                <td id="userInfo" class="auto-style4">UserID:</td>
                                <td class="auto-style6">
                                    <asp:DropDownList ID="drdUserID" runat="server" DataSourceID="SqlDataSource1" DataTextField="Username" DataValueField="UserID">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td id="userInfo" class="auto-style4">Username:</td>
                                <td class="auto-style6">
                     <asp:TextBox ID="tbUsername" runat="server" MaxLength="15" Width="250px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td id="userInfo" class="auto-style4">Password:</td>
                                <td class="auto-style6">
                     <asp:TextBox ID="tbPass" runat="server" MaxLength="15" Width="250px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td id="userInfo" class="auto-style4">Email:</td>
                                <td class="auto-style6">
                     <asp:TextBox ID="tbEmail" runat="server" MaxLength="50" Width="250px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td id="userInfo" class="auto-style4">Full name:</td>
                                <td class="auto-style6">
                     <asp:TextBox ID="tbName" runat="server" MaxLength="50" Width="250px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td id="userInfo" class="auto-style4">Country:</td>
                                <td class="auto-style6">
                     <asp:DropDownList ID="drdCountry" runat="server">
                         <asp:ListItem Value="-1">Select One</asp:ListItem>
                         <asp:ListItem>Vietnam</asp:ListItem>
                         <asp:ListItem>Canada</asp:ListItem>
                         <asp:ListItem>France</asp:ListItem>
                         <asp:ListItem>Spanish</asp:ListItem>
                         <asp:ListItem>Singapore</asp:ListItem>
                         <asp:ListItem>Thailand</asp:ListItem>
                         <asp:ListItem>USA</asp:ListItem>
                     </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td id="userInfo" class="auto-style4">Admin or User?</td>
                                <td class="auto-style6">
                                    <table class="auto-style9">
                                        <tr>
                                            <td>
                                                <asp:RadioButton ID="rbtnAdmin" runat="server" Text="Admin" GroupName="AdminOrUser" />
                                            </td>
                                            <td>
                                                <asp:RadioButton ID="rbtnUser" runat="server" Text="User" Checked="True" GroupName="AdminOrUser" />
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td id="userInfo" class="auto-style4">&nbsp;</td>
                                <td class="auto-style6">
                                    <table class="auto-style8">
                                        <tr>
                                            <td class="auto-style7">
                                    <asp:Button ID="btnAddUser" runat="server" Text="Add User" OnClick="btnAddUser_Click" />
                                            </td>
                                            <td>
                                    <asp:Button ID="btnUpdateUser" runat="server" Text="Update User" OnClick="btnUpdateUser_Click" />
                                            </td>
                                            <td>
                                    <asp:Button ID="btnDeleteUser" runat="server" Text="Delete User" OnClick="btnDeleteUser_Click" />
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    <br />
                        <asp:Label ID="lblStatusUser" runat="server" ForeColor="#33CC33" Text="Label" Visible="False"></asp:Label>
                        <br />
            <br />
                        <asp:GridView ID="gvUsers" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="UserID" DataSourceID="SqlDataSource1" GridLines="Vertical" PageSize="12">
                            <AlternatingRowStyle BackColor="#DCDCDC" />
                            <Columns>
                                <asp:BoundField DataField="UserID" HeaderText="UserID" InsertVisible="False" ReadOnly="True" SortExpression="UserID" />
                                <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
                                <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
                                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                                <asp:BoundField DataField="Full Name" HeaderText="Full Name" SortExpression="Full Name" />
                                <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
                                <asp:CheckBoxField DataField="IsAdmin" HeaderText="IsAdmin" SortExpression="IsAdmin" />
                            </Columns>
                            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#0000A9" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#000065" />
                        </asp:GridView>
                        <br />
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:A2ConnectionString %>" SelectCommand="SELECT * FROM [Users] ORDER BY [UserID] DESC"></asp:SqlDataSource>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
