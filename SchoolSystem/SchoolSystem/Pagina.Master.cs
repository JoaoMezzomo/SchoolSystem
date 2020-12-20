using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SchoolSystem.Controllers;

namespace SchoolSystem
{
    public partial class Pagina : System.Web.UI.MasterPage
    {
        private static Controllers.Sessions SessionsSite = new Controllers.Sessions();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Global.CookieVerificarPermissao(this.Request))
            {
                Controllers.Login.RealizarLogout();
                Response.Redirect("/Views/Avisos/Cookies.aspx");
            }
            else if (!Controllers.Login.VerificarLogin())
            {
                Controllers.Login.RealizarLogout();
                Response.Redirect("/Login.aspx");
            }
            else
            {
                CarregarPermissaoMenu();
            }
        }

        private void CarregarPermissaoMenu() 
        {
            if (SessionsSite.CAD_PERFIS_IDPERMISSAO != (int)Enums.Permissoes.Admin)
            {
                linkOutrosPerfis.Visible = false;
                linkCadastroPerfil.Visible = false;
            }
        }

        public void MostrarMensagem(string mensagem)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", string.Format("alert('{0}')", mensagem), true);
        }

        protected void linkSair_Click(object sender, EventArgs e) 
        {
            Controllers.Login.RealizarLogout();
            Response.Redirect("/Login.aspx");
        }

        protected void linkMeuPerfil_Click(object sender, EventArgs e) 
        {
            Global.CookieCriar(Global.CK_IDPERFIL, Perfis.BuscarMeuIDPERFIL().ToString(), this.Request, this.Response);

            Response.Redirect("/Views/Perfis/Perfis_Edita.aspx");
        }

        protected void linkCadastroPerfil_Click(object sender, EventArgs e)
        {
            Global.CookieCriar(Global.CK_IDPERFIL, "0", this.Request, this.Response);

            Response.Redirect("/Views/Perfis/Perfis_Edita.aspx");
        }

        
    }
}