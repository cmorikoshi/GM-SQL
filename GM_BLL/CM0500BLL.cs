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
    public class CM0500BLL
    {
        bool v_VerificaExistePalavraChave = false;
        bool v_VerificaPalavraChaveEmUso = false;

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

        public void InserirPalavraChave(CM0500MODEL cm0500model)
        {
            #region STRING_QUERY

            StringBuilder Query = new StringBuilder();

            Query.Append("INSERT INTO CM0500 (");
            Query.Append("C_KEYDYN, ");
            Query.Append("C_CHAPES, ");
            Query.Append("C_CONEST) ");
            Query.Append(" VALUES(");
            Query.Append("@C_KEYDYN, ");
            Query.Append("@C_CHAPES, ");
            Query.Append("@C_CONEST)");



            #endregion STRING_QUERY

            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();

            command.Parameters.AddWithValue("@C_KEYDYN", cm0500model.C_KEYDYN);
            command.Parameters.AddWithValue("@C_CHAPES", cm0500model.C_CHAPES);
            command.Parameters.AddWithValue("@C_CONEST", cm0500model.C_CONEST);

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
        public void AlterarPalavraChave(CM0500MODEL cm0500model, string v_chapesOld)
        {
            #region STRING_QUERY

            StringBuilder Query = new StringBuilder();

            Query.Append("UPDATE CM0500 SET ");
            Query.Append("C_KEYDYN = @C_KEYDYN, ");
            Query.Append("C_CHAPES = @C_CHAPES, ");
            Query.Append("C_CONEST = @C_CONEST");
            Query.Append(" WHERE ");
            Query.Append("C_CHAPES = @C_CHAPES_OLD");

            #endregion STRING_QUERY

            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();

            command.Parameters.AddWithValue("@C_KEYDYN", cm0500model.C_KEYDYN);
            command.Parameters.AddWithValue("@C_CONEST", cm0500model.C_CONEST);
            command.Parameters.AddWithValue("@C_CHAPES", cm0500model.C_CHAPES);

            command.Parameters.AddWithValue("@C_CHAPES_OLD", v_chapesOld);

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
        public void ExcluirPalavraChave(CM0500MODEL cm0500model)
        {
            #region STRING_QUERY

            StringBuilder Query = new StringBuilder();

            Query.Append("DELETE FROM CM0500");
            Query.Append(" WHERE ");
            Query.Append("C_CHAPES = @C_CHAPES");

            #endregion STRING_QUERY

            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();

            command.Parameters.AddWithValue("@C_CHAPES", cm0500model.C_CHAPES);

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


        #region RETURN METHODS - CM0500

        public DataTable RetornarPalavrasChaveCM0500()
        {
            string Query = "SELECT C_CHAPES FROM CM0500 ORDER BY C_CHAPES";
            SqlCommand command = new SqlCommand(Query, GetConnection());
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = GetConnection();

                DataTable daTable = new DataTable("retornarPalavrasChaveCM0500");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(daTable);
                return daTable;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable RetornarPalavrasChaveConsulta(string v_desmat)
        {
            string Query = "SELECT C_CHAPES, C_CONEST FROM CM0500 WHERE C_CHAPES LIKE '%" + v_desmat + "%' ORDER BY C_CHAPES";
            SqlCommand command = new SqlCommand(Query, GetConnection());
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = GetConnection();

                DataTable dTable = new DataTable("retornarPalavraChaveConsulta");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dTable);

                return dTable;
            }
            finally
            {
                connection.Close();
            }
        }

        #endregion RETURN METHODS - CM0500

        #region CHECKING METHODS
        public bool VerificaExistePalavraChave(string v_chapes)
        {
            int v_existePalavraChave = 0;
            v_VerificaExistePalavraChave = false;

            string Query = "SELECT COUNT(*) FROM CM0500 WHERE C_CHAPES = '" + v_chapes + "'";

            SqlCommand command = new SqlCommand(Query, GetConnection());
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = GetConnection();
                {
                    v_existePalavraChave = Convert.ToInt32(command.ExecuteScalar().ToString());
                    if (v_existePalavraChave == 0)
                    {
                        v_VerificaExistePalavraChave = false;
                    }
                    if (v_existePalavraChave > 0)
                    {
                        v_VerificaExistePalavraChave = true;
                    }
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                connection.Close();
            }
            return v_VerificaExistePalavraChave != false;
        }

        public bool VerificaPalavraChaveEmUso(string v_chapes)
        {
            int v_palavraChaveEmUso = 0;
            v_VerificaPalavraChaveEmUso = false;

            string Query = "SELECT COUNT(C_CHAPES) FROM CM0100 WHERE C_CHAPES = '" + v_chapes + "'";

            SqlCommand command = new SqlCommand(Query, GetConnection());
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = GetConnection();
                {
                    v_palavraChaveEmUso = Convert.ToInt32(command.ExecuteScalar().ToString());
                    if (v_palavraChaveEmUso == 0)
                    {
                        v_VerificaPalavraChaveEmUso = false;
                    }
                    if (v_palavraChaveEmUso > 0)
                    {
                        v_VerificaPalavraChaveEmUso = true;
                    }
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                connection.Close();
            }
            return v_VerificaPalavraChaveEmUso != false;
        }


        #endregion CHECKING METHODS

    }
}
