<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P05PrzetwarzanieDanychAsynchroniczne.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Liczba 1"></asp:Label>
        <asp:TextBox ID="txtLiczba1" runat="server"></asp:TextBox>
       
        
        <asp:Label ID="Label2" runat="server" Text="Liczba 2"></asp:Label>
        <asp:TextBox ID="txtLiczba2" runat="server"></asp:TextBox>

        <asp:Button ID="btnWynik" OnClick="btnWynik_Click" runat="server" Text="Wynik" />
        <asp:Label ID="lblWynik" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
