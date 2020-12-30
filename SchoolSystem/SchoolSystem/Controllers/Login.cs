using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SchoolSystem.Models;

namespace SchoolSystem.Controllers
{
    public class Login
    {
        private static Criptografia criptografia = new Criptografia();

        public static bool RealizarLogin(string login, string senha, HttpRequest request, HttpResponse response) 
        {
            string where = string.Format("WHERE LOGIN = '{0}' AND SENHA = '{1}'", login, senha);

            List<CAD_PERFIS> listaPerfil = CAD_PERFIS.SELECT("*", where);
            
            if (listaPerfil.Count > 0)
            {
                Global.CookieCriar(Global.CK_LOGIN, criptografia.Encriptar(login), request, response);
                Global.CookieCriar(Global.CK_IDPERMISSAO, listaPerfil[0].IDPERMISSAO.ToString(), request, response);
                return true;
            }
            else
            {
                Global.CookieCriar(Global.CK_LOGIN, "", request, response);
                Global.CookieCriar(Global.CK_IDPERMISSAO, "", request, response);
                return false;
            }
        }

        public static void RealizarLogout(HttpRequest request, HttpResponse response) 
        {
            Global.CookieCriar(Global.CK_LOGIN, "", request, response);
            Global.CookieCriar(Global.CK_IDPERMISSAO, "", request, response);
        }

        public static bool VerificarLogin(HttpRequest request, HttpResponse response) 
        {
            try
            {
                string login = Global.CookieBuscarValor(Global.CK_LOGIN, request);

                if (!string.IsNullOrEmpty(login))
                {
                    return true;
                }
                else
                {
                    Global.CookieCriar(Global.CK_LOGIN, "", request, response);
                    Global.CookieCriar(Global.CK_IDPERMISSAO, "", request, response);
                    return false;
                }
            }
            catch (Exception)
            {
                Global.CookieCriar(Global.CK_LOGIN, "", request, response);
                Global.CookieCriar(Global.CK_IDPERMISSAO, "", request, response);
                return false;
            }
        }
    }
}