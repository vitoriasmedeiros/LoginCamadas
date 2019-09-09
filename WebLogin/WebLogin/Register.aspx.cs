using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLogin
{
    public partial class Register : System.Web.UI.Page
    {
     

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Valida senha
            if (TextBoxSenha.Text != TextBoxSenhaConfirmar.Text)
            {
                Session["msgErro"] = "Senha não confere";
                Response.Redirect("~\\Register.aspx");
            }
            Session["msgErro"] = "";
            // Instancia objeto DAL
            DAL.DALUsuario aDALUsuario = new DAL.DALUsuario();
            // Critografa senha
            string senhaMD5 = GerarHashMd5(TextBoxSenha.Text);
            // Instancia objeto Modelo
            Modelo.Usuario aUsuario = new Modelo.Usuario(0, TextBoxUsuario.Text, senhaMD5, 0);
            // Insere usuário
            aDALUsuario.Insert(aUsuario);
            // Grava na sessão
            Session["Usuario"] = aUsuario.usuario;
            Response.Redirect("~\\WebSiteMenu.aspx");


        }
        protected void Page_Load(object sender, EventArgs e)
        {
            // Apresenta mensagem de erro
            if ((Session["msgErro"] != null) && (Session["msgErro"].ToString() != ""))
            {
                LabelMsgErro.Text = Session["msgErro"].ToString();
            }
        }

        public string GerarHashMd5(string input)
        {
            MD5 md5Hash = MD5.Create();
            // Converter a String para array de bytes, que é como a biblioteca trabalha.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            // Cria-se um StringBuilder para recompôr a string.
            StringBuilder sBuilder = new StringBuilder();
            // Loop para formatar cada byte como uma String em hexadecimal
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        
    }
}