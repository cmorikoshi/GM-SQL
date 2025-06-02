using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GM_MODEL;

namespace GM_BLL
{
    public class CE0200BLL
    {

        #region CONEXÃO

        private SqlConnection GetConnection()
        {
            string caminhoBanco = null;
            if (System.IO.File.Exists(@"C:\sgasql\mdsql\ACESSO\keycrypto.txt"))
            {
                string v_keycript = File.ReadAllText(@"C:\sgasql\mdsql\ACESSO\keycrypto.txt");
                string v_conexao = File.ReadAllText(@"C:\sgasql\mdsql\ACESSO\wayconnect.txt");
                caminhoBanco = Util.Descriptografar(v_conexao, v_keycript);
            }
            string strConnection = caminhoBanco;
            SqlConnection connection = new SqlConnection(strConnection);
            connection.Open();
            return connection;
        }

        private void CloseConnection(SqlConnection connection)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        #endregion CONEXÃO

        #region INSERT-UPDATE-DELETE METHODS


        public void ExcluirIDCadastroMateriaisCE0200(CE0200MODEL ce0200model)
        {
            #region STRING_QUERY

            StringBuilder Query = new StringBuilder();

            Query.Append("DELETE FROM CE0200 ");
            Query.Append("WHERE C_CODMAT = @C_CODMAT");

            #endregion STRING_QUERY

            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();

            command.Parameters.AddWithValue("@C_CODMAT", ce0200model.C_CODMAT);

            try
            {
                connection = GetConnection();
                command.CommandText = Query.ToString();
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.ExecuteNonQuery();

            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                CloseConnection(connection);
            }
        }


        #endregion INSERT-UPDATE-DELETE METHODS
    }
}
