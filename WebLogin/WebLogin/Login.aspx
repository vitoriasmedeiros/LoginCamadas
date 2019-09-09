<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebLogin.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                    <h4 style="font-size: medium">LOGIN</h4>
        <hr />
        <p style="color: #FF0000" >
            <asp:Literal runat="server" ID="LabelMsgErro" />
        </p>                
        <div style="margin-bottom:10px">
            <asp:Label runat="server" >Usuário</asp:Label>
            <div>
                <asp:TextBox runat="server" ID="TextBoxUsuario" />                
            </div>
        </div>
        <div style="margin-bottom:10px">
            <asp:Label runat="server" >Senha</asp:Label>
            <div>
                <asp:TextBox runat="server" ID="TextBoxSenha" TextMode="Password" />                
            </div>
        </div>        
        <div>
            <div>
                <asp:Button runat="server" Text="Cadastrar" OnClick="Button1_Click"  />
            </div>
        </div>

        </div>
    </form>
</body>
</html>