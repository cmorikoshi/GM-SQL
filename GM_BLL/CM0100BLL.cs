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
    public class CM0100BLL
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

        public void InserirIDCadastroMateriaisCM0100(CM0100MODEL cm0100model)
        {
            #region STRING_QUERY

            StringBuilder Query = new StringBuilder();

            Query.Append("INSERT INTO CM0100 (");
            Query.Append("C_CODMAT)");
            Query.Append("VALUES( ");
            Query.Append("@C_CODMAT)");

            #endregion STRING_QUERY

            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();

            command.Parameters.AddWithValue("@C_CODMAT", cm0100model.C_CODMAT);

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


        public void AlterarMaterialCM0100(CM0100MODEL cm0100model)
        {
            #region STRING_QUERY

            StringBuilder Query = new StringBuilder();

            Query.Append("UPDATE CM0100 SET ");
            Query.Append("C_DESMAT =  @C_DESMAT, ");
            Query.Append("C_CHAPES =  @C_CHAPES, ");
            Query.Append("C_UNIMED =  @C_UNIMED, ");
            Query.Append("C_NUMDES =  @C_NUMDES, ");
            Query.Append("C_ORIMAT =  @C_ORIMAT, ");
            Query.Append("C_TIPMAT =  @C_TIPMAT, ");
            Query.Append("C_RESQTD =  @C_RESQTD, ");
            Query.Append("C_DISQTD =  @C_DISQTD, ");
            Query.Append("C_SALQTD =  @C_SALQTD, ");
            Query.Append("C_ESTMIN =  @C_ESTMIN, ");
            Query.Append("C_ESTMAX =  @C_ESTMAX, ");
            Query.Append("C_CONMED =  @C_CONMED, ");
            Query.Append("C_LOTECO =  @C_LOTECO, ");
            Query.Append("C_PESESP =  @C_PESESP, ");
            Query.Append("C_DATULT =  @C_DATULT, ");
            Query.Append("C_UNIPE1 =  @C_UNIPE1, ");
            Query.Append("C_UNIPE2 =  @C_UNIPE2, ");
            Query.Append("C_PRAABA =  @C_PRAABA, ");
            Query.Append("C_LOCCOR =  @C_LOCCOR, ");
            Query.Append("C_LOCPRA =  @C_LOCPRA, ");
            Query.Append("C_PREUCR =  @C_PREUCR, ");
            Query.Append("C_DATPRE =  @C_DATPRE, ");
            Query.Append("C_LOCBOX =  @C_LOCBOX ");
            Query.Append(" WHERE ");
            Query.Append("C_CODMAT = @C_CODMAT");

            #endregion STRING_QUERY

            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();

            command.Parameters.AddWithValue("@C_DESMAT", cm0100model.C_DESMAT);
            command.Parameters.AddWithValue("@C_CHAPES", cm0100model.C_CHAPES);
            command.Parameters.AddWithValue("@C_UNIMED", cm0100model.C_UNIMED);
            command.Parameters.AddWithValue("@C_NUMDES", cm0100model.C_NUMDES);
            command.Parameters.AddWithValue("@C_ORIMAT", cm0100model.C_ORIMAT);
            command.Parameters.AddWithValue("@C_TIPMAT", cm0100model.C_TIPMAT);
            command.Parameters.AddWithValue("@C_RESQTD", cm0100model.C_RESQTD);
            command.Parameters.AddWithValue("@C_DISQTD", cm0100model.C_DISQTD);
            command.Parameters.AddWithValue("@C_SALQTD", cm0100model.C_SALQTD);
            command.Parameters.AddWithValue("@C_ESTMIN", cm0100model.C_ESTMIN);
            command.Parameters.AddWithValue("@C_ESTMAX", cm0100model.C_ESTMAX);
            command.Parameters.AddWithValue("@C_CONMED", cm0100model.C_CONMED);
            command.Parameters.AddWithValue("@C_LOTECO", cm0100model.C_LOTECO);
            command.Parameters.AddWithValue("@C_PESESP", cm0100model.C_PESESP);
            command.Parameters.AddWithValue("@C_DATULT", cm0100model.C_DATULT);
            command.Parameters.AddWithValue("@C_UNIPE1", cm0100model.C_UNIPE1);
            command.Parameters.AddWithValue("@C_UNIPE2", cm0100model.C_UNIPE2);
            command.Parameters.AddWithValue("@C_PRAABA", cm0100model.C_PRAABA);
            command.Parameters.AddWithValue("@C_LOCCOR", cm0100model.C_LOCCOR);
            command.Parameters.AddWithValue("@C_LOCPRA", cm0100model.C_LOCPRA);
            command.Parameters.AddWithValue("@C_PREUCR", cm0100model.C_PREUCR);
            command.Parameters.AddWithValue("@C_DATPRE", cm0100model.C_DATPRE);
            command.Parameters.AddWithValue("@C_LOCBOX", cm0100model.C_LOCBOX);

            command.Parameters.AddWithValue("@C_CODMAT", cm0100model.C_CODMAT);

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

        public void InserirLogMaterialCM0100Log(CM0100LOGMODEL cm0100LogModel)
        {
            #region STRING_QUERY

            StringBuilder Query = new StringBuilder();

            Query.Append("INSERT INTO CM0100LOG (");
            Query.Append("C_CODMAT, ");
            Query.Append("C_DESMAT, ");
            Query.Append("C_TIPMAT, ");
            Query.Append("C_UNIMED, ");
            Query.Append("C_NUMDES, ");
            Query.Append("C_ORIMAT, ");
            Query.Append("C_CHAPES, ");
            Query.Append("C_ESTMIN, ");
            Query.Append("C_ESTMAX, ");
            Query.Append("C_LOTECO, ");
            Query.Append("C_PESESP, ");
            Query.Append("C_UNIPE1, ");
            Query.Append("C_UNIPE2, ");
            Query.Append("C_LOCCOR, ");
            Query.Append("C_LOCPRA, ");
            Query.Append("C_LOCBOX, ");
            Query.Append("C_DATULT, ");
            Query.Append("C_PRAABA, ");
            Query.Append("C_DATLOG, ");
            Query.Append("C_NOMUSU, ");
            Query.Append("C_TIPOPE, ");
            Query.Append("C_MAQUSU) ");
            Query.Append("VALUES (");
            Query.Append("@C_CODMAT, ");
            Query.Append("@C_DESMAT, ");
            Query.Append("@C_TIPMAT, ");
            Query.Append("@C_UNIMED, ");
            Query.Append("@C_NUMDES, ");
            Query.Append("@C_ORIMAT, ");
            Query.Append("@C_CHAPES, ");
            Query.Append("@C_ESTMIN, ");
            Query.Append("@C_ESTMAX, ");
            Query.Append("@C_LOTECO, ");
            Query.Append("@C_PESESP, ");
            Query.Append("@C_UNIPE1, ");
            Query.Append("@C_UNIPE2, ");
            Query.Append("@C_LOCCOR, ");
            Query.Append("@C_LOCPRA, ");
            Query.Append("@C_LOCBOX, ");
            Query.Append("@C_DATULT, ");
            Query.Append("@C_PRAABA, ");
            Query.Append("@C_DATLOG, ");
            Query.Append("@C_NOMUSU, ");
            Query.Append("@C_TIPOPE, ");
            Query.Append("@C_MAQUSU)");

            #endregion STRING_QUERY

            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();

            command.Parameters.AddWithValue("@C_CODMAT", cm0100LogModel.C_CODMAT);
            command.Parameters.AddWithValue("@C_DESMAT", cm0100LogModel.C_DESMAT);
            command.Parameters.AddWithValue("@C_TIPMAT", cm0100LogModel.C_TIPMAT);
            command.Parameters.AddWithValue("@C_UNIMED", cm0100LogModel.C_UNIMED);
            command.Parameters.AddWithValue("@C_NUMDES", cm0100LogModel.C_NUMDES);
            command.Parameters.AddWithValue("@C_ORIMAT", cm0100LogModel.C_ORIMAT);
            command.Parameters.AddWithValue("@C_CHAPES", cm0100LogModel.C_CHAPES);
            command.Parameters.AddWithValue("@C_ESTMIN", cm0100LogModel.C_ESTMIN);
            command.Parameters.AddWithValue("@C_ESTMAX", cm0100LogModel.C_ESTMAX);
            command.Parameters.AddWithValue("@C_LOTECO", cm0100LogModel.C_LOTECO);
            command.Parameters.AddWithValue("@C_PESESP", cm0100LogModel.C_PESESP);
            command.Parameters.AddWithValue("@C_UNIPE1", cm0100LogModel.C_UNIPE1);
            command.Parameters.AddWithValue("@C_UNIPE2", cm0100LogModel.C_UNIPE2);
            command.Parameters.AddWithValue("@C_LOCCOR", cm0100LogModel.C_LOCCOR);
            command.Parameters.AddWithValue("@C_LOCPRA", cm0100LogModel.C_LOCPRA);
            command.Parameters.AddWithValue("@C_LOCBOX", cm0100LogModel.C_LOCBOX);
            command.Parameters.AddWithValue("@C_DATULT", cm0100LogModel.C_DATULT);
            command.Parameters.AddWithValue("@C_PRAABA", cm0100LogModel.C_PRAABA);
            command.Parameters.AddWithValue("@C_DATLOG", cm0100LogModel.C_DATLOG);
            command.Parameters.AddWithValue("@C_NOMUSU", cm0100LogModel.C_NOMUSU);
            command.Parameters.AddWithValue("@C_TIPOPE", cm0100LogModel.C_TIPOPE);
            command.Parameters.AddWithValue("@C_MAQUSU", cm0100LogModel.C_MAQUSU);

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

        public void ExcluirIDCadastroMateriaisCM0100(CM0100MODEL cm0100model)
        {
            #region STRING_QUERY

            StringBuilder Query = new StringBuilder();

            Query.Append("DELETE FROM CM0100 ");
            Query.Append("WHERE C_CODMAT = @C_CODMAT");

            #endregion STRING_QUERY

            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();

            command.Parameters.AddWithValue("@C_CODMAT", cm0100model.C_CODMAT);

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

        #region RETURN METHODS - CM0100

        public string RetornarUltIDCadastroMaterialCM0100()
        {
            string objID = null;
            string Query = "SELECT REPLICATE('0',7-LEN(CAST(MAX(C_CODMAT)+1 AS INT)))+CAST(MAX(C_CODMAT)+1 AS CHAR(7)) AS C_CODMAT FROM CM0100";
            SqlCommand command = new SqlCommand(Query, GetConnection());
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = GetConnection();
                {
                    objID = (Convert.ToInt32(command.ExecuteScalar().ToString())).ToString("0000000");
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

        public DataTable RetornarMaterialComboBox(string v_select)
        {
            string Query = "SELECT C_CODMAT, C_DESMAT, C_CHAPES, C_NUMDES FROM CM0100 " +
                           "WHERE " + v_select + "";
            SqlCommand command = new SqlCommand(Query, GetConnection());
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = GetConnection();

                DataTable dTable = new DataTable("retornarMaterial");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dTable);

                return dTable;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable RetornarMaterialPesquisa(string v_select)
        {
            string Query = "SELECT C_CODMAT, C_DESMAT FROM CM0100 " +
                           "WHERE " + v_select + "";
            SqlCommand command = new SqlCommand(Query, GetConnection());
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = GetConnection();

                DataTable dTable = new DataTable("retornarMaterial");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dTable);

                return dTable;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<CM0100MODEL> RetornarListaMaterialPesquisa(string v_select)
        {
            string Query = "SELECT C_DESMAT FROM CM0100 " +
                           "WHERE " + v_select;
            SqlCommand command = new SqlCommand(Query, GetConnection());
            SqlConnection connection = GetConnection();

            try
            {
                List<CM0100MODEL> materials = new List<CM0100MODEL>();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CM0100MODEL material = new CM0100MODEL
                        {
                            C_DESMAT = reader["C_DESMAT"].ToString()
                        };
                        materials.Add(material);
                    }
                }

                return materials;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable RetornarDescricaoMaterialComboBox(string v_desmat)
        {
            string Query = "SELECT C_DESMAT FROM CM0100 WHERE C_DESMAT LIKE '%" + v_desmat + "%'";
            SqlCommand command = new SqlCommand(Query, GetConnection());
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = GetConnection();

                DataTable dTable = new DataTable("retornarDescricaoMaterial");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dTable);

                return dTable;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable RetornarMaterialPesquisaTelaItensProduto(string v_select)
        {
            string Query = "SELECT C_CODMAT, C_DESMAT, C_UNIMED, C_NUMDES FROM CM0100 " +
                           "WHERE " + v_select + "";
            SqlCommand command = new SqlCommand(Query, GetConnection());
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = GetConnection();

                DataTable dTable = new DataTable("retornarMaterialItensProduto");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dTable);

                return dTable;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable RetornarMaterialAposInsercao(string v_select)
        {
            string Query = "SELECT C_CODMAT, C_DESMAT, C_CHAPES, C_NUMDES FROM CM0100 " +
                           "WHERE " + v_select + "";
            SqlCommand command = new SqlCommand(Query, GetConnection());
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = GetConnection();

                DataTable dTable = new DataTable("retornarMaterialAposInsercao");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dTable);

                return dTable;
            }
            finally
            {
                connection.Close();
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

        public DataTable RetornarNomeEmpresa()
        {
            string Query = "SELECT C_NOMRES, C_CODEMP FROM RH0000 WHERE C_SISSGA = 'S'";
            SqlCommand command = new SqlCommand(Query, GetConnection());
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = GetConnection();

                DataTable daTable = new DataTable("nomeEmpresa");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(daTable);
                return daTable;
            }
            finally
            {
                connection.Close();
            }
        }


        public DataTable RetornarMaterialCadastroMaterial(string v_codmat)
        {
            string Query = "SELECT C_CODMAT, C_DESMAT, C_DESDYN, C_CHAPES, C_UNIMED,C_NUMDES, C_ORIMAT, C_TIPMAT, " +
                           " C_RESQTD, C_DISQTD, C_SALQTD, C_ESTMIN, C_ESTMAX, C_CONMED, C_LOTECO, C_PESESP, C_DATULT, " +
                           " C_UNIPE1, C_UNIPE2, C_PRAABA, C_LOCCOR, C_LOCPRA, C_LOCBOX FROM CM0100 WHERE C_CODMAT = '" + v_codmat + "'";

            SqlCommand command = new SqlCommand(Query, GetConnection());
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = GetConnection();

                DataTable dTable = new DataTable("retornarMaterialCadastro");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dTable);

                return dTable;
            }
            finally
            {
                connection.Close();
            }
        }

        public CM0100MODEL RetornarDadosMaterialCM0100(CM0100MODEL cm0100model, string v_codmat)
        {
            string Query = "SELECT C_CODMAT, C_DESMAT, C_CHAPES, C_UNIMED, C_NUMDES, C_ORIMAT, C_TIPMAT, " +
                           " C_RESQTD, C_DISQTD, C_SALQTD, C_ESTMIN, C_ESTMAX, C_CONMED, C_LOTECO, C_PESESP, C_DATULT, " +
                           " C_UNIPE1, C_UNIPE2, C_KEYDYN, C_PRAABA, C_LOCCOR, C_LOCPRA, C_PREUCR, C_DATPRE, C_LOCBOX FROM CM0100 WHERE C_CODMAT = '" + v_codmat + "'";

            SqlCommand command = new SqlCommand(Query, GetConnection());
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = GetConnection();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {

                    cm0100model.C_CODMAT = reader["C_CODMAT"].ToString();
                    cm0100model.C_DESMAT = reader["C_DESMAT"].ToString();
                    cm0100model.C_CHAPES = reader["C_CHAPES"].ToString();
                    cm0100model.C_UNIMED = reader["C_UNIMED"].ToString();
                    cm0100model.C_NUMDES = reader["C_NUMDES"].ToString();
                    cm0100model.C_ORIMAT = reader["C_ORIMAT"].ToString();
                    cm0100model.C_TIPMAT = reader["C_TIPMAT"].ToString();
                    cm0100model.C_RESQTD = Convert.ToDecimal(reader["C_RESQTD"].ToString());
                    cm0100model.C_DISQTD = Convert.ToDecimal(reader["C_DISQTD"].ToString());
                    cm0100model.C_SALQTD = Convert.ToDecimal(reader["C_SALQTD"].ToString());
                    cm0100model.C_ESTMIN = Convert.ToDecimal(reader["C_ESTMIN"].ToString());
                    cm0100model.C_ESTMAX = Convert.ToDecimal(reader["C_ESTMAX"].ToString());
                    cm0100model.C_CONMED = Convert.ToDecimal(reader["C_CONMED"].ToString());
                    cm0100model.C_LOTECO = Convert.ToDecimal(reader["C_LOTECO"].ToString());
                    cm0100model.C_PESESP = Convert.ToDecimal(reader["C_PESESP"].ToString());
                    cm0100model.C_DATULT = reader["C_DATULT"].ToString();
                    cm0100model.C_UNIPE1 = reader["C_UNIPE1"].ToString();
                    cm0100model.C_UNIPE2 = reader["C_UNIPE2"].ToString();
                    cm0100model.C_KEYDYN = reader["C_KEYDYN"].ToString();
                    cm0100model.C_PRAABA = Convert.ToDecimal(reader["C_PRAABA"].ToString());
                    cm0100model.C_LOCCOR = reader["C_LOCCOR"].ToString();
                    cm0100model.C_LOCPRA = reader["C_LOCPRA"].ToString();
                    cm0100model.C_PREUCR = Convert.ToDecimal(reader["C_PREUCR"].ToString());
                    cm0100model.C_DATPRE = reader["C_DATPRE"].ToString();
                    cm0100model.C_LOCBOX = reader["C_LOCBOX"].ToString();
                }
                return cm0100model;
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }


        #endregion RETURN METHODS - CM0100

        #region CHECKING METHODS



        #endregion CHECKING METHODS

        #region REPORT METHODS

        public DataTable RetornarDadosOPRelatorio(string v_codemp, string v_numord)
        {
            string Query = "SELECT SUBSTRING(A.C_DATEMI,7,2)+'/'+SUBSTRING(A.C_DATEMI,5,2)+'/'+SUBSTRING(A.C_DATEMI,1,4) AS C_DATEMI, " +
                           "SUBSTRING(A.C_DATREQ, 7, 2) + '/' + SUBSTRING(A.C_DATREQ, 5, 2) + '/' + SUBSTRING(A.C_DATREQ, 1, 4) AS C_DATREQ, " +
                           "SUBSTRING(A.C_DATCOO, 7, 2) +'/' + SUBSTRING(A.C_DATCOO, 5, 2) + '/' + SUBSTRING(A.C_DATCOO, 1, 4) AS C_DATCOO, " +
                           "SUBSTRING(A.C_DATSUP, 7, 2) +'/' + SUBSTRING(A.C_DATSUP, 5, 2) + '/' + SUBSTRING(A.C_DATSUP, 1, 4) AS C_DATSUP, " +
                           "SUBSTRING(A.C_DATFIN, 7, 2) +'/' + SUBSTRING(A.C_DATFIN, 5, 2) + '/' + SUBSTRING(A.C_DATFIN, 1, 4) AS C_DATFIN, " +
                           "SUBSTRING(A.C_DATVEN, 7, 2)+'/' + SUBSTRING(A.C_DATVEN, 5, 2) + '/' + SUBSTRING(A.C_DATVEN, 1, 4) AS C_DATVEN, RTRIM(C_NUMCON) AS C_NUMCON, " +
                           "(SUBSTRING(A.C_NUCNPJ, 1, 2) + '.' + SUBSTRING(A.C_NUCNPJ, 3, 3) + '.' + SUBSTRING(A.C_NUCNPJ, 6, 3) + '/' + SUBSTRING(C_NUCNPJ, 9, 4) + '-' + SUBSTRING(C_NUCNPJ, 13, 2)) AS C_NUCNPJ, " +
                           "(SUBSTRING(A.C_NUMCPF, 1, 3) + '.' + SUBSTRING(A.C_NUMCPF, 4, 3) + '.' + SUBSTRING(A.C_NUMCPF, 7, 3) + '-' + SUBSTRING(C_NUMCPF, 10, 2)) AS C_NUMCPF, " +
                           "RTRIM(A.C_NOMREQ) AS C_NOMREQ, RTRIM(A.C_APRSUP) AS C_APRSUP, RTRIM(A.C_APRCOO) AS C_APRCOO, RTRIM(A.C_APRFIN) AS C_APRFIN, A.*, " +
                           "B.C_NUMITE, B.C_REFDES, RTRIM(B.C_DESITE) AS C_DESITE, " +
                           "('NF= ' + B.C_REFDES + ' / ' + B.C_ITEDES + ' - PC= ' + B.C_NUMPED + ' - ' + B.C_NOMDES) AS C_ARQUI,  F.C_NOMDES, RTRIM(C_OBSITE) AS C_OBSITE, " +
                            "SUBSTRING(B.C_DATITE, 7, 2) + '/' + SUBSTRING(B.C_DATITE, 5, 2) + '/' + SUBSTRING(B.C_DATITE, 1, 4) AS C_DATITE, B.C_VALITE, " +
                              "B.C_ITEDES, B.C_FORDES, B.C_NUMPED, B.C_ITEPED, B.C_NUMOSE, SUBSTRING(A.C_NUMORD, 1, 2) + '.' + SUBSTRING(A.C_NUMORD, 2, 5) AS C_NUMORD, " +
                           "G.C_RZSOC, C.*, D.C_NOMCEN, F.C_NOMDES, ISNULL(E.C_DESCLI, ' ') AS C_DESCLI, A.C_NATFOR " +
                           "FROM OP0100 A LEFT JOIN JB0100 E ON(A.C_CODEMP = E.C_CODEMP AND A.C_ANOJOB = E.C_ANOJOB and A.C_NUMJOB = E.C_NUMJOB), " +
                           "OP0200 B, OP0250 C, QC0300 D, OP1000 F, MC0100 G WHERE A.C_CODEMP = '" + v_codemp + "' AND A.C_NUMORD = '" + v_numord + "' AND " +
                           "A.C_TIPOOP = '04' AND A.C_CODFOR = G.C_CDCLI AND A.C_CODEMP = B.C_CODEMP AND A.C_NUMORD = B.C_NUMORD AND B.C_CODEMP = C.C_CODEMP AND " +
                           "B.C_NUMORD = C.C_NUMORD AND B.C_NUMITE = C.C_NUMITE AND C.C_GRUDES = F.C_GRUDES AND A.C_CENCUS = D.C_CODCEN " +
                           "UNION " +
                           "SELECT SUBSTRING(A.C_DATEMI, 7, 2) + '/' + SUBSTRING(A.C_DATEMI, 5, 2) + '/' + SUBSTRING(A.C_DATEMI, 1, 4) AS C_DATEMI, " +
                           "SUBSTRING(A.C_DATREQ, 7, 2) +'/' + SUBSTRING(A.C_DATREQ, 5, 2) + '/' + SUBSTRING(A.C_DATREQ, 1, 4) AS C_DATREQ, " +
                           "SUBSTRING(A.C_DATCOO, 7, 2) +'/' + SUBSTRING(A.C_DATCOO, 5, 2) + '/' + SUBSTRING(A.C_DATCOO, 1, 4) AS C_DATCOO, " +
                           "SUBSTRING(A.C_DATSUP, 7, 2) +'/' + SUBSTRING(A.C_DATSUP, 5, 2) + '/' + SUBSTRING(A.C_DATSUP, 1, 4) AS C_DATSUP, " +
                           "SUBSTRING(A.C_DATFIN, 7, 2) +'/' + SUBSTRING(A.C_DATFIN, 5, 2) + '/' + SUBSTRING(A.C_DATFIN, 1, 4) AS C_DATFIN, " +
                           "SUBSTRING(A.C_DATVEN, 7, 2)+'/' + SUBSTRING(A.C_DATVEN, 5, 2) + '/' + SUBSTRING(A.C_DATVEN, 1, 4) AS C_DATVEN, RTRIM(C_NUMCON) AS C_NUMCON, " +
                           "(SUBSTRING(A.C_NUCNPJ, 1, 2) + '.' + SUBSTRING(A.C_NUCNPJ, 3, 3) + '.' + SUBSTRING(A.C_NUCNPJ, 6, 3) + '/' + SUBSTRING(C_NUCNPJ, 9, 4) + '-' + SUBSTRING(C_NUCNPJ, 13, 2)) AS C_NUCNPJ, " +
                           "(SUBSTRING(A.C_NUMCPF, 1, 3) + '.' + SUBSTRING(A.C_NUMCPF, 4, 3) + '.' + SUBSTRING(A.C_NUMCPF, 7, 3) + '-' + SUBSTRING(C_NUMCPF, 10, 2)) AS C_NUMCPF, " +
                           "RTRIM(A.C_NOMREQ) AS C_NOMREQ, RTRIM(A.C_APRSUP) AS C_APRSUP, RTRIM(A.C_APRCOO) AS C_APRCOO, RTRIM(A.C_APRFIN) AS C_APRFIN, A.*, " +
                           "B.C_NUMITE, B.C_REFDES, RTRIM(B.C_DESITE) AS C_DESITE, " +
                           "'Veículo próprio - Placa: ' + C.C_NUMPLA + ' - KM Inicial: ' + convert(varchar, C.C_KILINI) + ' - KM Final: ' + convert(varchar, C.C_KILFIM) AS C_ARQUI,  F.C_NOMDES, RTRIM(C_OBSITE) AS C_OBSITE, " +
                           "SUBSTRING(B.C_DATITE, 7, 2) + '/' + SUBSTRING(B.C_DATITE, 5, 2) + '/' + SUBSTRING(B.C_DATITE, 1, 4) AS C_DATITE, B.C_VALITE, " +
                           "B.C_ITEDES, B.C_FORDES, B.C_NUMPED, B.C_ITEPED, B.C_NUMOSE, SUBSTRING(A.C_NUMORD, 1, 2) + '.' + SUBSTRING(A.C_NUMORD, 2, 5) AS C_NUMORD, " +
                           "G.C_RZSOC, C.*, D.C_NOMCEN, F.C_NOMDES, ISNULL(E.C_DESCLI, ' ') AS C_DESCLI, A.C_NATFOR " +
                           "FROM OP0100 A LEFT JOIN JB0100 E ON(A.C_CODEMP = E.C_CODEMP AND A.C_ANOJOB = E.C_ANOJOB and A.C_NUMJOB = E.C_NUMJOB), " +
                            "OP0200 B, OP0250 C,	QC0300 D, OP1000 F,	MC0100 G WHERE A.C_CODEMP = '" + v_codemp + "' AND  A.C_NUMORD = '" + v_numord + "' AND " +
                           "A.C_TIPOOP <> '04' AND C.C_PROVEI = '1' AND A.C_CODFOR = G.C_CDCLI AND A.C_CODEMP = B.C_CODEMP AND A.C_NUMORD = B.C_NUMORD AND B.C_CODEMP = C.C_CODEMP AND " +
                           " B.C_NUMORD = C.C_NUMORD AND B.C_NUMITE = C.C_NUMITE AND C.C_GRUDES = F.C_GRUDES AND A.C_CENCUS = D.C_CODCEN " +
                           "UNION " +
                           "SELECT SUBSTRING(A.C_DATEMI, 7, 2) + '/' + SUBSTRING(A.C_DATEMI, 5, 2) + '/' + SUBSTRING(A.C_DATEMI, 1, 4) AS C_DATEMI, " +
                           "SUBSTRING(A.C_DATREQ, 7, 2) +'/' + SUBSTRING(A.C_DATREQ, 5, 2) + '/' + SUBSTRING(A.C_DATREQ, 1, 4) AS C_DATREQ, " +
                           "SUBSTRING(A.C_DATCOO, 7, 2) +'/' + SUBSTRING(A.C_DATCOO, 5, 2) + '/' + SUBSTRING(A.C_DATCOO, 1, 4) AS C_DATCOO, " +
                           "SUBSTRING(A.C_DATSUP, 7, 2) +'/' + SUBSTRING(A.C_DATSUP, 5, 2) + '/' + SUBSTRING(A.C_DATSUP, 1, 4) AS C_DATSUP, " +
                           "SUBSTRING(A.C_DATFIN, 7, 2) +'/' + SUBSTRING(A.C_DATFIN, 5, 2) + '/' + SUBSTRING(A.C_DATFIN, 1, 4) AS C_DATFIN, " +
                           "SUBSTRING(A.C_DATVEN, 7, 2)+'/' + SUBSTRING(A.C_DATVEN, 5, 2) + '/' + SUBSTRING(A.C_DATVEN, 1, 4) AS C_DATVEN, RTRIM(C_NUMCON) AS C_NUMCON, " +
                           "(SUBSTRING(A.C_NUCNPJ, 1, 2) + '.' + SUBSTRING(A.C_NUCNPJ, 3, 3) + '.' + SUBSTRING(A.C_NUCNPJ, 6, 3) + '/' + SUBSTRING(C_NUCNPJ, 9, 4) + '-' + SUBSTRING(C_NUCNPJ, 13, 2)) AS C_NUCNPJ, " +
                           "(SUBSTRING(A.C_NUMCPF, 1, 3) + '.' + SUBSTRING(A.C_NUMCPF, 4, 3) + '.' + SUBSTRING(A.C_NUMCPF, 7, 3) + '-' + SUBSTRING(C_NUMCPF, 10, 2)) AS C_NUMCPF, " +
                           "RTRIM(A.C_NOMREQ) AS C_NOMREQ, RTRIM(A.C_APRSUP) AS C_APRSUP, RTRIM(A.C_APRCOO) AS C_APRCOO, RTRIM(A.C_APRFIN) AS C_APRFIN, A.*, " +
                           "B.C_NUMITE, B.C_REFDES, RTRIM(B.C_DESITE) AS C_DESITE, " +
                           "('Veículo da empresa - Placa: ' + C.C_NUMPLA + ' - KM Abastecimento: ' + convert(varchar, C.C_KILINI)) AS C_ARQUI,  F.C_NOMDES, RTRIM(C_OBSITE) AS C_OBSITE, " +
                           "SUBSTRING(B.C_DATITE, 7, 2) + '/' + SUBSTRING(B.C_DATITE, 5, 2) + '/' + SUBSTRING(B.C_DATITE, 1, 4) AS C_DATITE, B.C_VALITE, " +
                           "B.C_ITEDES, B.C_FORDES, B.C_NUMPED, B.C_ITEPED, B.C_NUMOSE, SUBSTRING(A.C_NUMORD, 1, 2) + '.' + SUBSTRING(A.C_NUMORD, 2, 5) AS C_NUMORD, " +
                           "G.C_RZSOC, C.*, D.C_NOMCEN, F.C_NOMDES, ISNULL(E.C_DESCLI, ' ') AS C_DESCLI, A.C_NATFOR " +
                           "FROM OP0100 A LEFT JOIN JB0100 E ON(A.C_CODEMP = E.C_CODEMP AND A.C_ANOJOB = E.C_ANOJOB and A.C_NUMJOB = E.C_NUMJOB), " +
                           "OP0200 B, OP0250 C, QC0300 D, OP1000 F,	MC0100 G WHERE A.C_CODEMP = '" + v_codemp + "' AND A.C_NUMORD = '" + v_numord + "' AND " +
                           "A.C_TIPOOP <> '04' AND C.C_PROVEI = '2' AND A.C_CODFOR = G.C_CDCLI AND A.C_CODEMP = B.C_CODEMP AND A.C_NUMORD = B.C_NUMORD AND B.C_CODEMP = C.C_CODEMP AND " +
                           "B.C_NUMORD = C.C_NUMORD AND B.C_NUMITE = C.C_NUMITE AND C.C_GRUDES = F.C_GRUDES AND A.C_CENCUS = D.C_CODCEN " +
                           "UNION " +
                           "SELECT SUBSTRING(A.C_DATEMI, 7, 2) + '/' + SUBSTRING(A.C_DATEMI, 5, 2) + '/' + SUBSTRING(A.C_DATEMI, 1, 4) AS C_DATEMI, " +
                           "SUBSTRING(A.C_DATREQ, 7, 2) +'/' + SUBSTRING(A.C_DATREQ, 5, 2) + '/' + SUBSTRING(A.C_DATREQ, 1, 4) AS C_DATREQ, " +
                           "SUBSTRING(A.C_DATCOO, 7, 2) +'/' + SUBSTRING(A.C_DATCOO, 5, 2) + '/' + SUBSTRING(A.C_DATCOO, 1, 4) AS C_DATCOO, " +
                           "SUBSTRING(A.C_DATSUP, 7, 2) +'/' + SUBSTRING(A.C_DATSUP, 5, 2) + '/' + SUBSTRING(A.C_DATSUP, 1, 4) AS C_DATSUP, " +
                           "SUBSTRING(A.C_DATFIN, 7, 2) +'/' + SUBSTRING(A.C_DATFIN, 5, 2) + '/' + SUBSTRING(A.C_DATFIN, 1, 4) AS C_DATFIN, " +
                           "SUBSTRING(A.C_DATVEN, 7, 2)+'/' + SUBSTRING(A.C_DATVEN, 5, 2) + '/' + SUBSTRING(A.C_DATVEN, 1, 4) AS C_DATVEN, RTRIM(C_NUMCON) AS C_NUMCON, " +
                           "(SUBSTRING(A.C_NUCNPJ, 1, 2) + '.' + SUBSTRING(A.C_NUCNPJ, 3, 3) + '.' + SUBSTRING(A.C_NUCNPJ, 6, 3) + '/' + SUBSTRING(C_NUCNPJ, 9, 4) + '-' + SUBSTRING(C_NUCNPJ, 13, 2)) AS C_NUCNPJ, " +
                           "(SUBSTRING(A.C_NUMCPF, 1, 3) + '.' + SUBSTRING(A.C_NUMCPF, 4, 3) + '.' + SUBSTRING(A.C_NUMCPF, 7, 3) + '-' + SUBSTRING(C_NUMCPF, 10, 2)) AS C_NUMCPF, " +
                           "RTRIM(A.C_NOMREQ) AS C_NOMREQ, RTRIM(A.C_APRSUP) AS C_APRSUP, RTRIM(A.C_APRCOO) AS C_APRCOO, RTRIM(A.C_APRFIN) AS C_APRFIN, A.*, " +
                           "B.C_NUMITE, B.C_REFDES, RTRIM(B.C_DESITE) AS C_DESITE, 'Refer./NF=' + B.C_REFDES + ' ' + rtrim(B.C_DESITE) AS C_ARQUI,  F.C_NOMDES, RTRIM(C_OBSITE) AS C_OBSITE, " +
                           "SUBSTRING(B.C_DATITE, 7, 2) + '/' + SUBSTRING(B.C_DATITE, 5, 2) + '/' + SUBSTRING(B.C_DATITE, 1, 4) AS C_DATITE, B.C_VALITE, " +
                           "B.C_ITEDES, B.C_FORDES, B.C_NUMPED, B.C_ITEPED, B.C_NUMOSE, SUBSTRING(A.C_NUMORD, 1, 2) + '.' + SUBSTRING(A.C_NUMORD, 2, 5) AS C_NUMORD, " +
                           "G.C_RZSOC, C.*, D.C_NOMCEN, F.C_NOMDES, ISNULL(E.C_DESCLI, ' ') AS C_DESCLI, A.C_NATFOR " +
                           "FROM OP0100 A LEFT JOIN JB0100 E ON(A.C_CODEMP = E.C_CODEMP AND A.C_ANOJOB = E.C_ANOJOB and A.C_NUMJOB = E.C_NUMJOB), " +
                           "OP0200 B, OP0250 C,	QC0300 D, OP1000 F,	MC0100 G WHERE A.C_CODEMP = '" + v_codemp + "' AND A.C_NUMORD = '" + v_numord + "' AND " +
                           "A.C_TIPOOP <> '04' AND C.C_PROVEI = '0' AND A.C_CODFOR = G.C_CDCLI AND A.C_CODEMP = B.C_CODEMP AND A.C_NUMORD = B.C_NUMORD AND " +
                           "B.C_CODEMP = C.C_CODEMP AND B.C_NUMORD = C.C_NUMORD AND B.C_NUMITE = C.C_NUMITE AND C.C_GRUDES = F.C_GRUDES AND A.C_CENCUS = D.C_CODCEN " +
                           "ORDER BY B.C_NUMITE, C.C_SEQDES";
            SqlCommand command = new SqlCommand(Query, GetConnection());
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = GetConnection();

                DataTable dTable = new DataTable("retornarDadosOPRelatorio");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dTable);

                return dTable;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable RetornarDadosOPSubRelatorio(string v_codemp, string v_numord)
        {
            string Query = "SELECT A.C_CODEMP, A.C_NUMORD, C.C_CUSDES, (C.C_CODCON+' - '+D.C_NOMCON) AS C_NOMCON, " +
                           "C.C_CODCEN, E.C_NOMCEN, (C.C_ANOJOB+' - '+C.C_NUMJOB) AS C_NUMJOB, C.C_NUMOSE, ISNULL(SUM(C.C_VALRAT), 0) AS C_VALRAT " +
                           "FROM OP0100 A, OP0200 B, OP0270 C, QC0200 D, QC0300 E WHERE A.C_CODEMP = '" + v_codemp + "' AND " +
                           "A.C_NUMORD = '" + v_numord + "' AND A.C_CODEMP = B.C_CODEMP AND A.C_NUMORD = B.C_NUMORD AND " +
                           "A.C_CODEMP = C.C_CODEMP AND A.C_NUMORD = C.C_NUMORD AND B.C_NUMITE = C.C_NUMITE AND " +
                           "C.C_CODCEN = E.C_CODCEN AND C.C_CONRED = D.C_CONRED GROUP BY A.C_CODEMP, A.C_NUMORD, " +
                           "C.C_CUSDES,C.C_CODCON,D.C_NOMCON, C.C_CODCEN, E.C_NOMCEN, C.C_ANOJOB, C.C_NUMJOB, " +
                           "C.C_NUMOSE ORDER BY C.C_CUSDES, D.C_NOMCON";
            SqlCommand command = new SqlCommand(Query, GetConnection());
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = GetConnection();

                DataTable dTable = new DataTable("retornarDadosOPSubRelatorio");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dTable);

                return dTable;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable RetornarListaOPRelatorio1(string v_select)
        {
            string Query = "SELECT A.C_CODEMP, A.C_NUMORD, A.C_TIPOOP, A.C_CODFOR, RTRIM(A.C_NOMFOR) AS C_NOMFOR, " +
                           "SUBSTRING(A.C_DATEMI,7,2)+'/'+SUBSTRING(A.C_DATEMI,5,2)+'/'+SUBSTRING(A.C_DATEMI,1,4) AS C_DATEMI, A.C_DATVEN, " +
                           "A.C_VALTOT, A.C_ANOJOB, A.C_NUMJOB, A.C_CENCUS, RTRIM(B.C_NOMCEN) AS C_NOMCEN, D.C_NUMITE, D.C_DATITE, RTRIM(D.C_REFDES) AS C_REFDES, " +
                           "RTRIM(D.C_DESITE) AS C_DESITE, D.C_VALITE, C.C_NUMOSE, ISNULL(I.C_NOMOSE, ' ') as C_NOMOSE, C.C_PERRAT, G.C_PROVEI, " +
                           "G.C_NUMPLA, G.C_KILINI, G.C_KILFIM, RTRIM(G.C_OBSITE) AS C_OBSITE, RTRIM(H.C_NOMDES) AS C_NOMDES, G.C_VALDES FROM OP0100 A, QC0300 B, " +
                           "OP0200 D, OP0250 G, OP1000 H, OP0270 C LEFT JOIN OS0300 I ON(C.C_NUMOSE= I.C_NUMOSE) WHERE " +
                           "A.C_STAORD = 'FI' AND A.C_CENCUS = B.C_CODCEN AND A.C_NUMORD = D.C_NUMORD AND A.C_NUMORD = G.C_NUMORD " +
                           " AND D.C_NUMITE = G.C_NUMITE AND A.C_NUMORD = C.C_NUMORD AND D.C_NUMITE = C.C_NUMITE AND G.C_GRUDES = H.C_GRUDES " + v_select;
            SqlCommand command = new SqlCommand(Query, GetConnection());
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = GetConnection();

                DataTable dTable = new DataTable("retornarListaOPRelatorio");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dTable);

                return dTable;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable RetornarListaOPRelatorio(string v_select)
        {
            string Query = "SELECT A.C_CODEMP, A.C_NUMORD, A.C_DATEMIV, A.C_DATVENV, A.C_CODFOR, A.C_NOMFOR, D.C_NUMITE, D.C_REFDES, D.C_ITEDES, RTRIM(D.C_DESITE) AS C_DESITE, D.C_VALITE, " +
                           "D.C_NUMPED, D.C_ITEPED, D.C_FORDES, D.C_NOMDES, D.C_NUMOSE, D.C_ANOJOB, (A.C_ANOJOB+'-'+A.C_NUMJOB) AS C_NUMJOB, RTRIM(B.C_NOMCEN) AS C_CENCUS, " +
                           "D.C_SEQMAT, H.C_NOMDES, G.C_VALDES FROM OP0100 A, QC0300 B, OP0200 D, OP0250 G, OP1000 H WHERE A.C_STAORD <> 'CN' AND A.C_NUMORD = D.C_NUMORD AND " +
                           "A.C_CENCUS = B.C_CODCEN AND A.C_NUMORD = G.C_NUMORD AND D.C_NUMITE = G.C_NUMITE AND G.C_GRUDES = H.C_GRUDES " + v_select + "";
            SqlCommand command = new SqlCommand(Query, GetConnection());
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = GetConnection();

                DataTable dTable = new DataTable("retornarListaOPRelatorio");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dTable);

                return dTable;
            }
            finally
            {
                connection.Close();
            }
        }

        #endregion REPORT METHODS
    }
}
