using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace WebLogin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Apresenta mensagem de erro
            if ((Session["msgErro"] != null) && (Session["msgErro"].ToString() != ""))
            {
                LabelMsgErro.Text = Session["msgErro"].ToString();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Instancia objeto DAL
            DAL.DALUsuario aDALUsuario = new DAL.DALUsuario();

            // Valida Usuario
            List<Modelo.Usuario> aListUsuario = aDALUsuario.Select(TextBoxUsuario.Text);
            if (aListUsuario.Count == 0)
            {
                Session["msgErro"] = "Usuário não cadastrado";
                Response.Redirect("~\\Login.aspx");
            }

            // Critografa senha
            string senhaMD5 = GerarHashMd5(TextBoxSenha.Text);
            // Le usuário da Lista
            Modelo.Usuario aUsuario = aListUsuario[0];
            // Valida Senha
            if (aUsuario.senha != senhaMD5)
            {
                Session["msgErro"] = "Senha Inválida";
                Response.Redirect("~\\Login.aspx");
            }
            // Salva usuário na sessão
            Session["msgErro"] = "";
            Session["usuario"] = aUsuario.usuario;
            Response.Redirect("~\\WebSiteMenu.aspx");
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

        protected void Unnamed3_Click(object sender, EventArgs e)
        {

        }
    }
}