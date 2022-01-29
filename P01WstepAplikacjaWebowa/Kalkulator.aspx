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
                <td><asp:Button ID="btnSieden" runat="server" OnClick="btnPrzycisk_Click" Text="7" /></td>
                <td><asp:Button ID="btnOsiem" runat="server"  OnClick="btnPrzycisk_Click" Text="8" /></td>
                <td><asp:Button ID="btnDziewiec" runat="server" OnClick="btnPrzycisk_Click" Text="9" /></td>
                <td><asp:Button ID="btnPlus" runat="server" OnClick="btnPrzycisk_Click" Text="+" /></td>
            </tr>
             <tr>
                <td><asp:Button ID="btnCZtery" runat="server" OnClick="btnPrzycisk_Click" Text="4" /></td>
                <td><asp:Button ID="btnPiec" runat="server" OnClick="btnPrzycisk_Click" Text="5" /></td>
                <td><asp:Button ID="btnSzesc" runat="server" OnClick="btnPrzycisk_Click" Text="6" /></td>
                <td><asp:Button ID="btnMinus" runat="server" OnClick="btnPrzycisk_Click" Text="-" /></td>
            </tr>
              <tr>
                <td><asp:Button ID="btnJeden" OnClick="btnJeden_Click" runat="server" Text="1" /></td>
                <td><asp:Button ID="btnDwa" OnClick="btnPrzycisk_Click" runat="server" Text="2" /></td>
                <td><asp:Button ID="btnTrzy" OnClick="btnPrzycisk_Click" runat="server" Text="3" /></td>
                <td><asp:Button ID="btnMnozenie" runat="server" OnClick="btnPrzycisk_Click" Text="*" /></td>
            </tr>  <tr>
                <td><asp:Button ID="btnC" runat="server" Text="C" /></td>
                <td><asp:Button ID="btnZero" OnClick="btnPrzycisk_Click" runat="server" Text="0" /></td>
                <td><asp:Button ID="btnRownasie" runat="server" OnClick="btnRownasie_Click" Text="=" /></td>
                <td><asp:Button ID="btnPodziel" OnClick="btnPrzycisk_Click" runat="server" Text="/" /></td>
            </tr>
        </table>


    </form>
</body>
</html>
