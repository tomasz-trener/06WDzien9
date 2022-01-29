<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P02AplikacjaZawodnicy.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <style>
        .dvOpcje input{
            width:100px;
            margin-top:5px;
        }

        select{
            height:400px;
        }
    </style>

    <form id="form1" runat="server">
       
        <div style="float:left; margin-right:10px">
             <asp:ListBox ID="lbDane" runat="server"></asp:ListBox>
        </div>
        <div class="dvOpcje"  >
            <asp:Button ID="btnWczytaj" OnClick="btnWczytaj_Click" runat="server" Text="Wczytaj" /> <br />
            <asp:Button ID="btnDodaj" OnClick="btnDodaj_Click" runat="server" Text="Dodaj" /> <br />
            <asp:Button ID="btnEdytuj" OnClick="btnEdytuj_Click" runat="server" Text="Edytuj" /> <br />
            <asp:Button ID="btnUsun" OnClick="btnUsun_Click" runat="server" Text="Usun" /> <br />
        </div>
        
       //http://tomaszles.pl/2019/03/17/szablon-dashboard/


    </form>
</body>
</html>
