using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchoolSystem
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Controllers.Login.VerificarLogin())
                {
                    Response.Redirect("/Default.aspx");
                }
            }
        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            if (Controllers.Login.RealizarLogin(txtLogin.Text, txtSenha.Text))
            {
                lblSenhaIncorreta.Visible = false;
                Response.Redirect("/Default.aspx");
            }
            else
            {
                lblSenhaIncorreta.Visible = true;
            }
        }

        private void MostrarMensagem(string mensagem) 
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", string.Format("alert('{0}')", mensagem), true);
        }
    }
}