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
                SessionsSite.Login = login;
                SessionsSite.Senha = senha;

                return true;
            }
            else
            {
                SessionsSite.Login = "";
                SessionsSite.Senha = "";
                return false;
            }
        }

        public static bool VerificarLogin() 
        {
            try
            {
                string login = SessionsSite.Login;
                string senha = SessionsSite.Senha;

                if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(senha))
                {
                    return true;
                }
                else
                {
                    SessionsSite.Login = "";
                    SessionsSite.Senha = "";

                    return false;
                }
            }
            catch (Exception)
            {
                SessionsSite.Login = "";
                SessionsSite.Senha = "";

                return false;
            }
        }
    }
}