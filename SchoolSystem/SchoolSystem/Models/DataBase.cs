using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace SchoolSystem.Models
{
    public class DataBase
    {
        public static string MensagemDeErro;

        private static string BuscarConnectionString()
        {
            return WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString.ToString();
        }

        public static DataSet SELECT(string query) 
        {
            MensagemDeErro = "";

            DataSet dataSet = new DataSet();

            try
            {
                string connectionString = BuscarConnectionString();

                SqlConnection connection = new SqlConnection(connectionString);

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                dataAdapter.Fill(dataSet);

            }
            catch (Exception ex)
            {
                MensagemDeErro = ex.Message;
            }

            return dataSet;
        }

        public static void INSERT_UPDATE_DELETE(string query)
        {
            MensagemDeErro = "";

            try
            {
                string connectionString = BuscarConnectionString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MensagemDeErro = ex.Message;
            }
        }
    }
}
