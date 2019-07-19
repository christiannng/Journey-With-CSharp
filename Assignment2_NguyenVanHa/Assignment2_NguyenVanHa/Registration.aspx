<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Assignment2_NguyenVanHa.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="main.css" rel="stylesheet" type="text/css" />
</head>
<body>
     <form id="form1" runat="server">
         <asp:Label ID="lblRegisterBanner" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" Text="Create an Account"></asp:Label>
         <br />
         <table class="auto-style1">
             <tr>
                 <td class="auto-style2" id="userInfo">Username:</td>
                 <td class="auto-style3">
                     <asp:TextBox ID="tbUsername" runat="server" MaxLength="15" Width="250px"></asp:TextBox>
                 </td>
                 <td>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbUsername" ErrorMessage="Username can not be empty." ForeColor="Red"></asp:RequiredFieldValidator>
                 </td>
             </tr>
             <tr>
                 <td class="auto-style2" id="userInfo">Password:</td>
                 <td class="auto-style3">
                     <asp:TextBox ID="tbPass" runat="server" MaxLength="15" Width="250px" TextMode="Password"></asp:TextBox>
                 </td>
                 <td>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbPass" ErrorMessage="Password cannot be empty." ForeColor="Red"></asp:RequiredFieldValidator>
                 </td>
             </tr>
             <tr>
                 <td class="auto-style2" id="userInfo">Retype Password:</td>
                 <td class="auto-style3">
                     <asp:TextBox ID="TbRetype" runat="server" Width="250px" TextMode="Password"></asp:TextBox>
                 </td>
                 <td>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TbRetype" ErrorMessage="Must match password." ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="tbPass" ControlToValidate="TBRetype" ErrorMessage="Password does not match" ForeColor="Red"></asp:CompareValidator>
                 </td>
             </tr>
             <tr>
                 <td class="auto-style2" id="userInfo">Email:</td>
                 <td class="auto-style3">
                     <asp:TextBox ID="tbEmail" runat="server" MaxLength="50" Width="250px"></asp:TextBox>
                 </td>
                 <td>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="tbEmail" ErrorMessage="Email can not be empty." ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;&nbsp;
                     <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tbEmail" ErrorMessage="Not a proper email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                 </td>
             </tr>
             <tr>
                 <td class="auto-style2" id="userInfo">Full Name:</td>
                 <td class="auto-style3">
                     <asp:TextBox ID="tbName" runat="server" MaxLength="50" Width="250px"></asp:TextBox>
                 </td>
                 <td>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="tbName" ErrorMessage="Full name can not be empty." ForeColor="Red"></asp:RequiredFieldValidator>
                 </td>
             </tr>
             <tr>
                 <td class="auto-style2" id="userInfo">Country:</td>
                 <td class="auto-style3">
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
                 <td>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="drdCountry" ErrorMessage="Must select a country." ForeColor="Red" InitialValue="-1"></asp:RequiredFieldValidator>
                 </td>
             </tr>
             <tr>
                 <td class="auto-style2" id="userInfo">&nbsp;</td>
                 <td class="auto-style3">
                     <asp:Label ID="lblCreateStatus" runat="server" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
                 </td>
                 <td>
                     &nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style2" id="userInfo">
                     <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Create " />
&nbsp; <input id="Reset1" type="reset" value="Reset" /></td>
                 <td class="auto-style3">&nbsp;</td>
                 <td>
&nbsp;</td>
             </tr>
         </table>
    </form>
</body>
</html>
