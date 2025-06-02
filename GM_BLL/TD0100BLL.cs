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
    public class TD0100BLL
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

        #region RETURN METHODS - TD0100

        public DataTable RetornarTipoMaterialComboBox()
        {
            string Query = "SELECT SUBSTRING(C_TEXTO,3,1) AS C_VALOR, SUBSTRING(C_TEXTO,6,15) AS C_TEXTO FROM TD0100 Where C_KEYTAB like '400014%'";

            SqlCommand command = new SqlCommand(Query, GetConnection());
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = GetConnection();

                DataTable dTable = new DataTable("retornarTipoMaterial");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dTable);

                return dTable;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable RetornarUnidadeMedidaComboBox()
        {
            string Query = "Select SUBSTRING(C_KEYTAB,7,2) AS C_KEYTAB from TD0100 Where C_KEYTAB like '400034%'";

            SqlCommand command = new SqlCommand(Query, GetConnection());
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = GetConnection();

                DataTable dTable = new DataTable("retornarUnidadeMedida");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dTable);

                return dTable;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable RetornarComponentesGridView(string v_descom)
        {
            string Query = "SELECT SUBSTRING(C_TEXTO,3,2) AS C_CODCOM, SUBSTRING(C_TEXTO,6,30) AS C_TEXTO FROM "+
                           "TD0100 WHERE C_CDTAB ='45005' AND C_TEXTO LIKE '%" + v_descom + "%'";

            SqlCommand command = new SqlCommand(Query, GetConnection());
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = GetConnection();

                DataTable dTable = new DataTable("retornarComponentes");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dTable);

                return dTable;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable RetornarTipoEquipamentoComboBox()
        {
            string Query = "SELECT SUBSTRING(C_TEXTO,3,2) AS C_VALOR, SUBSTRING(C_TEXTO,6,30) AS C_TEXTO from TD0100 WHERE C_CDTAB ='45005'";

            SqlCommand command = new SqlCommand(Query, GetConnection());
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = GetConnection();

                DataTable dTable = new DataTable("retornarTipoEquipamento");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dTable);

                return dTable;
            }
            finally
            {
                connection.Close();
            }
        }

        public string RetornarResponsavelLista(string v_rescoo)
        {
            string v_responsavel = null;

            string Query = "SELECT SUBSTRING(C_TEXTO,6,20) AS C_TEXTO FROM TD0100 "+
                           "WHERE C_CDTAB ='45003' AND SUBSTRING(C_TEXTO,3,2) = '" + v_rescoo + "'";

            SqlConnection connection = new SqlConnection();
            try
            {
                connection = GetConnection();

                SqlCommand command = new SqlCommand();
                command.CommandText = Query;
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                v_responsavel = command.ExecuteScalar().ToString();


            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                CloseConnection(connection);
            }
            return v_responsavel;
        }

        #endregion RETURN METHODS - TD0100

    }
}
