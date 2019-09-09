using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLogin
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Apresenta mensagem de erro
            if ((Session["Usuario"] != null) && (Session["Usuario"].ToString() != ""))
            {
                LabelUsuario.Text = "Olá, " + Session["Usuario"].ToString();
            }

        }

    }
}