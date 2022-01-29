<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P01WstepAplikacjaWebowa.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      
        <asp:Button ID="btnStart" runat="server" OnClick="btnStart_Click" Text="Naciśnij mnie" />

        <asp:Label ID="lblWynik" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
