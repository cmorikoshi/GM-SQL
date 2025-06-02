using GM_BLL;
using GM_MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSQL_DLL.FORMULARIOS
{
    public partial class TELA_CADASTRO_MATERIAIS_PRODUTO_DETALHE : Form
    {

        public class OrigemMaterial
        {
            public string Valor { get; set; }
            public string Descricao { get; set; }
        }

        CM0100BLL cm0100bll = new CM0100BLL();
        CM0100MODEL cm0100model = new CM0100MODEL();
        CM0100LOGMODEL cm0100LogModel = new CM0100LOGMODEL();

        CM0500BLL cm0500bll = new CM0500BLL();
        TD0100BLL td0100bll = new TD0100BLL();

        CE0200BLL ce0200bll = new CE0200BLL();
        CE0200MODEL ce0200model = new CE0200MODEL();

        CM0600BLL cm0600bll = new CM0600BLL();
        CM0600MODEL cm0600model = new CM0600MODEL();


        public class ComboBoxItem
        {
            public string Descricao { get; set; }
        }

        #region ENUMS

        Util.Operacao OPERACAO;

        public Util.Operacao operacao
        {
            get { return OPERACAO; }
            set { OPERACAO = value; }
        }

        #endregion ENUMS


        #region VARIÁVEIS

        private string V_CODEMP;
        public string v_codemp
        {
            get { return V_CODEMP; }
            set { V_CODEMP = value; }
        }

        private string V_CODMAT;
        public string v_codmat
        {
            get { return V_CODMAT; }
            set { V_CODMAT = value; }
        }

        private string V_USUARIO;
        public string v_usuario
        {
            get { return V_USUARIO; }
            set { V_USUARIO = value; }
        }


        #endregion VARIÁVEIS

        public TELA_CADASTRO_MATERIAIS_PRODUTO_DETALHE()
        {
            InitializeComponent();
        }

        private void TELA_CADASTRO_MATERIAIS_PRODUTO_DETALHE_Load(object sender, EventArgs e)
        {

            RetornarPalavraChave();
            RetornarTipoMaterialTD0100();
            RetornarOrigemMaterial();
            RetornarUnidadeMedidaTD0100();
            if (operacao == Util.Operacao.Inclusao)
            {
                c_codmat.Text = v_codmat;
                cb_chapes.SelectedIndex = -1;
                cb_unimed.SelectedIndex = -1;
                cb_orimat.SelectedIndex = -1;
                cb_tipmat.SelectedIndex = -1;
                cb_desmat.SelectedIndex = -1;

            }

        }

        #region INSERT-UPDATE-DELETE METHODS
        public void AlterarDadosMaterialCM0100()
        {
            cm0100model.C_DESMAT = c_desmat.Text;
            cm0100model.C_CHAPES = cb_chapes.Text;
            cm0100model.C_UNIMED = cb_unimed.Text;
            cm0100model.C_NUMDES = c_numdes.Text;
            cm0100model.C_ORIMAT = cb_orimat.SelectedValue.ToString();
            cm0100model.C_TIPMAT = cb_tipmat.SelectedValue.ToString();
            cm0100model.C_RESQTD = 0;
            cm0100model.C_DISQTD = 0;
            cm0100model.C_SALQTD = 0;
            cm0100model.C_ESTMIN = 0;
            cm0100model.C_ESTMAX = 0;
            cm0100model.C_CONMED = 0;
            cm0100model.C_LOTECO = 0;
            cm0100model.C_PESESP = 0;
            cm0100model.C_DATULT = "";
            cm0100model.C_UNIPE1 = "";
            cm0100model.C_UNIPE2 = "";
            cm0100model.C_PRAABA = 0;
            cm0100model.C_LOCCOR = "";
            cm0100model.C_LOCPRA = "";
            cm0100model.C_PREUCR = 0;
            cm0100model.C_DATPRE = "";
            cm0100model.C_LOCBOX = "";

            cm0100model.C_CODMAT = c_codmat.Text;
            cm0100bll.AlterarMaterialCM0100(cm0100model);
        }

        public void InserirProdutoCM0600()
        {
            cm0600model.C_CODEQU = c_codmat.Text;
            cm0600model.C_DESEQU = c_desmat.Text;
            cm0600model.C_TIPEQU = "";
            cm0600model.C_NUMDES = c_numdes.Text == string.Empty ? "" : c_numdes.Text;


            cm0600bll.InserirProdutoCM0600(cm0600model);
        }

        public void ExcluirIDCodigoMaterialCM0100()
        {
            try
            {
                cm0100model.C_CODMAT = c_codmat.Text;
                cm0100bll.ExcluirIDCadastroMateriaisCM0100(cm0100model);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void ExcluirIDCodigoMaterialCE0200()
        {
            try
            {
                ce0200model.C_CODMAT = c_codmat.Text;
                ce0200bll.ExcluirIDCadastroMateriaisCE0200(ce0200model);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #endregion INSERT-UPDATE-DELETE METHODS

        #region RETURN METHODS

        public void RetornarOrigemMaterial()
        {
            List<OrigemMaterial> v_orimat = new List<OrigemMaterial>
            {
                new OrigemMaterial { Valor = "N", Descricao = "NACIONAL" },
                new OrigemMaterial { Valor = "I", Descricao = "IMPORTADO" },

             };

            cb_orimat.DataSource = v_orimat;
            cb_orimat.DisplayMember = "Descricao";
            cb_orimat.ValueMember = "Valor";
        }
        public void RetornarPalavraChave()
        {
            try
            {
                cb_chapes.DataSource = cm0500bll.RetornarPalavrasChaveCM0500();
                cb_chapes.DisplayMember = "C_CHAPES";

            }
            catch (Exception)
            {
                return;
            }
        }

        public void RetornarDescricaoMaterial()
        {
            cb_desmat.DataSource = cm0100bll.RetornarDescricaoMaterialComboBox(cb_desmat.Text);
            cb_desmat.DisplayMember = "C_DESMAT";
        }
        public void RetornarTipoMaterialTD0100()
        {
            try
            {
                cb_tipmat.DataSource = td0100bll.RetornarTipoMaterialComboBox();
                cb_tipmat.DisplayMember = "C_TEXTO";
                cb_tipmat.ValueMember = "C_VALOR";

            }
            catch (Exception)
            {
                return;
            }
        }
        public void RetornarUnidadeMedidaTD0100()
        {
            try
            {
                cb_unimed.DataSource = td0100bll.RetornarUnidadeMedidaComboBox();
                cb_unimed.DisplayMember = "C_KEYTAB";

            }
            catch (Exception)
            {
                return;
            }
        }
        public void RetornarDadosMateriaisCM0100()
        {
            cm0100bll.RetornarDadosMaterialCM0100(cm0100model, c_codmat.Text);
            c_desmat.Text = cm0100model.C_DESMAT;
            cb_chapes.Text = cm0100model.C_CHAPES;
            cb_unimed.Text = cm0100model.C_UNIMED;
            c_numdes.Text = cm0100model.C_NUMDES;
            cb_orimat.SelectedValue = cm0100model.C_ORIMAT;
            cb_tipmat.Text = cm0100model.C_TIPMAT;

        }
        public static string RetornarEnderecoMac()
        {
            try
            {
                NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
                String enderecoMAC = string.Empty;
                foreach (NetworkInterface adapter in nics)
                {
                    // retorna endereço MAC do primeiro cartão
                    if (enderecoMAC == String.Empty)
                    {
                        IPInterfaceProperties properties = adapter.GetIPProperties();
                        enderecoMAC = adapter.GetPhysicalAddress().ToString();
                    }
                }
                return enderecoMAC;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        #endregion RETURN METHODS

        #region BUTTONS
        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (c_desmat.Text == string.Empty)
                {
                    MessageBox.Show("O campo Descrição é obrigatório o preenchimento!!");
                    return;
                }
                if (cb_tipmat.Text == string.Empty)
                {
                    MessageBox.Show("O campo Tipo é obrigatório o preenchimento!!");
                    return;
                }
                if (cb_unimed.Text == string.Empty)
                {
                    MessageBox.Show("O campo Unid. Medida é obrigatório o preenchimento!!");
                    return;
                }
                if (cb_orimat.Text == string.Empty)
                {
                    MessageBox.Show("O campo Origem/Tipo é obrigatório o preenchimento!!");
                    return;
                }
                if (cb_chapes.Text == string.Empty)
                {
                    MessageBox.Show("O campo Palavra Chave é obrigatório o preenchimento!!");
                    return;
                }
                AlterarDadosMaterialCM0100();
                if (cb_tipmat.SelectedValue.ToString() == "P")
                {
                    try
                    {
                        InserirProdutoCM0600();
                    }
                    catch (Exception ex)
                    {

                        throw new Exception(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            try
            {
                ExcluirIDCodigoMaterialCM0100();
                ExcluirIDCodigoMaterialCE0200();
                this.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        private void cb_desmat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                c_desmat.Text = "";
                if (cb_desmat.Text.Length > 4)
                {
                    string textoDigitado = cb_desmat.Text.ToLower();
                    string filtro = $"C_DESMAT LIKE '%{textoDigitado}%'";
                    List<CM0100MODEL> materiais = cm0100bll.RetornarListaMaterialPesquisa(filtro);

                    cb_desmat.Items.Clear();
                    foreach (var material in materiais)
                    {
                        cb_desmat.Items.Add(material.C_DESMAT);
                    }
                    cb_desmat.DroppedDown = true;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void cb_desmat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_desmat.SelectedIndex >= 0)
                {
                    cb_desmat.Text = cb_desmat.SelectedItem.ToString();
                    c_desmat.Text = cb_desmat.Text;
                    cb_desmat.DroppedDown = false;
                }
                cb_desmat.Items.Clear();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


        #endregion BUTTONS


    }
}
