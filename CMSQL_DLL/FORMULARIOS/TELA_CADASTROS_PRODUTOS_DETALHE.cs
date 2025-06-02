using GM_BLL;
using GM_MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSQL_DLL.FORMULARIOS
{
    public partial class TELA_CADASTROS_PRODUTOS_DETALHE : Form
    {
        CM0100BLL cm0100bll = new CM0100BLL();
        CM0100MODEL cm0100model = new CM0100MODEL();
        CM0700BLL cm0700bll = new CM0700BLL();
        CM0700MODEL cm0700model = new CM0700MODEL();    

        CM0600BLL cm0600bll = new CM0600BLL();
        CM0600MODEL cm0600model = new CM0600MODEL();

        TD0100BLL td0100bll = new TD0100BLL();

        #region VARIÁVEIS

        private string V_CODEMP;
        public string v_codemp
        {
            get { return V_CODEMP; }
            set { V_CODEMP = value; }
        }

        private string V_CODEQU;
        public string v_codequ
        {
            get { return V_CODEQU; }
            set { V_CODEQU = value; }
        }

        private string V_CODMAT;
        public string v_codmat
        {
            get { return V_CODMAT; }
            set { V_CODMAT = value; }
        }

        private string V_NUMDES;
        public string v_numdes
        {
            get { return V_NUMDES; }
            set { V_NUMDES = value; }
        }

        private string V_USUARIO;
        public string v_usuario
        {
            get { return V_USUARIO; }
            set { V_USUARIO = value; }
        }


        #endregion VARIÁVEIS

        public TELA_CADASTROS_PRODUTOS_DETALHE()
        {
            InitializeComponent();
        }

        private void TELA_CADASTROS_PRODUTOS_DETALHE_Load(object sender, EventArgs e)
        {
            c_codequ.Text = v_codequ;
            RetornarTipoEquipamentoTD0100();
            RetornarListaMateriaisCM0700();
            RetornarDadosProdutoCM0600();
            if (cb_tipequ.Text == String.Empty)
            {
                cb_tipequ.SelectedIndex = -1;
            }
        }

        #region METHODS

        public void InserirIDCadastroMateriais()
        {
            cm0100model.C_CODMAT = cm0100bll.RetornarUltIDCadastroMaterialCM0100();

            cm0100bll.InserirIDCadastroMateriaisCM0100(cm0100model);
        }

        public void ExcluirItemListaMateriais()
        {
            cm0700model.C_CODEQU = SF_CM0700A.CurrentRow.Cells["C_CODEQU1"].Value.ToString();
            cm0700model.C_SEQEQU = SF_CM0700A.CurrentRow.Cells["C_SEQEQU"].Value.ToString();

            cm0700bll.ExcluirItemListaMateriaisCM0700(cm0700model);
        }

        #endregion METHODS

        #region RETURN METHODS
        public void RetornarDadosProdutoCM0600()
        {
            try
            {
                cm0600bll.RetornarDadosProdutoCM0600(cm0600model, c_codequ.Text);
                c_desequ.Text = cm0600model.C_DESEQU.TrimEnd();
                c_numdes.Text = cm0600model.C_NUMDES.TrimEnd();
                cb_tipequ.SelectedValue = cm0600model.C_TIPEQU;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void RetornarListaMateriaisCM0700()
        {
            try
            {
                SF_CM0700A.DataSource = cm0700bll.RetornarListaMateriais(c_codequ.Text);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void RetornarTipoEquipamentoTD0100()
        {
            try
            {
                cb_tipequ.DataSource = td0100bll.RetornarTipoEquipamentoComboBox();
                cb_tipequ.DisplayMember = "C_TEXTO";
                cb_tipequ.ValueMember = "C_VALOR";
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        #endregion RETURN METHODS

        #region BUTTONS

        private void btnIncluirMaterial_Click(object sender, EventArgs e)
        {
            TELA_CADASTRO_MATERIAIS_PRODUTO_DETALHE cadastroMaterialProdutoDetalhe = new TELA_CADASTRO_MATERIAIS_PRODUTO_DETALHE();
            cadastroMaterialProdutoDetalhe.operacao = Util.Operacao.Inclusao;
            cadastroMaterialProdutoDetalhe.v_codmat = cm0100bll.RetornarUltIDCadastroMaterialCM0100();
            InserirIDCadastroMateriais();
            cadastroMaterialProdutoDetalhe.ShowDialog();
        }

        private void btnIncluirItem_Click(object sender, EventArgs e)
        {
            if (SF_CM0100C.SelectedRows.Count == 0)
            {
                MessageBox.Show("Favor Selecionar um material para incluir na lista!!!");
                return;
            }
            //int linhaSelecionada = SF_CM0700A.CurrentRow.Index;
            int totalLinhasCM_CM0700A = SF_CM0700A.Rows.Count;

            TELA_CADASTROS_PRODUTOS_ITENS_LISTA cadastroProdutosItensLista = new TELA_CADASTROS_PRODUTOS_ITENS_LISTA();
            cadastroProdutosItensLista.operacao = Util.Operacao.Inclusao;
            cadastroProdutosItensLista.v_codmat = SF_CM0100C.CurrentRow.Cells["C_CODMAT1"].Value.ToString();
            cadastroProdutosItensLista.v_desmat = SF_CM0100C.CurrentRow.Cells["C_DESMAT2"].Value.ToString();
            cadastroProdutosItensLista.v_unimed = SF_CM0100C.CurrentRow.Cells["C_UNIMED"].Value.ToString();
            cadastroProdutosItensLista.v_codequ = c_codequ.Text;
            cadastroProdutosItensLista.v_desequ = c_desequ.Text;
            cadastroProdutosItensLista.ShowDialog();

            RetornarListaMateriaisCM0700();

            if (cadastroProdutosItensLista.operacao == Util.Operacao.Inclusao)
            {
                if (SF_CM0700A.RowCount > 0)
                {
                    if (SF_CM0700A.RowCount >= totalLinhasCM_CM0700A)
                    {
                        int linhaIncluida = SF_CM0700A.RowCount - 1;
                        //SF_CM0700A.CurrentCell = SF_CM0700A.Rows[linhaIncluida].Cells[3];
                        SF_CM0700A.Rows[linhaIncluida].Selected = true;
                    }
                }
            }

        }

        private void btnAlteraItem_Click(object sender, EventArgs e)
        {
            if (SF_CM0700A.SelectedRows.Count == 0)
            {
                MessageBox.Show("Favor Selecionar um item para alterar na lista!!!");
                return;
            }
            int linhaSelecionada = SF_CM0700A.CurrentRow.Index;

            TELA_CADASTROS_PRODUTOS_ITENS_LISTA cadastroProdutosItensLista = new TELA_CADASTROS_PRODUTOS_ITENS_LISTA();
            cadastroProdutosItensLista.operacao = Util.Operacao.Alteracao;
            cadastroProdutosItensLista.v_codequ = SF_CM0700A.CurrentRow.Cells["C_CODEQU1"].Value.ToString();
            cadastroProdutosItensLista.v_seqequ = SF_CM0700A.CurrentRow.Cells["C_SEQEQU"].Value.ToString();
            cadastroProdutosItensLista.v_desmat = SF_CM0700A.CurrentRow.Cells["C_DESMAT3"].Value.ToString();
            cadastroProdutosItensLista.v_desequ = c_desequ.Text;
            cadastroProdutosItensLista.ShowDialog();

            RetornarListaMateriaisCM0700();

            if (cadastroProdutosItensLista.operacao == Util.Operacao.Alteracao)
            {
                if (SF_CM0700A.RowCount >= linhaSelecionada)
                {
                    SF_CM0700A.Rows[linhaSelecionada].Selected = true;
                }
            }
        }

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            if (SF_CM0700A.SelectedRows.Count == 0)
            {
                MessageBox.Show("Favor Selecionar um item para excluir na lista!!!");
                return;
            }
            if (MessageBox.Show("Confirma a exclusão deste item??", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            int linhaSelecionada = SF_CM0700A.CurrentRow.Index;

            ExcluirItemListaMateriais();
            RetornarListaMateriaisCM0700();

            if (SF_CM0700A.RowCount >= linhaSelecionada)
            {
                SF_CM0700A.Rows[linhaSelecionada - 1].Selected = true;
            }

        }

        private void btnImportaLista_Click(object sender, EventArgs e)
        {
            TELA_IMPORTACAO_OS_PRODUTO importaOSProduto = new TELA_IMPORTACAO_OS_PRODUTO();
            importaOSProduto.ShowDialog();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion BUTTONS


        #region RADIO BUTTON EVENTS

        private void rbCodigo_Click(object sender, EventArgs e)
        {
            rbCodigo.Checked = true;
            c_codmat.ReadOnly = false;
            rbDescricao.Checked = false;
            c_desmat1.Text = "";

        }

        private void rbDescricao_Click(object sender, EventArgs e)
        {
            rbCodigo.Checked = false;
            c_codmat.ReadOnly = true;
            c_codmat.Text = "";
            rbDescricao.Checked = true;
            c_desmat1.ReadOnly = false;
        }

        private void c_codmat_TextChanged(object sender, EventArgs e)
        {
            string v_select = null;
            if (c_codmat.Text.Count(c => Char.IsLetterOrDigit(c)) > 4)
            {
                v_select = " C_CODMAT LIKE '%" + c_codmat.Text + "%' ORDER BY C_DESMAT";
                SF_CM0100C.DataSource = cm0100bll.RetornarMaterialPesquisaTelaItensProduto(v_select);
            }

        }

        private void c_desmat1_TextChanged(object sender, EventArgs e)
        {
            string v_select = null;
            if (c_desequ.Text.Count(c => Char.IsLetterOrDigit(c)) > 3)
            {
                v_select = " C_DESMAT LIKE '%" + c_desmat1.Text + "%' ORDER BY C_DESMAT";
                SF_CM0100C.DataSource = cm0100bll.RetornarMaterialPesquisaTelaItensProduto(v_select);
            }
        }

        #endregion RADIO BUTTON EVENTS


    }
}
