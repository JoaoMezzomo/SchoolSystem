using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System.Web.SessionState;

namespace SchoolSystem
{
    public class Global : System.Web.HttpApplication
    {
        public static string CK_LOGIN = "CK_LOGIN";
        public static string CK_IDPERMISSAO = "CK_IDPERMISSAO";
        public static string CK_PAGINAANTERIOR = "CK_PAGINAANTERIOR";
        public static string CK_IDPERFIL = "CK_IDPERFIL";
        public static string CK_FILTRO_1 = "CK_FILTRO_1";
        public static string CK_FILTRO_2 = "CK_FILTRO_2";

        public static bool CookieVerificarPermissao(HttpRequest request)
        {
            if (request.Cookies.Count > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void CookieCriar(string nomeCookie, string valor, HttpRequest request, HttpResponse response)
        {
            HttpCookie cookie = new HttpCookie(nomeCookie);

            cookie.Value = valor;

            DateTime dtNow = DateTime.Now.AddMonths(1);

            cookie.Expires = dtNow;

            response.Cookies.Add(cookie);
        }

        public static string CookieBuscarValor(string nomeCookie, HttpRequest request)
        {
            HttpCookie cookie = request.Cookies[nomeCookie];

            return cookie != null ? cookie.Value.ToString() : "";
        }

        public static void MostrarMensagem(Page page, string mensagem) 
        {
            ScriptManager.RegisterClientScriptBlock(page, page.GetType(), "alertMessage", string.Format("alert('{0}')", mensagem), true);
        }

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}