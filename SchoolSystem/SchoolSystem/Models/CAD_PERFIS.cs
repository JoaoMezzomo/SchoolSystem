using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace SchoolSystem.Models
{
    public class CAD_PERFIS
    {
		public Int64 IDPERFIL;
		public string LOGIN;
		public string SENHA;
		public int IDPERMISSAO;
		public string NOME;
		public int IDADE;
		public string CPF;
		public char SEXO;
		public string ENDERECO;
		public string TELEFONE_FIXO;
		public string TELEFONE_CELULAR;
		public string NOME_MAE;
		public string NOME_PAI;
		public bool EXCLUIDO;

		public static List<CAD_PERFIS> SELECT_ALL() 
		{
			string query = "SELECT * FROM CAD_PERFIS";

			DataSet dataSet = DataBase.SELECT(query);

			return GerarLista(dataSet);
		}

		public static List<CAD_PERFIS> SELECT_WHERE(string where)
		{
			string query = "SELECT * FROM CAD_PERFIS\n" + where;

			DataSet dataSet = DataBase.SELECT(query);

			return GerarLista(dataSet);
		}

		public static List<CAD_PERFIS> SELECT_JOIN_WHERE(string join, string where)
		{
			string query = "SELECT * FROM CAD_PERFIS\n" + join + "\n" + where;

			DataSet dataSet = DataBase.SELECT(query);

			return GerarLista(dataSet);
		}

		private static List<CAD_PERFIS> GerarLista(DataSet dataSet) 
		{
			List<CAD_PERFIS> itens = new List<CAD_PERFIS>();

			foreach (DataTable tabela in dataSet.Tables)
			{
				foreach (DataRow linha in tabela.Rows)
				{
					CAD_PERFIS item = new CAD_PERFIS();

					item.IDPERFIL = Convert.ToInt64(linha["IDPERFIL"]);

					item.LOGIN = linha["LOGIN"].ToString();

					item.SENHA = linha["SENHA"].ToString();

					item.IDPERMISSAO = Convert.ToInt32(linha["IDPERMISSAO"]);

					item.NOME = linha["NOME"].ToString();

					if (linha["IDADE"] != DBNull.Value)
					{
						item.IDADE = Convert.ToInt32(linha["IDADE"]);
					}

					if (linha["CPF"] != DBNull.Value)
					{
						item.CPF = linha["CPF"].ToString();
					}

					if (linha["SEXO"] != DBNull.Value)
					{
						item.SEXO = Convert.ToChar(linha["SEXO"]);
					}

					item.ENDERECO = linha["ENDERECO"] != DBNull.Value ? linha["ENDERECO"].ToString() : null;

					item.ENDERECO = linha["TELEFONE_FIXO"] != DBNull.Value ? linha["TELEFONE_FIXO"].ToString() : null;

					item.ENDERECO = linha["TELEFONE_CELULAR"] != DBNull.Value ? linha["TELEFONE_CELULAR"].ToString() : null;

					item.ENDERECO = linha["NOME_MAE"] != DBNull.Value ? linha["NOME_MAE"].ToString() : null;

					item.ENDERECO = linha["NOME_PAI"] != DBNull.Value ? linha["NOME_PAI"].ToString() : null;

					item.EXCLUIDO = linha["EXCLUIDO"] != DBNull.Value ? Convert.ToBoolean(linha["EXCLUIDO"]) : false;

					itens.Add(item);
				}
			}

			return itens;
		}
	}
}
