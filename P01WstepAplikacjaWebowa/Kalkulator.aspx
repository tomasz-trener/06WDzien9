<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kalkulator.aspx.cs" Inherits="P01WstepAplikacjaWebowa.Kalkulator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <style>
            input{
                width:50px;
            }
            .wyswieltacz{
                width:210px;
            }
        </style>

        <table>
            <tr>
                <td colspan="4"> <asp:TextBox ID="txtWyswietlacz" CssClass="wyswieltacz" runat="server"></asp:TextBox></td>
               
            </tr>
            <tr>
                <td><asp:Button ID="btnSieden" runat="server" Text="7" /></td>
                <td><asp:Button ID="btnOsiem" runat="server" Text="8" /></td>
                <td><asp:Button ID="btnDziewiec" runat="server" Text="9" /></td>
                <td><asp:Button ID="btnPlus" runat="server" Text="+" /></td>
            </tr>
             <tr>
                <td><asp:Button ID="btnCZtery" runat="server" Text="4" /></td>
                <td><asp:Button ID="btnPiec" runat="server" Text="5" /></td>
                <td><asp:Button ID="btnSzesc" runat="server" Text="6" /></td>
                <td><asp:Button ID="btnMinus" runat="server" Text="-" /></td>
            </tr>
              <tr>
                <td><asp:Button ID="btnJeden" runat="server" Text="1" /></td>
                <td><asp:Button ID="btnDwa" runat="server" Text="2" /></td>
                <td><asp:Button ID="btnTrzy" runat="server" Text="3" /></td>
                <td><asp:Button ID="btnMnozenie" runat="server" Text="*" /></td>
            </tr>  <tr>
                <td><asp:Button ID="btnC" runat="server" Text="C" /></td>
                <td><asp:Button ID="btnZero" runat="server" Text="0" /></td>
                <td><asp:Button ID="btnRownasie" runat="server" Text="=" /></td>
                <td><asp:Button ID="btnPodziel" runat="server" Text="/" /></td>
            </tr>
        </table>


    </form>
</body>
</html>
