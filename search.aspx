<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="FriendsToSupport.com.temp3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 76px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style1">Search Availability </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Blood Group"></asp:Label>
                </td>
                <td>
                    <select id="Select1" name="D1">
                        <option value="A+">A+</option><option value="A-">A-</option>
                        <option value="B+">B+</option><option value="B-">B-</option>
                        <option value="O+">O+</option><option value="O-">O-</option>
                        <option value="AB+">AB+</option><option value="AB-">AB-</option>
                    </select></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label10" runat="server" Text="Select Country"></asp:Label>
                </td>
                <td>
                    <select id="Select2" name="D2">
                        <option value="India">India</option>
                        <option value="USA">USA</option>
                    </select></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label11" runat="server" Text="Select State"></asp:Label>
                </td>
                <td>
                    <select id="Select3" name="D3">
                        <option value="Telangana">Telangana</option>
                        <option value="AndhraPradesh">AndraPradesh</option>
                    </select></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label12" runat="server" Text="Select District"></asp:Label>
                </td>
                <td>
                    <select id="Select4" name="D4">
                        <option value="Warangal">Warangal</option>
                        <option value="Hyderabad">Hyderabad<option>
                    </select></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label19" runat="server" Text="Select City"></asp:Label>
                </td>
                <td>
                    <select id="Select5" name="D5">
                        <option value="Hanamkonda">Hanamkonda</option>
                        <option value="kazipet">kazipet</option>
                    </select></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" />
                </td>
            </tr>
        </table>
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
