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
    public class CM0700BLL
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

        #region METHODS
        public void InserirListaCadastroMateriaisCM0700(CM0700MODEL cm0700model)
        {
            #region STRING_QUERY

            StringBuilder Query = new StringBuilder();

            Query.Append("INSERT INTO CM0700 (");
            Query.Append("C_CODEQU, ");
            Query.Append("C_CODMAT, ");
            Query.Append("C_QTDMAT, ");
            Query.Append("C_UNIMED, ");
            Query.Append("C_NUMDES, ");
            Query.Append("C_ITEDES, ");
            Query.Append("C_SEQEQU)");
            Query.Append("VALUES( ");
            Query.Append("@C_CODEQU, ");
            Query.Append("@C_CODMAT, ");
            Query.Append("@C_QTDMAT, ");
            Query.Append("@C_UNIMED, ");
            Query.Append("@C_NUMDES, ");
            Query.Append("@C_ITEDES, ");
            Query.Append("@C_SEQEQU)");

            #endregion STRING_QUERY

            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();

            command.Parameters.AddWithValue("@C_CODEQU", cm0700model.C_CODEQU);
            command.Parameters.AddWithValue("@C_CODMAT", cm0700model.C_CODMAT);
            command.Parameters.AddWithValue("@C_QTDMAT", cm0700model.C_QTDMAT);
            command.Parameters.AddWithValue("@C_UNIMED", cm0700model.C_UNIMED);
            command.Parameters.AddWithValue("@C_NUMDES", cm0700model.C_NUMDES);
            command.Parameters.AddWithValue("@C_ITEDES", cm0700model.C_ITEDES);
            command.Parameters.AddWithValue("@C_SEQEQU", cm0700model.C_SEQEQU);

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

        public void AlterarListaMaterialCM0700(CM0700MODEL cm0700model)
        {
            #region STRING_QUERY

            StringBuilder Query = new StringBuilder();

            Query.Append("UPDATE CM0700 SET ");
            Query.Append("C_CODMAT =  @C_CODMAT, ");
            Query.Append("C_QTDMAT =  @C_QTDMAT, ");
            Query.Append("C_UNIMED =  @C_UNIMED, ");
            Query.Append("C_NUMDES =  @C_NUMDES, ");
            Query.Append("C_ITEDES =  @C_ITEDES ");
            Query.Append(" WHERE ");
            Query.Append("C_CODEQU = @C_CODEQU AND C_SEQEQU = @C_SEQEQU");

            #endregion STRING_QUERY

            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();

            command.Parameters.AddWithValue("@C_CODMAT", cm0700model.C_CODMAT);
            command.Parameters.AddWithValue("@C_QTDMAT", cm0700model.C_QTDMAT);
            command.Parameters.AddWithValue("@C_UNIMED", cm0700model.C_UNIMED);
            command.Parameters.AddWithValue("@C_NUMDES", cm0700model.C_NUMDES);
            command.Parameters.AddWithValue("@C_ITEDES", cm0700model.C_ITEDES);

            command.Parameters.AddWithValue("@C_CODEQU", cm0700model.C_CODEQU);
            command.Parameters.AddWithValue("@C_SEQEQU", cm0700model.C_SEQEQU);


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

        #endregion METHODS

        #region RETURN METHODS - CM0700

        public string RetornarUltSequenciaListaMaterialCM0700(string v_codequ)
        {
            string objID = null;
            string Query = "SELECT RIGHT('000' + CAST(COALESCE(MAX(C_SEQEQU) + 1, 1) AS VARCHAR), 3) AS C_SEQEQU "+
                           "FROM CM0700 WHERE C_CODEQU = '" + v_codequ + "'";
            SqlCommand command = new SqlCommand(Query, GetConnection());
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = GetConnection();
                {
                    objID = (Convert.ToInt32(command.ExecuteScalar().ToString())).ToString("000");
                    return objID;
                }

            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                CloseConnection(connection);
            }

        }
        public DataTable RetornarListaMateriais(string v_codequ)
        {
            string Query = "SELECT A.C_CODEQU, A.C_CODMAT, A.C_QTDMAT, A.C_UNIMED, A.C_NUMDES, A.C_ITEDES, A.C_SEQEQU, B.C_DESMAT FROM CM0700 A, CM0100 B "+
                           "WHERE A.C_CODEQU = '" + v_codequ + "' AND A.C_CODMAT = B.C_CODMAT ORDER BY A.C_SEQEQU";
            SqlCommand command = new SqlCommand(Query, GetConnection());
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = GetConnection();

                DataTable dTable = new DataTable("retornarListaMateriais");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dTable);

                return dTable;
            }
            finally
            {
                connection.Close();
            }
        }

        public CM0700MODEL RetornarListaMateriaisAlteracao(CM0700MODEL cm0700model, string v_codequ, string v_seqequ)
        {
            string Query = "SELECT C_CODMAT, C_QTDMAT, C_UNIMED, C_NUMDES, C_ITEDES FROM CM0700 " +
                           "WHERE C_CODEQU = '" + v_codequ + "' AND C_SEQEQU = '" + v_seqequ + "' ORDER BY C_SEQEQU";

            SqlCommand command = new SqlCommand(Query, GetConnection());
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = GetConnection();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {

                    cm0700model.C_CODMAT = reader["C_CODMAT"].ToString();
                    cm0700model.C_UNIMED = reader["C_UNIMED"].ToString();
                    cm0700model.C_NUMDES = reader["C_NUMDES"].ToString();
                    cm0700model.C_ITEDES = reader["C_ITEDES"].ToString();
                    cm0700model.C_QTDMAT = Convert.ToDecimal(reader["C_QTDMAT"].ToString());

                }
                return cm0700model;
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public void ExcluirItemListaMateriaisCM0700(CM0700MODEL cm0700model)
        {
            #region STRING_QUERY

            StringBuilder Query = new StringBuilder();

            Query.Append("DELETE FROM CM0700 ");
            Query.Append("WHERE C_CODEQU = @C_CODEQU AND C_SEQEQU = @C_SEQEQU");

            #endregion STRING_QUERY

            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();

            command.Parameters.AddWithValue("@C_CODEQU", cm0700model.C_CODEQU);
            command.Parameters.AddWithValue("@C_SEQEQU", cm0700model.C_SEQEQU);

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

        #endregion RETURN METHODS - CM0700
    }
}
