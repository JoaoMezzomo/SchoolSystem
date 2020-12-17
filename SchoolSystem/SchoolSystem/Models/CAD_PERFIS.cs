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
		public int CPF;
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
            if (!where.Contains("WHERE") && !where.Contains("where") && !where.Contains("Where"))
            {
				where = "WHERE " + where;
            }

			string query = "SELECT * FROM CAD_PERFIS\n" + where;

			DataSet dataSet = DataBase.SELECT(query);

			return GerarLista(dataSet);
		}

		public static List<CAD_PERFIS> SELECT_JOIN_WHERE(string join, string where)
		{
			if (!where.Contains("WHERE") && !where.Contains("where") && !where.Contains("Where"))
			{
				where = "WHERE " + where;
			}

			string query = "SELECT * FROM CAD_PERFIS\n" + join + "\n" + where;

			DataSet dataSet = DataBase.SELECT(query);

			return GerarLista(dataSet);
		}

		private static List<CAD_PERFIS> GerarLista(DataSet dataSet) 
		{
			List<CAD_PERFIS> perfis = new List<CAD_PERFIS>();

			foreach (DataTable tabela in dataSet.Tables)
			{
				foreach (DataRow linha in tabela.Rows)
				{
					CAD_PERFIS perfil = new CAD_PERFIS();

					perfil.IDPERFIL = Convert.ToInt64(linha["IDPERFIL"]);

					perfil.LOGIN = linha["LOGIN"].ToString();

					perfil.SENHA = linha["SENHA"].ToString();

					perfil.IDPERMISSAO = Convert.ToInt32(linha["IDPERMISSAO"]);

					perfil.NOME = linha["NOME"].ToString();

					if (linha["IDADE"] != DBNull.Value)
					{
						perfil.IDADE = Convert.ToInt32(linha["IDADE"]);
					}

					if (linha["CPF"] != DBNull.Value)
					{
						perfil.CPF = Convert.ToInt32(linha["CPF"]);
					}

					if (linha["SEXO"] != DBNull.Value)
					{
						perfil.SEXO = Convert.ToChar(linha["SEXO"]);
					}

					perfil.ENDERECO = linha["ENDERECO"] != DBNull.Value ? linha["ENDERECO"].ToString() : null;

					perfil.ENDERECO = linha["TELEFONE_FIXO"] != DBNull.Value ? linha["TELEFONE_FIXO"].ToString() : null;

					perfil.ENDERECO = linha["TELEFONE_CELULAR"] != DBNull.Value ? linha["TELEFONE_CELULAR"].ToString() : null;

					perfil.ENDERECO = linha["NOME_MAE"] != DBNull.Value ? linha["NOME_MAE"].ToString() : null;

					perfil.ENDERECO = linha["NOME_PAI"] != DBNull.Value ? linha["NOME_PAI"].ToString() : null;

					perfil.EXCLUIDO = linha["EXCLUIDO"] != DBNull.Value ? Convert.ToBoolean(linha["EXCLUIDO"]) : false;

					perfis.Add(perfil);
				}
			}

			return perfis;
		}
	}
}
