using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SchoolSystem.Models;
using System.Data;

namespace SchoolSystem.Controllers
{
    public class Perfis
    {
        private static Controllers.Sessions SessionsSite = new Controllers.Sessions();

        public static Int64 BuscarMeuIDPERFIL()
        {
            string login = SessionsSite.CAD_PERFIS_LOGIN;

            List<CAD_PERFIS> listaPerfil = CAD_PERFIS.SELECT("*" ,string.Format("WHERE LOGIN = '{0}'", login));

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
            List<CAD_PERFIS> listaPerfil = CAD_PERFIS.SELECT("*", string.Format("WHERE LOGIN = '{0}'", login));

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
            List<CAD_PERFIS> listaPerfil = CAD_PERFIS.SELECT("*", string.Format("WHERE IDPERFIL = '{0}'", idPerfil));

            if (listaPerfil.Count > 0)
            {
                return listaPerfil[0];
            }
            else
            {
                return new CAD_PERFIS();
            }
        }

        public static List<CAD_PERFIS> BuscarTodosPerfis()
        {
            List<CAD_PERFIS> listaPerfil = CAD_PERFIS.SELECT("*", "ORDER BY LOGIN");

            return listaPerfil;
        }

        public static DataTable BuscarTodosPerfisTabela_NaoExcluidos() 
        {
            string chave = "CAD_PERFIS.IDPERFIL, CAD_PERFIS.LOGIN, CAD_PERMISSOES.NOME AS 'NOME_PERMISSAO'";

            string filtro = "INNER JOIN CAD_PERMISSOES ON CAD_PERMISSOES.IDPERMISSAO = CAD_PERFIS.IDPERMISSAO \n";
            filtro += "WHERE CAD_PERFIS.EXCLUIDO <> 1 \n";
            filtro += "ORDER BY CAD_PERFIS.LOGIN";

            return CAD_PERFIS.SELECT_DATATABLE(chave, filtro);
        }

        public static DataTable BuscarTodosPerfisTabela_Excluidos()
        {
            string chave = "CAD_PERFIS.IDPERFIL, CAD_PERFIS.LOGIN, CAD_PERMISSOES.NOME AS 'NOME_PERMISSAO'";

            string filtro = "INNER JOIN CAD_PERMISSOES ON CAD_PERMISSOES.IDPERMISSAO = CAD_PERFIS.IDPERMISSAO \n";
            filtro += "WHERE CAD_PERFIS.EXCLUIDO = 1 \n";
            filtro += "ORDER BY CAD_PERFIS.LOGIN";

            return CAD_PERFIS.SELECT_DATATABLE(chave, filtro);
        }

        public static void Salvar(CAD_PERFIS Perfil) 
        {
            if (Perfil.IDPERFIL != 0)
            {
                CAD_PERFIS.UPDATE(Perfil);
            }
            else
            {
                CAD_PERFIS.INSERT(Perfil);
            }
        }
    }
}