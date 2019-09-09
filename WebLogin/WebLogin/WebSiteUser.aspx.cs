using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLogin
{
    public partial class WebSiteUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Apresenta mensagem de erro
            if ((Session["usuario"] == null) || (Session["usuario"].ToString() == ""))
            {
                Session["msgErro"] = "Acesso não permitido à página WebSiteUser. " +
                                     "Faça Login e tente novamente";
                Response.Redirect("~\\Login.aspx");
            }
        }
    }
}