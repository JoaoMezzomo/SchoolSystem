using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SchoolSystem.Models;

namespace SchoolSystem.Controllers
{
    public class Login
    {
        private static Sessions SessionsSite = new Sessions();

        public static bool RealizarLogin(string login, string senha) 
        {
            string where = string.Format("WHERE LOGIN = '{0}' AND SENHA = '{1}'", login, senha);

            List<CAD_PERFIS> listaPerfil = CAD_PERFIS.SELECT_WHERE(where);

            if (listaPerfil.Count > 0)
            {
                SessionsSite.CAD_PERFIS_LOGIN = login;
                SessionsSite.CAD_PERFIS_SENHA = senha;
                SessionsSite.CAD_PERFIS_IDPERMISSAO = listaPerfil[0].IDPERMISSAO;

                return true;
            }
            else
            {
                SessionsSite.CAD_PERFIS_LOGIN = "";
                SessionsSite.CAD_PERFIS_SENHA = "";
                SessionsSite.CAD_PERFIS_IDPERMISSAO = 0;
                return false;
            }
        }

        public static void RealizarLogout() 
        {
            SessionsSite.CAD_PERFIS_LOGIN = "";
            SessionsSite.CAD_PERFIS_SENHA = "";
            SessionsSite.CAD_PERFIS_IDPERMISSAO = 0;
        }

        public static bool VerificarLogin() 
        {
            try
            {
                string login = SessionsSite.CAD_PERFIS_LOGIN;
                string senha = SessionsSite.CAD_PERFIS_SENHA;

                if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(senha))
                {
                    return true;
                }
                else
                {
                    SessionsSite.CAD_PERFIS_LOGIN = "";
                    SessionsSite.CAD_PERFIS_SENHA = "";
                    SessionsSite.CAD_PERFIS_IDPERMISSAO = 0;

                    return false;
                }
            }
            catch (Exception)
            {
                SessionsSite.CAD_PERFIS_LOGIN = "";
                SessionsSite.CAD_PERFIS_SENHA = "";
                SessionsSite.CAD_PERFIS_IDPERMISSAO = 0;
                return false;
            }
        }
    }
}