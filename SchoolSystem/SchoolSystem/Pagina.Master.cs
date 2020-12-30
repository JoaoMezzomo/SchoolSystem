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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Global.CookieVerificarPermissao(this.Request))
            {
                Controllers.Login.RealizarLogout(this.Request, this.Response);
                Response.Redirect("/Views/Avisos/Cookies.aspx");
            }
            else if (!Controllers.Login.VerificarLogin(this.Request, this.Response))
            {
                Controllers.Login.RealizarLogout(this.Request, this.Response);
                Response.Redirect("/Login.aspx");
            }
            else
            {
                CarregarPermissaoMenu();
            }
        }

        private void CarregarPermissaoMenu() 
        {
            if (Global.CookieBuscarValor(Global.CK_IDPERMISSAO, this.Request) != ((int)Enums.Permissoes.Admin).ToString())
            {
                linkOutrosPerfis.Visible = false;
                linkCadastroPerfil.Visible = false;
            }
        }

        protected void linkSair_Click(object sender, EventArgs e) 
        {
            Controllers.Login.RealizarLogout(this.Request, this.Response);
            Response.Redirect("/Login.aspx");
        }

        protected void linkMeuPerfil_Click(object sender, EventArgs e) 
        {
            Global.CookieCriar(Global.CK_IDPERFIL, Perfis.BuscarMeuIDPERFIL(this.Request).ToString(), this.Request, this.Response);
            Global.CookieCriar(Global.CK_PAGINAANTERIOR, "/Default.aspx", this.Request, this.Response);

            Response.Redirect("/Views/Perfis/Perfis_Edita.aspx");
        }

        protected void linkCadastroPerfil_Click(object sender, EventArgs e)
        {
            Global.CookieCriar(Global.CK_IDPERFIL, "0", this.Request, this.Response);
            Global.CookieCriar(Global.CK_PAGINAANTERIOR, "/Default.aspx", this.Request, this.Response);

            Response.Redirect("/Views/Perfis/Perfis_Edita.aspx");
        }

        protected void linkOutrosPerfis_Click(object sender, EventArgs e)
        {
            Global.CookieCriar(Global.CK_PAGINAANTERIOR, "/Default.aspx", this.Request, this.Response);

            Response.Redirect("/Views/Perfis/Perfis_Lista.aspx");
        }
    }
}