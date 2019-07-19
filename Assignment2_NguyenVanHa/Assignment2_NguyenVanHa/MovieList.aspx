<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MovieList.aspx.cs" Inherits="Assignment2_NguyenVanHa.MovieList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1000px;
        }
        .auto-style2 {
            width: 50px;
        }
        .auto-style3 {
            width: 98%;
        }
        .auto-style6 {
            height: 25px;
            width: 488px;
        }
        .auto-style8 {
            width: 740px;
        }
        .auto-style9 {
            width: 488px;
        }
        .auto-style11 {
            width: 112px;
        }
        .auto-style12 {
            width: 112px;
            height: 25px;
        }
        .auto-style13 {
            width: 528px;
        }
        .auto-style14 {
            height: 25px;
            width: 528px;
        }
        .auto-style15 {
            width: 507px;
        }
        .auto-style16 {
            height: 25px;
            width: 507px;
        }
    </style>

    <link href="main.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblLoginBanner" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" Text="Let's Choose a Movie Together!"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnAdminAccess" runat="server" OnClick="btnAdminAccess_Click" Text="Access Admin Database" Visible="False" />
            <br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Image ID="img1" Width="250px" Height="300px" runat="server" />
                    </td>
                    <td class="auto-style8">
                        <table class="auto-style3">
                            <tr>
                                <td class="auto-style11" id="movieInfo">Movie Name:</td>
                                <td class="auto-style13">
                                    <asp:Label ID="lblMovieName0" runat="server" Text="Label" CssClass="Movie1"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style11" id="movieInfo">Summary:</td>
                                <td class="auto-style13">
                                    <asp:Label ID="lblSummary0" runat="server" Text="Label" CssClass="Movie1"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style12" id="movieInfo">Release Date:</td>
                                <td class="auto-style14">
                                    <asp:Label ID="lblReleaseDate0" runat="server" Text="Label" CssClass="Movie1"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style11" id="movieInfo">IMDB Rating:</td>
                                <td class="auto-style13">
                                    <asp:Label ID="lblIMDB0" runat="server" Text="Label" CssClass="Movie1"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style11" id="movieInfo">Duration:</td>
                                <td class="auto-style13">
                                    <asp:Label ID="lblDuration0" runat="server" Text="Label" CssClass="Movie1"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style11" id="movieInfo">Genres:</td>
                                <td class="auto-style13">
                                    <asp:Label ID="lblGenres0" runat="server" Text="Label" CssClass="Movie1"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style11" id="movieInfo">Showtime:</td>
                                <td class="auto-style13">
                                    <asp:DropDownList ID="drdShowtime0" runat="server">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style11" id="movieInfo">&nbsp;</td>
                                <td class="auto-style13">
                                    <asp:Button ID="btnGetTicket0" runat="server" OnClick="btnGetTicket0_Click" Text="Get Ticket" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Image ID="img2" Width="250px" Height="300px" runat="server" />
                    </td>
                    <td class="auto-style8">
                        <table class="auto-style3">
                            <tr>
                                <td class="auto-style11" id="movieInfo">Movie Name:</td>
                                <td class="auto-style15">
                                    <asp:Label ID="lblMovieName1" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style11" id="movieInfo">Summary:</td>
                                <td class="auto-style15">
                                    <asp:Label ID="lblSummary1" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style12" id="movieInfo">Release Date:</td>
                                <td class="auto-style16">
                                    <asp:Label ID="lblReleaseDate1" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style11" id="movieInfo">IMDB Rating:</td>
                                <td class="auto-style15">
                                    <asp:Label ID="lblIMDB1" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style11" id="movieInfo">Duration:</td>
                                <td class="auto-style15">
                                    <asp:Label ID="lblDuration1" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style11" id="movieInfo">Genres:</td>
                                <td class="auto-style15">
                                    <asp:Label ID="lblGenres1" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style11" id="movieInfo">Showtime:</td>
                                <td class="auto-style15">
                                    <asp:DropDownList ID="drdShowtime1" runat="server">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style11" id="movieInfo">&nbsp;</td>
                                <td class="auto-style15">
                                    <asp:Button ID="btnGetTicket1" runat="server" OnClick="btnGetTicket1_Click" Text="Get Ticket" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Image ID="img3" Width="250px" Height="300px" runat="server" />
                    </td>
                    <td class="auto-style8">
                        <table class="auto-style3">
                            <tr>
                                <td class="auto-style11" id="movieInfo">Movie Name:</td>
                                <td class="auto-style9">
                                    <asp:Label ID="lblMovieName2" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style11" id="movieInfo">Summary:</td>
                                <td class="auto-style9">
                                    <asp:Label ID="lblSummary2" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style12" id="movieInfo">Release Date:</td>
                                <td class="auto-style6">
                                    <asp:Label ID="lblReleaseDate2" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style11" id="movieInfo">IMDB Rating:</td>
                                <td class="auto-style9">
                                    <asp:Label ID="lblIMDB2" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style11" id="movieInfo">Duration:</td>
                                <td class="auto-style9">
                                    <asp:Label ID="lblDuration2" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style11" id="movieInfo">Genres:</td>
                                <td class="auto-style9">
                                    <asp:Label ID="lblGenres2" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style11" id="movieInfo">Showtime:</td>
                                <td class="auto-style9">
                                    <asp:DropDownList ID="drdShowtime2" runat="server">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style11" id="movieInfo">&nbsp;</td>
                                <td class="auto-style9">
                                    <asp:Button ID="btnGetTicket2" runat="server" OnClick="btnGetTicket2_Click" Text="Get Ticket" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
