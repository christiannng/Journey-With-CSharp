<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bill.aspx.cs" Inherits="Assignment2_NguyenVanHa.Bill" %>

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
            width: 1519px;
        }
        .auto-style5 {
            width: 221px;
            height: 25px;
        }
        .auto-style6 {
            height: 25px;
            width: 1519px;
        }
        .auto-style14 {
            width: 69px;
        }
        .auto-style12 {
            width: 306px;
        }
        .auto-style13 {
            width: 98px;
        }
        .auto-style15 {
            width: 45px;
        }
        .auto-style16 {
            width: 221px;
        }
    </style>

    <link href="main.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCheckOutBanner" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" Text="Thank You For Choosing Us! Have a great time!"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnAdminAccess" runat="server" OnClick="btnAdminAccess_Click" Text="Access Admin Database" Visible="False" />
            <br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Image ID="img"  Width="150px" Height="200px" runat="server" />
                    </td>
                    <td>
                        <table class="auto-style3">
                            <tr>
                                <td class="auto-style16" id="movieInfo">
                                    <asp:Label ID="Label2" runat="server" Text="Movie Name:"></asp:Label>
                                </td>
                                <td class="auto-style9">
                                    <asp:Label ID="lblMovieName0" runat="server" Text="Label" CssClass="Movie1" ForeColor="#33CC33"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style16" id="movieInfo">
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
                                <td class="auto-style16" id="movieInfo">
                                    <asp:Label ID="Label5" runat="server" Text="IMDB Rating:"></asp:Label>
                                </td>
                                <td class="auto-style9">
                                    <asp:Label ID="lblIMDB0" runat="server" Text="Label" CssClass="Movie1" ForeColor="#33CC33"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style16" id="movieInfo">
                                    <asp:Label ID="Label6" runat="server" Text="Duration:"></asp:Label>
                                </td>
                                <td class="auto-style9">
                                    <asp:Label ID="lblDuration0" runat="server" Text="Label" CssClass="Movie1"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style16" id="movieInfo">
                                    <asp:Label ID="Label7" runat="server" Text="Genres:"></asp:Label>
                                </td>
                                <td class="auto-style9">
                                    <asp:Label ID="lblGenres0" runat="server" Text="Label" CssClass="Movie1"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style16" id="movieInfo">
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
                    <td class="auto-style15">
                        <asp:Label ID="lblQnt0" runat="server" Text="Label"></asp:Label>
                    &nbsp;</td>
                    <td class="auto-style12"><asp:Label ID="lblGeneralAdmission" runat="server" Text="General Admission"></asp:Label>
                    </td>
                    <td class="auto-style13">
                        <asp:Label ID="Label9" runat="server" Text="$"></asp:Label>
                        <asp:Label ID="lblGeneralAdmissionPrice" runat="server" Text="15.00"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style15"><asp:Label ID="lblQnt1" runat="server" Text="Label"></asp:Label>
                    &nbsp;</td>
                    <td class="auto-style12">
                        <asp:Label ID="lblSeniorAdmission" runat="server" Text="Senior Citizen &amp; Children (&lt;13 years old)"></asp:Label>
                    </td>
                    <td class="auto-style13">
                        <asp:Label ID="Label10" runat="server" Text="$"></asp:Label>
                        <asp:Label ID="lblAgeAdmissionPrice" runat="server" Text="5.00"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style15">
                        <asp:Label ID="lblQnt2" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="auto-style12">
                        <asp:Label ID="lblTues" runat="server" Text="Tuesday special"></asp:Label>
                    </td>
                    <td class="auto-style13">
                        <asp:Label ID="Label11" runat="server" Text="$"></asp:Label>
                        <asp:Label ID="lblTuesdayAdmissionPrice" runat="server" Text="5.00"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblTuesDate" runat="server" Text="Label" ForeColor="#33CC33"></asp:Label>
                        <br />
                    </td>
                </tr>
            </table>
            <br />
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
            <asp:Button ID="btnMovieList" runat="server" OnClick="btnMovieList_Click" Text="Get another movie ticket?" />
        </div>
    </form>
</body>
</html>
