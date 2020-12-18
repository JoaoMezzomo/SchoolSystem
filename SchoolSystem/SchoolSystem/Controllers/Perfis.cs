using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SchoolSystem.Models;

namespace SchoolSystem.Controllers
{
    public class Perfis
    {
        private static Controllers.Sessions SessionsSite = new Controllers.Sessions();

        public static Int64 BuscarMeuIDPERFIL()
        {
            string login = SessionsSite.CAD_PERFIS_LOGIN;

            List<CAD_PERFIS> listaPerfil = CAD_PERFIS.SELECT_WHERE(string.Format("WHERE LOGIN = '{0}'", login));

            if (listaPerfil.Count > 0)
            {
                return listaPerfil[0].IDPERFIL;
            }
            else
            {
                return 0;
            }
        }

        public static Int64 BuscarIDPERFIL(string login) 
        {
            List<CAD_PERFIS> listaPerfil = CAD_PERFIS.SELECT_WHERE(string.Format("WHERE LOGIN = '{0}'", login));

            if (listaPerfil.Count > 0)
            {
                return listaPerfil[0].IDPERFIL;
            }
            else
            {
                return 0;
            }
        }

        public static CAD_PERFIS BuscarDadosPerfil(Int64 idPerfil) 
        {
            List<CAD_PERFIS> listaPerfil = CAD_PERFIS.SELECT_WHERE(string.Format("WHERE IDPERFIL = '{0}'", idPerfil));

            if (listaPerfil.Count > 0)
            {
                return listaPerfil[0];
            }
            else
            {
                return new CAD_PERFIS();
            }
        }
    }
}