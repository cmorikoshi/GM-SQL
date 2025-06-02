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
    public partial class TELA_CADASTRO_MATERIAIS_DETALHE : Form
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
        public TELA_CADASTRO_MATERIAIS_DETALHE()
        {
            InitializeComponent();
        }

        private void TELA_CADASTRO_MATERIAIS_DETALHE_Load(object sender, EventArgs e)
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
            if (operacao == Util.Operacao.Alteracao)
            {
                c_codmat.Text = v_codmat;
                RetornarDadosMateriaisCM0100();

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
            cm0100model.C_TIPMAT = cb_tipmat.SelectedValue.ToString() ;
            cm0100model.C_RESQTD = Convert.ToDecimal(c_resqtd.Text);
            cm0100model.C_DISQTD = Convert.ToDecimal(c_disqtd.Text);
            cm0100model.C_SALQTD = Convert.ToDecimal(c_salqtd.Text);
            cm0100model.C_ESTMIN = Convert.ToDecimal(c_estmin.Text);
            cm0100model.C_ESTMAX = Convert.ToDecimal(c_estmax.Text);
            cm0100model.C_CONMED = Convert.ToDecimal(c_conmed.Text);
            cm0100model.C_LOTECO = Convert.ToDecimal(c_loteco.Text);
            cm0100model.C_PESESP = Convert.ToDecimal(c_pesesp.Text);
            if (c_datult.Text.Count(c => Char.IsLetterOrDigit(c)) == 8)
            {
                cm0100model.C_DATULT = Util.DTOC(c_datult.Text);
            }
            else
            {
                cm0100model.C_DATULT = "";
            }
            cm0100model.C_UNIPE1 = c_unipe1.Text;
            cm0100model.C_UNIPE2 = c_unipe2.Text;
            cm0100model.C_PRAABA = Convert.ToDecimal(c_praaba.Text);
            cm0100model.C_LOCCOR = c_loccor.Text;
            cm0100model.C_LOCPRA = c_locpra.Text;
            if (c_preucr.Text.Count(c => Char.IsLetterOrDigit(c)) == 0)
            {
                cm0100model.C_PREUCR = 0;
            }
            if (c_preucr.Text.Count(c => Char.IsLetterOrDigit(c)) > 0)
            {
                cm0100model.C_PREUCR = Convert.ToDecimal(c_preucr.Text);
            }

            if (c_datpre.Text.Count(c => Char.IsLetterOrDigit(c)) == 8)
            {
                cm0100model.C_DATPRE = Util.DTOC(c_datpre.Text);
            }
            else
            {
                cm0100model.C_DATPRE = "";
            }
            cm0100model.C_LOCBOX = c_locbox.Text;

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
        public void InserirLogDadosMaterialCM0100LOG()
        {
            cm0100LogModel.C_CODMAT = c_codmat.Text;
            cm0100LogModel.C_DESMAT = c_desmat.Text;
            cm0100LogModel.C_CHAPES = cb_chapes.Text.TrimEnd();
            cm0100LogModel.C_UNIMED = cb_unimed.Text;
            cm0100LogModel.C_NUMDES = c_numdes.Text;
            cm0100LogModel.C_ORIMAT = cb_orimat.SelectedValue.ToString();
            cm0100LogModel.C_TIPMAT = cb_tipmat.SelectedValue.ToString();
            cm0100LogModel.C_ESTMIN = Convert.ToDecimal(c_estmin.Text);
            cm0100LogModel.C_ESTMAX = Convert.ToDecimal(c_estmax.Text);
            cm0100LogModel.C_LOTECO = Convert.ToDecimal(c_loteco.Text);
            cm0100LogModel.C_PESESP = Convert.ToDecimal(c_pesesp.Text);
            cm0100LogModel.C_PRAABA = Convert.ToDecimal(c_praaba.Text);
            cm0100LogModel.C_UNIPE1 = c_unipe1.Text;
            cm0100LogModel.C_UNIPE2 = c_unipe2.Text;
            cm0100LogModel.C_LOCCOR = c_loccor.Text;
            cm0100LogModel.C_LOCPRA = c_locpra.Text;
            cm0100LogModel.C_LOCBOX = c_locbox.Text;
            if (c_datult.Text.Count(c => Char.IsLetterOrDigit(c)) == 8)
            {
                cm0100LogModel.C_DATULT = Util.DTOC(c_datult.Text);
            }
            else
            {
                cm0100LogModel.C_DATULT = "";
            }
            cm0100LogModel.C_DATLOG = DateTime.Now;
            cm0100LogModel.C_NOMUSU = v_usuario;
            cm0100LogModel.C_TIPOPE = operacao.ToString();
            cm0100LogModel.C_MAQUSU = RetornarEnderecoMac();


            cm0100bll.InserirLogMaterialCM0100Log(cm0100LogModel);
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
            String V_KEYDYN = null;
            cm0100bll.RetornarDadosMaterialCM0100(cm0100model, c_codmat.Text);
            c_desmat.Text = cm0100model.C_DESMAT;
            cb_chapes.Text = cm0100model.C_CHAPES;
            cb_unimed.Text = cm0100model.C_UNIMED;
            c_numdes.Text = cm0100model.C_NUMDES;
            cb_orimat.SelectedValue = cm0100model.C_ORIMAT;
            cb_tipmat.Text = cm0100model.C_TIPMAT;
            c_resqtd.Text = cm0100model.C_RESQTD.ToString();
            c_disqtd.Text = cm0100model.C_DISQTD.ToString();
            c_salqtd.Text = cm0100model.C_SALQTD.ToString();
            c_estmin.Text = cm0100model.C_ESTMIN.ToString();
            c_estmax.Text = cm0100model.C_ESTMAX.ToString();
            c_conmed.Text = cm0100model.C_CONMED.ToString();
            c_loteco.Text = cm0100model.C_LOTECO.ToString();
            c_pesesp.Text = cm0100model.C_PESESP.ToString();
            c_datult.Text = Util.CTOD(cm0100model.C_DATULT);
            c_unipe1.Text = cm0100model.C_UNIPE1;
            c_unipe2.Text = cm0100model.C_UNIPE2;
            c_unipe2.Text = cm0100model.C_KEYDYN;
            c_praaba.Text = cm0100model.C_PRAABA.ToString();
            c_loccor.Text = cm0100model.C_LOCCOR;
            c_locpra.Text = cm0100model.C_LOCPRA;
            c_locbox.Text = cm0100model.C_LOCBOX;
            c_preucr.Text = cm0100model.C_PREUCR.ToString();
            c_datpre.Text = Util.CTOD(cm0100model.C_DATPRE);

            V_KEYDYN = cm0100model.C_KEYDYN;
            if (V_KEYDYN != "" )
            {
                c_numnof.Text = V_KEYDYN.Substring(7, 7);
                c_codfor.Text = V_KEYDYN.Substring(0, 6);
            }




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


        #region BUTTONS - EVENTS


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
                    MessageBox.Show("O campo Unid.Medida é obrigatório o preenchimento!!");
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
                if (operacao == Util.Operacao.Inclusao)
                {
                    InserirLogDadosMaterialCM0100LOG();
                    AlterarDadosMaterialCM0100();
                    if(cb_tipmat.SelectedValue .ToString() == "P")
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
                    TELA_CADASTRO_MATERIAIS cadastroMateriais = new TELA_CADASTRO_MATERIAIS();
                    cadastroMateriais.v_codmat = c_codmat.Text;

                }
                if (operacao == Util.Operacao.Alteracao)
                {
                    InserirLogDadosMaterialCM0100LOG();
                    AlterarDadosMaterialCM0100();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        private void btnCancela_Click(object sender, EventArgs e)
        {

            if (operacao == Util.Operacao.Inclusao)
            {
                if (MessageBox.Show("Confirma o cancelamento da operação??", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                ExcluirIDCodigoMaterialCM0100();
                //Excluir método quando atualizar Banco de Dados
                ExcluirIDCodigoMaterialCE0200();
            }
            this.Close();
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

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            c_desmat.Text = cb_desmat.Text.TrimEnd();
        }


        #endregion BUTTONS - EVENTS

    }
}
