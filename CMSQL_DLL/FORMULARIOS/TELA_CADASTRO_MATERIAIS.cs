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
    public partial class TELA_CADASTRO_MATERIAIS : Form
    {
        CM0100MODEL cm0100model = new CM0100MODEL();

        CM0100BLL cm0100bll = new CM0100BLL();
        CM0500BLL cm0500bll = new CM0500BLL();

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
        public TELA_CADASTRO_MATERIAIS()
        {
            InitializeComponent();
        }

        private void TELA_CADASTRO_MATERIAIS_Load(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Marquee; // Animação contínua
            progressBar1.Visible = false; // Inicia invisível

        }

        #region METHODS

        public void RetornarMaterialAposInsercao()
        {
            string v_select = null;
            if (v_codmat == String.Empty)
            {
                return;
            }
            else
            {
                v_select = " C_CODMAT = '" + v_codmat + "' Order BY C_DESMAT DESC";
                SF_CM0100A.DataSource = cm0100bll.RetornarMaterialAposInsercao(v_select);
            }
        }

        public void InserirIDCadastroMateriais()
        {
            cm0100model.C_CODMAT = cm0100bll.RetornarUltIDCadastroMaterialCM0100();

            cm0100bll.InserirIDCadastroMateriaisCM0100(cm0100model);
        }

        #endregion METHODS


        #region LOADING METHODS
        public void RetornarPalavraChave()
        {
            try
            {
                if (rbPalavraChave.Checked == true)
                {
                    cbPalavraChave.Enabled = true;
                    cbPalavraChave.DataSource = cm0500bll.RetornarPalavrasChaveCM0500();
                    cbPalavraChave.DisplayMember = "C_CHAPES";
                    cbPalavraChave.SelectedIndex = -1;
                }
                if (rbPalavraChave.Checked == false)
                {
                    cbPalavraChave.SelectedIndex = -1;
                    cbPalavraChave.Enabled = false;
                }

            }
            catch (Exception)
            {
                return;
            }
        }

        private void ExecutarOperacaoAssincrona()
        {
            Task.Delay(2000); // Simula operação de 2 segundos
        }

        public void AtualizarFormulario()
        {
            string v_select = null;
            try
            {
                if (rbCodigo.Checked == true)
                {
                    v_select = " C_CODMAT LIKE '" + txtCodmat.Text + "%' Order BY C_DESMAT DESC";
                    SF_CM0100A.DataSource = cm0100bll.RetornarMaterialComboBox(v_select);
                }
                if (rbDescricao.Checked == true)
                {
                    v_select = " C_DESMAT LIKE '" + txtDesMat.Text + "%' Order BY C_DESMAT DESC";
                    SF_CM0100A.DataSource = cm0100bll.RetornarMaterialComboBox(v_select);
                }
                if (rbPalavraChave.Checked == true)
                {
                    v_select = " C_CHAPES = '" + cbPalavraChave.Text + "' Order BY C_DESMAT DESC";
                    SF_CM0100A.DataSource = cm0100bll.RetornarMaterialComboBox(v_select);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #endregion LOADING METHODS

        #region BUTTONS

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.Value = 50;
            try
            {
                TELA_CADASTRO_MATERIAIS_DETALHE cadastroMateriaisDetalhe = new TELA_CADASTRO_MATERIAIS_DETALHE();
                cadastroMateriaisDetalhe.operacao = Util.Operacao.Inclusao;
                cadastroMateriaisDetalhe.v_codmat = cm0100bll.RetornarUltIDCadastroMaterialCM0100();
                ExecutarOperacaoAssincrona();
                InserirIDCadastroMateriais();
                cadastroMateriaisDetalhe.v_usuario = v_usuario;
                cadastroMateriaisDetalhe.ShowDialog();

                v_codmat = cadastroMateriaisDetalhe.v_codmat;
                RetornarMaterialAposInsercao();
            }
            finally
            {
                progressBar1.Visible = false;
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (SF_CM0100A.SelectedRows.Count == 0)
            {
                MessageBox.Show("Favor selecionar um item para continuar!!");
                return;
            }

            int linhaSelecionada = SF_CM0100A.CurrentRow.Index;

            TELA_CADASTRO_MATERIAIS_DETALHE cadastroMateriaisDetalhe = new TELA_CADASTRO_MATERIAIS_DETALHE();
            cadastroMateriaisDetalhe.operacao = Util.Operacao.Alteracao;
            cadastroMateriaisDetalhe.v_codmat = SF_CM0100A.CurrentRow.Cells["C_CODMAT"].Value.ToString();
            cadastroMateriaisDetalhe.v_usuario = v_usuario;
            cadastroMateriaisDetalhe.ShowDialog();

            AtualizarFormulario();

            if (SF_CM0100A.RowCount > 0)
            {
                if (SF_CM0100A.RowCount >= linhaSelecionada)
                {
                    SF_CM0100A.CurrentCell = SF_CM0100A.Rows[linhaSelecionada].Cells[0];
                }
                else
                {
                    SF_CM0100A.CurrentCell = SF_CM0100A.Rows[linhaSelecionada - 1].Cells[0];
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
        private void btnPesqMaterial_Click(object sender, EventArgs e)
        {
            string v_select = null;
            try
            {
                if (rbCodigo.Checked == true)
                {
                    if (txtCodmat.Text.Count(c => Char.IsLetterOrDigit(c)) < 4)
                    {
                        MessageBox.Show("Favor inserir Código de Material!!!");
                        return;
                    }
                    else
                    {
                        v_select = " C_CODMAT LIKE '" + txtCodmat.Text + "%' Order BY C_DESMAT DESC";
                        SF_CM0100A.DataSource = cm0100bll.RetornarMaterialComboBox(v_select);
                    }
                }
                if (rbDescricao.Checked == true)
                {
                    if (txtDesMat.Text.Count(c => Char.IsLetterOrDigit(c)) < 6)
                    {
                        MessageBox.Show("Favor inserir Descrição do Material!!!!");
                        return;
                    }
                    else
                    {
                        v_select = " C_DESMAT LIKE '" + txtDesMat.Text + "%' Order BY C_DESMAT DESC";
                        SF_CM0100A.DataSource = cm0100bll.RetornarMaterialComboBox(v_select);
                    }
                }
                if (rbPalavraChave.Checked == true)
                {
                    v_select = " C_CHAPES = '" + cbPalavraChave.Text + "' Order BY C_DESMAT DESC";
                    SF_CM0100A.DataSource = cm0100bll.RetornarMaterialComboBox(v_select);
                    if (cbPalavraChave.Text.Count(c => Char.IsLetterOrDigit(c)) < 2)
                    {
                        MessageBox.Show("Favor selecionar uma palavra chave para continuar!!!!");
                        return;
                    }

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion BUTTONS

        #region RADIO BUTTON EVENTS

        private void rbCodigo_Click(object sender, EventArgs e)
        {
            try
            {
                rbCodigo.Checked = true;
                rbDescricao.Checked = false;
                rbPalavraChave.Checked = false;

                txtDesMat.Text = "";
                txtDesMat.ReadOnly = true;
                txtCodmat.ReadOnly = false;
                RetornarPalavraChave();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void rbDescricao_Click(object sender, EventArgs e)
        {
            try
            {
                rbCodigo.Checked = false;
                rbDescricao.Checked = true;
                rbPalavraChave.Checked = false;

                txtCodmat.Text = "";
                txtCodmat.ReadOnly = true;
                txtDesMat.ReadOnly = false;
                RetornarPalavraChave();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void rbPalavraChave_Click(object sender, EventArgs e)
        {
            try
            {
                rbCodigo.Checked = false;
                rbDescricao.Checked = false;
                rbPalavraChave.Checked = true;

                txtCodmat.Text = "";
                txtCodmat.ReadOnly = true;
                txtDesMat.Text = "";
                txtDesMat.ReadOnly = true;
                RetornarPalavraChave();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        #endregion RADIO BUTTON EVENTS

    }
}
