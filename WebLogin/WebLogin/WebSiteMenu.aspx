<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebSiteMenu.aspx.cs" Inherits="WebLogin.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="LabelUsuario" runat="server" Text="Menu" ></asp:Label>
        <hr />
        <div>
            <asp:HyperLink ID="HyperLink2"  NavigateUrl="~/Register.aspx" runat="server">Cadastar Usúario</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Login.aspx" runat="server">Login</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink3"  NavigateUrl="~/WebSiteUser.aspx" runat="server">Pagina de usuario autenticado</asp:HyperLink>
        </div>
    </form>
</body>
</html>
