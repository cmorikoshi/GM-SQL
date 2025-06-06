using GM_BLL;
using GM_MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GM_BLL
{
    public class OS0300BLL
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

        public DataTable RetornarOS0300LMC(string v_select)
        {
            string Query = "SELECT C_NUMOSE, C_NOMRES, C_NOMOSE  FROM OS0300 WHERE " + v_select + "";

            SqlCommand command = new SqlCommand(Query, GetConnection());
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = GetConnection();

                DataTable dTable = new DataTable("retornarOS0300LMC");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dTable);

                return dTable;
            }
            finally
            {
                connection.Close();
            }
        }

        public OS0300MODEL RetornarDadosInformacoesOS0300(OS0300MODEL os0300model,  string v_numose)
        {
            string Query = "SELECT (A.C_ANOJOB + '-'+A.C_NUMJOB) AS C_NUMJOB, A.C_DTABOS, A.C_NOMOSE, A.C_QTDEOS , A.C_RESCOO, B.C_DESCOS   FROM OS0300 A, OS0350 B "+
                           "WHERE A.C_NUMOSE = B.C_NUMOSE AND A.C_NUMOSE = '" + v_numose + "'";


            SqlCommand command = new SqlCommand(Query, GetConnection());
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = GetConnection();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {

                    os0300model.C_NUMJOB = reader["C_NUMJOB"].ToString();
                    os0300model.C_DTABOS = reader["C_DTABOS"].ToString();
                    os0300model.C_NOMOSE = reader["C_NOMOSE"].ToString();
                    os0300model.C_QTDEOS = Convert.ToDecimal(reader["C_QTDEOS"].ToString());
                    os0300model.C_RESCOO = reader["C_RESCOO"].ToString();
                    os0300model.C_DESCOS = reader["C_DESCOS"].ToString();

                }
                return os0300model;
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }


        #endregion METHODS
    }
}
