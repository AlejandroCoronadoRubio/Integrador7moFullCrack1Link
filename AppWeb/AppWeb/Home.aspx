<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="AppWeb.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <header></header>

        <div>
            <asp:Button ID="Button1" runat="server" Text="Entrar como cliente" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Height="26px" Text="Entrar como usuario" OnClick="Button2_Click" />
        </div>
        <div>
        <asp:Button ID="Button3" runat="server" Text="Registrar como cliente" OnClick="Button3_Click" />
        <asp:Button ID="Button4" runat="server" Text="Registrar como usuario" OnClick="Button4_Click" />
            </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
