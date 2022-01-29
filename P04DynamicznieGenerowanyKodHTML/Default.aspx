<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P04DynamicznieGenerowanyKodHTML.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     
        <div id="przyklad1" style="float:left; margin-right:20px">
        <%
            // kod w c# 
            int n = 10;

            for (int i = 0; i < n; i++)
            {
                Response.Write("<p>"+Napis+"</p>");
            }

            %>

        ala ma kota 

    </div>

        <div id="przyklad2">

            <%
                for (int i = 0; i < n; i++)
                { %>
                     
                <p><%= Napis %></p>

             <% }
                %>

        </div>

    </form>
</body>
</html>
