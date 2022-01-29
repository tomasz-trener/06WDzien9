<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SzczegolyView.aspx.cs" Inherits="P02AplikacjaZawodnicy.SzczegolyView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">


        <table>
            <tr>
                <td>Imie</td>
                <td>
                    <asp:TextBox ID="txtImie" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Nazwisko</td>
                <td>
                    <asp:TextBox ID="txtNazwisko" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Kraj</td>
                <td>
                    <asp:TextBox ID="txtKraj" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>DataUrodzenia</td>
                <td>
                    <asp:Calendar ID="calDataUrodzenia" runat="server"></asp:Calendar>
                </td>
            </tr>
            <tr>
                <td>Waga</td>
                <td>
                    <asp:TextBox ID="txtWaga" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Wzrost</td>
                <td>
                    <asp:TextBox ID="txtWzrost" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnZapisz" OnClick="btnZapisz_Click"
                        runat="server"  Text="Zapisz" />
                </td>
            </tr>
        </table>



    </form>
</body>
</html>
