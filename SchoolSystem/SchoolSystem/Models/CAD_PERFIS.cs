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
			string query = "SELECT * FROM CAD_PERFIS \n" + where;

			DataSet dataSet = DataBase.SELECT(query);

			return GerarLista(dataSet);
		}

		public static List<CAD_PERFIS> SELECT_JOIN_WHERE(string join, string where)
		{
			string query = "SELECT * FROM CAD_PERFIS \n" + join + " \n" + where;

			DataSet dataSet = DataBase.SELECT(query);

			return GerarLista(dataSet);
		}

		public static void INSERT(CAD_PERFIS item) 
		{
			string DB_LOGIN;
			string DB_SENHA;
			string DB_IDPERMISSAO;
			string DB_NOME;
			string DB_IDADE;
			string DB_CPF;
			string DB_SEXO;
			string DB_ENDERECO;
			string DB_TELEFONE_FIXO;
			string DB_TELEFONE_CELULAR;
			string DB_NOME_MAE;
			string DB_NOME_PAI;
			string DB_EXCLUIDO;

			DB_LOGIN = "'" + item.LOGIN + "'";
			DB_SENHA = "'" + item.SENHA + "'";
			DB_IDPERMISSAO = item.IDPERMISSAO.ToString();
			DB_NOME = "'" + item.NOME + "'";
			DB_IDADE = item.IDADE > 0 ? item.IDADE.ToString() : "NULL";
			DB_CPF =  !string.IsNullOrEmpty(item.CPF) ? "'" + item.CPF + "'" : "NULL";
			DB_SEXO = item.SEXO == 'M' || item.SEXO == 'F' ? "'" + item.SEXO.ToString() + "'" : "NULL";
			DB_ENDERECO = !string.IsNullOrEmpty(item.ENDERECO) ? "'" + item.ENDERECO + "'" : "NULL";
			DB_TELEFONE_FIXO = !string.IsNullOrEmpty(item.TELEFONE_FIXO) ? "'" + item.TELEFONE_FIXO + "'" : "NULL";
			DB_TELEFONE_CELULAR = !string.IsNullOrEmpty(item.TELEFONE_CELULAR) ? "'" + item.TELEFONE_CELULAR + "'" : "NULL";
			DB_NOME_MAE = !string.IsNullOrEmpty(item.NOME_MAE) ? "'" + item.NOME_MAE + "'" : "NULL";
			DB_NOME_PAI = !string.IsNullOrEmpty(item.NOME_PAI) ? "'" + item.NOME_PAI + "'" : "NULL";
			DB_EXCLUIDO = item.EXCLUIDO == true ? "1" : "0";

			string query = "INSERT INTO CAD_PERFIS \n";
			query += "(LOGIN, SENHA, IDPERMISSAO, NOME, IDADE, CPF, SEXO, ENDERECO, TELEFONE_FIXO, TELEFONE_CELULAR, NOME_MAE, NOME_PAI, EXCLUIDO) \n";
			query += "VALUES \n";
			query += string.Format("({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12})"
				, DB_LOGIN
				, DB_SENHA
				, DB_IDPERMISSAO
				, DB_NOME
				, DB_IDADE
				, DB_CPF
				, DB_SEXO
				, DB_ENDERECO
				, DB_TELEFONE_FIXO
				, DB_TELEFONE_CELULAR
				, DB_NOME_MAE
				, DB_NOME_PAI
				, DB_EXCLUIDO
				) ;

			DataBase.INSERT_UPDATE_DELETE(query);
		}

		public static void UPDATE(CAD_PERFIS item)
		{
			string DB_LOGIN;
			string DB_SENHA;
			string DB_IDPERMISSAO;
			string DB_NOME;
			string DB_IDADE;
			string DB_CPF;
			string DB_SEXO;
			string DB_ENDERECO;
			string DB_TELEFONE_FIXO;
			string DB_TELEFONE_CELULAR;
			string DB_NOME_MAE;
			string DB_NOME_PAI;
			string DB_EXCLUIDO;

			DB_LOGIN = "'" + item.LOGIN + "'";
			DB_SENHA = "'" + item.SENHA + "'";
			DB_IDPERMISSAO = item.IDPERMISSAO.ToString();
			DB_NOME = "'" + item.NOME + "'";
			DB_IDADE = item.IDADE > 0 ? item.IDADE.ToString() : "NULL";
			DB_CPF = !string.IsNullOrEmpty(item.CPF) ? "'" + item.CPF + "'" : "NULL";
			DB_SEXO = item.SEXO == 'M' || item.SEXO == 'F' ? "'" + item.SEXO.ToString() + "'" : "NULL";
			DB_ENDERECO = !string.IsNullOrEmpty(item.ENDERECO) ? "'" + item.ENDERECO + "'" : "NULL";
			DB_TELEFONE_FIXO = !string.IsNullOrEmpty(item.TELEFONE_FIXO) ? "'" + item.TELEFONE_FIXO + "'" : "NULL";
			DB_TELEFONE_CELULAR = !string.IsNullOrEmpty(item.TELEFONE_CELULAR) ? "'" + item.TELEFONE_CELULAR + "'" : "NULL";
			DB_NOME_MAE = !string.IsNullOrEmpty(item.NOME_MAE) ? "'" + item.NOME_MAE + "'" : "NULL";
			DB_NOME_PAI = !string.IsNullOrEmpty(item.NOME_PAI) ? "'" + item.NOME_PAI + "'" : "NULL";
			DB_EXCLUIDO = item.EXCLUIDO == true ? "1" : "0";

			string query = "UPDATE CAD_PERFIS \n";
			query += "SET \n";
			query += string.Format("LOGIN = {0}, SENHA = {1}, IDPERMISSAO = {2}, NOME = {3}, IDADE = {4}, CPF = {5}, SEXO = {6}, ENDERECO = {7}, TELEFONE_FIXO = {8}, TELEFONE_CELULAR = {9}, NOME_MAE = {10}, NOME_PAI = {11}, EXCLUIDO = {12} \n"
				, DB_LOGIN
				, DB_SENHA
				, DB_IDPERMISSAO
				, DB_NOME
				, DB_IDADE
				, DB_CPF
				, DB_SEXO
				, DB_ENDERECO
				, DB_TELEFONE_FIXO
				, DB_TELEFONE_CELULAR
				, DB_NOME_MAE
				, DB_NOME_PAI
				, DB_EXCLUIDO
				);
			query += "WHERE IDPERFIL = " + item.IDPERFIL;

			DataBase.INSERT_UPDATE_DELETE(query);
		}

		public static void DELETE(CAD_PERFIS item)
		{

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

					item.TELEFONE_FIXO = linha["TELEFONE_FIXO"] != DBNull.Value ? linha["TELEFONE_FIXO"].ToString() : null;

					item.TELEFONE_CELULAR = linha["TELEFONE_CELULAR"] != DBNull.Value ? linha["TELEFONE_CELULAR"].ToString() : null;

					item.NOME_MAE = linha["NOME_MAE"] != DBNull.Value ? linha["NOME_MAE"].ToString() : null;

					item.NOME_PAI = linha["NOME_PAI"] != DBNull.Value ? linha["NOME_PAI"].ToString() : null;

					item.EXCLUIDO = linha["EXCLUIDO"] != DBNull.Value ? Convert.ToBoolean(linha["EXCLUIDO"]) : false;

					itens.Add(item);
				}
			}

			return itens;
		}
	}
}
