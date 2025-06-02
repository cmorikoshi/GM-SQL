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
    public class CM0600BLL
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

        public void InserirProdutoCM0600(CM0600MODEL cm0600model)
        {
            #region STRING_QUERY

            StringBuilder Query = new StringBuilder();

            Query.Append("INSERT INTO CM0600 (");
            Query.Append("C_CODEQU, ");
            Query.Append("C_DESEQU, ");
            Query.Append("C_TIPEQU, ");
            Query.Append("C_NUMDES)");
            Query.Append("VALUES( ");
            Query.Append("@C_CODEQU, ");
            Query.Append("@C_DESEQU, ");
            Query.Append("@C_TIPEQU, ");
            Query.Append("@C_NUMDES)");

            #endregion STRING_QUERY

            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();

            command.Parameters.AddWithValue("@C_CODEQU", cm0600model.C_CODEQU);
            command.Parameters.AddWithValue("@C_DESEQU", cm0600model.C_DESEQU);
            command.Parameters.AddWithValue("@C_TIPEQU", cm0600model.C_TIPEQU);
            command.Parameters.AddWithValue("@C_NUMDES", cm0600model.C_NUMDES);

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

        #region RETURN METHODS - CM0600

        public DataTable RetornarProdutoCM0600(string v_select)
        {
            string Query = "SELECT C_CODEQU, C_DESEQU, C_NUMDES FROM CM0600 " +
                           "WHERE " + v_select + "";
            SqlCommand command = new SqlCommand(Query, GetConnection());
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = GetConnection();

                DataTable dTable = new DataTable("retornarProduto");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dTable);

                return dTable;
            }
            finally
            {
                connection.Close();
            }
        }

        public CM0600MODEL RetornarDadosProdutoCM0600(CM0600MODEL cm0600model, string v_codmat)
        {
            string Query = "SELECT C_CODEQU, C_DESEQU, C_TIPEQU, C_NUMDES FROM CM0600 WHERE C_CODEQU = '" + v_codmat + "'";

            SqlCommand command = new SqlCommand(Query, GetConnection());
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = GetConnection();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    cm0600model.C_CODEQU = reader["C_CODEQU"].ToString();
                    cm0600model.C_DESEQU = reader["C_DESEQU"].ToString();
                    cm0600model.C_TIPEQU = reader["C_TIPEQU"].ToString();
                    cm0600model.C_NUMDES = reader["C_NUMDES"].ToString();
                }
                return cm0600model;
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }


        public string RetornarCODEMP(string v_assina)
        {
            string v_codemp = null;

            string Query = "SELECT C_CODEMP FROM OP0000 WHERE C_APRFIN = '" + v_assina + "'";

            SqlConnection connection = new SqlConnection();
            try
            {
                connection = GetConnection();

                SqlCommand command = new SqlCommand();
                command.CommandText = Query;
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                v_codemp = command.ExecuteScalar().ToString();


            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                CloseConnection(connection);
            }
            return v_codemp;
        }


        #endregion RETURN METHODS - CM0600

    }
}
