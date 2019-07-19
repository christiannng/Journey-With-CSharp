<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="Assignment2_NguyenVanHa.Checkout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1000px;
        }
        .auto-style2 {
            width: 158px;
        }
        .auto-style3 {
            width: 98%;
        }
        .auto-style9 {
            width: 493px;
        }
        .auto-style5 {
            width: 166px;
            height: 25px;
        }
        .auto-style6 {
            height: 25px;
            width: 493px;
        }
        .auto-style11 {
            width: 306px;
        }
        .auto-style13 {
            width: 142px;
        }
        .auto-style14 {
            width: 83px;
        }
        .auto-style15 {
            width: 950px;
        }
        .auto-style17 {
            width: 166px;
        }
        .auto-style18 {
            width: 96px;
        }
    </style>

    <link href="main.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCheckOutBanner" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" Text="Let's get you the ticket"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnAdminAccess" runat="server" OnClick="btnAdminAccess_Click" Text="Access Admin Database" Visible="False" />
            <br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <iframe width="400" height="315" frameborder="0" allowfullscreen id="iframe" runat="server"></iframe>
                    </td>
                    <td class="auto-style15">
                        <table class="auto-style3">
                            <tr>
                                <td class="auto-style17" id="movieInfo">
                                    <asp:Label ID="Label2" runat="server" Text="Movie Name:"></asp:Label>
                                </td>
                                <td class="auto-style9">
                                    <asp:Label ID="lblMovieName0" runat="server" Text="Label" CssClass="Movie1" ForeColor="#33CC33"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style17" id="movieInfo">
                                    <asp:Label ID="Label3" runat="server" Text="Summary:"></asp:Label>
                                </td>
                                <td class="auto-style9">
                                    <asp:Label ID="lblSummary0" runat="server" Text="Label" CssClass="Movie1"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style5" id="movieInfo">
                                    <asp:Label ID="Label4" runat="server" Text="Release Date:"></asp:Label>
                                </td>
                                <td class="auto-style6">
                                    <asp:Label ID="lblReleaseDate0" runat="server" Text="Label" CssClass="Movie1"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style17" id="movieInfo">
                                    <asp:Label ID="Label5" runat="server" Text="IMDB Rating:"></asp:Label>
                                </td>
                                <td class="auto-style9">
                                    <asp:Label ID="lblIMDB0" runat="server" Text="Label" CssClass="Movie1" ForeColor="#33CC33"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style17" id="movieInfo">
                                    <asp:Label ID="Label6" runat="server" Text="Duration:"></asp:Label>
                                </td>
                                <td class="auto-style9">
                                    <asp:Label ID="lblDuration0" runat="server" Text="Label" CssClass="Movie1"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style17" id="movieInfo">
                                    <asp:Label ID="Label7" runat="server" Text="Genres:"></asp:Label>
                                </td>
                                <td class="auto-style9">
                                    <asp:Label ID="lblGenres0" runat="server" Text="Label" CssClass="Movie1"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style17" id="movieInfo">
                                    <asp:Label ID="Label8" runat="server" Text="Showtime:"></asp:Label>
                                </td>
                                <td class="auto-style9">
                                    <asp:Label ID="lblShowtime" runat="server" Text="Label" CssClass="Movie1" ForeColor="#33CC33"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
            <br />
            <asp:Label ID="lblDate" runat="server" Font-Italic="True" Font-Size="Large" Text="Date" ForeColor="#CC9900"></asp:Label>
            <br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style11">
                        <asp:Label ID="lblTuesOrNot" runat="server" Text="General Admission"></asp:Label>
                    </td>
                    <td class="auto-style18" id="priceInfo">
                        <asp:Label ID="Label9" runat="server" Text="$"></asp:Label>
                        <asp:Label ID="lblGeneralAdmission" runat="server" Text="15.00"></asp:Label>
                    </td>
                    <td class="auto-style13">
                        <asp:Button ID="btnMinus" runat="server" OnClick="btnMinus_Click" Text="-" />
&nbsp; <asp:Label ID="lblQuantity" runat="server" Text="0"></asp:Label>
&nbsp; <asp:Button ID="btnAdd" runat="server" Text="+" OnClick="btnAdd_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11">Senior Citizen &amp; Children (&lt;13 years old)</td>
                    <td class="auto-style18" id="priceInfo">
                        <asp:Label ID="Label10" runat="server" Text="$"></asp:Label>
                        <asp:Label ID="lblAgeAdmission" runat="server" Text="5.00"></asp:Label>
                    </td>
                    <td class="auto-style13">
                        <asp:Button ID="btnMinus1" runat="server" OnClick="btnMinus1_Click" Text="-" />
&nbsp;
                        <asp:Label ID="lblQuantity1" runat="server" Text="0"></asp:Label>
&nbsp;
                        <asp:Button ID="btnAdd1" runat="server" OnClick="btnAdd1_Click" Text="+" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11">
                        <asp:Label ID="lblTues" runat="server" Text="Tuesday special" Visible="False"></asp:Label>
                    </td>
                    <td class="auto-style18" id="priceInfo">&nbsp;<asp:Label ID="Label11" runat="server" Text="$" Visible="False"></asp:Label>
                        <asp:Label ID="lblTuesdayAdmission" runat="server" Text="5.00" Visible="False"></asp:Label>
                    </td>
                    <td class="auto-style13">
                        <br />
                        <asp:Button ID="btnMinus2" runat="server" OnClick="btnMinus2_Click" Text="-" Visible="False" />
&nbsp;
                        <asp:Label ID="lblQuantity2" runat="server" Text="0" Visible="False"></asp:Label>
&nbsp;
                        <asp:Button ID="btnAdd2" runat="server" OnClick="btnAdd2_Click" Text="+" Visible="False" />
                    </td>
                    <td>
                        <asp:Label ID="lblDaysTillTues" runat="server" Text="Label" Visible="False"></asp:Label>
                        <br />
                        <asp:Label ID="lblNextTues" runat="server" Text="Label" Visible="False" ForeColor="#33CC33"></asp:Label>
                    </td>
                </tr>
            </table>
            <div>
&nbsp;&nbsp;&nbsp;<br />
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style14" id="billInfo">Discount:</td>
                        <td>
                            <asp:Label ID="lblDiscount" runat="server" Text="0"></asp:Label>
                            <asp:Label ID="Label12" runat="server" Text="%"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style14" id="billInfo">Amount:</td>
                        <td>
                            <asp:Label ID="lblAmount" runat="server" Text="$0.00"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style14" id="billInfo">Tax:</td>
                        <td>
                            <asp:Label ID="lblTax" runat="server" Text="$0.00"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style14" id="billInfo">Total:</td>
                        <td>
                            <asp:Label ID="lblTotal" runat="server" Text="$0.00" ForeColor="#33CC33" Font-Size="Large" Font-Underline="True"></asp:Label>
                        </td>
                    </tr>
                </table>
                <br />
                <asp:HyperLink ID="HyperLink1" runat="server" ImageHeight="75px" ImageUrl="images/creditcard_icon.png" ImageWidth="75px" NavigateUrl="~/Bill.aspx">HyperLink</asp:HyperLink>
                <br />
                <br />
                <asp:Label ID="lblNotEnoughTicket" runat="server" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
                <br />
                <br />
                <asp:Button disabled="true" ID="btnShowBill" runat="server" Text="Show Bill" Height="29px" OnClick="btnShowBill_Click" />
                <br />
            </div>
        </div>
    </form>
</body>
</html>
