using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace SchoolSystem.Models
{
    public class CAD_PERMISSOES
    {
        public int IDPERMISSAO;
        public string NOME;
        public bool EXCLUIDO;

		public static List<CAD_PERMISSOES> SELECT_ALL()
		{
			string query = "SELECT * FROM CAD_PERMISSOES";

			DataSet dataSet = DataBase.SELECT(query);

			return GerarLista(dataSet);
		}

		public static List<CAD_PERMISSOES> SELECT_WHERE(string where)
		{
			string query = "SELECT * FROM CAD_PERMISSOES\n" + where;

			DataSet dataSet = DataBase.SELECT(query);

			return GerarLista(dataSet);
		}

		public static List<CAD_PERMISSOES> SELECT_JOIN_WHERE(string join, string where)
		{
			string query = "SELECT * FROM CAD_PERMISSOES\n" + join + "\n" + where;

			DataSet dataSet = DataBase.SELECT(query);

			return GerarLista(dataSet);
		}

		private static List<CAD_PERMISSOES> GerarLista(DataSet dataSet)
		{
			List<CAD_PERMISSOES> itens = new List<CAD_PERMISSOES>();

			foreach (DataTable tabela in dataSet.Tables)
			{
				foreach (DataRow linha in tabela.Rows)
				{
					CAD_PERMISSOES item = new CAD_PERMISSOES();

					item.IDPERMISSAO = Convert.ToInt32(linha["IDPERMISSAO"]);

					item.NOME = linha["NOME"].ToString();

					item.EXCLUIDO = linha["EXCLUIDO"] != DBNull.Value ? Convert.ToBoolean(linha["EXCLUIDO"]) : false;

					itens.Add(item);
				}
			}

			return itens;
		}
	}
}