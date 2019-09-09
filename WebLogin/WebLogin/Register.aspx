<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebLogin.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Cadastro de Usuário"></asp:Label>
            <hr />
            <asp:Label ID="LabelMsgErro" runat="server" ForeColor="Red"></asp:Label>
            <div>
                <asp:Label ID="Label2" runat="server" Text="Usuario"/>
                <br />
                <asp:TextBox ID="TextBoxUsuario" runat="server"/>
            </div>
            <div>
                <asp:Label ID="Label3" runat="server" Text="Senha"/>
                <br />
                <asp:TextBox ID="TextBoxSenha" runat="server" TextMode="Password"/>
            </div>
            <div>
                <asp:Label ID="Label4" runat="server" Text="Confirmar senha"/>
                <br />
                <asp:TextBox ID="TextBoxSenhaConfirmar" runat="server" TextMode="Password"/>
            </div>
            <asp:Button ID="Button" runat="server" Text="Cadastrar" OnClick="Button1_Click"  />
        </div>
    </form>
</body>
</html>

