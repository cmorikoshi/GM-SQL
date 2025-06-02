using GM_BLL;
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
    public partial class TELA_CADASTROS_PRODUTOS : Form
    {
        CM0600BLL cm0600bll = new CM0600BLL();

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

        public TELA_CADASTROS_PRODUTOS()
        {
            InitializeComponent();
        }

        private void TELA_CADASTROS_PRODUTOS_Load(object sender, EventArgs e)
        {
            rbCodigo.Checked = true;
            c_codequ.Focus();
        }

        #region BUTTONS

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            string v_select = null;
            try
            {
                if (rbCodigo.Checked == true)
                {
                    if (c_codequ.Text.Count(c => Char.IsLetterOrDigit(c)) < 3)
                    {
                        MessageBox.Show("Favor inserir Código do Produto!!!");
                        return;
                    }
                    else
                    {
                        v_select = " C_CODEQU LIKE '%" + c_codequ.Text + "%' Order BY C_DESEQU DESC";
                        SF_CM0600A.DataSource = cm0600bll.RetornarProdutoCM0600(v_select);
                    }
                }
                if (rbDescricao.Checked == true)
                {
                    if (c_desequ.Text.Count(c => Char.IsLetterOrDigit(c)) < 3)
                    {
                        MessageBox.Show("Favor inserir Descrição do Produto!!!!");
                        return;
                    }
                    else
                    {
                        v_select = " C_DESEQU LIKE '%" + c_desequ.Text + "%' Order BY C_DESEQU DESC";
                        SF_CM0600A.DataSource = cm0600bll.RetornarProdutoCM0600(v_select);
                    }
                }
                if (rbComponente.Checked == true)
                {
                    if (c_codcom.Text.Count(c => Char.IsLetterOrDigit(c)) < 1)
                    {
                        MessageBox.Show("Favor selecionar componenete do Produto!!!!");
                        return;
                    }
                    else
                    {
                        v_select = " C_CODEQU  IN (SELECT C_CODEQU FROM CM0700 WHERE C_CODMAT = '1005561') Order BY C_DESEQU DESC";
                        SF_CM0600A.DataSource = cm0600bll.RetornarProdutoCM0600(v_select);
                    }
                }
                if (rbDesenho.Checked == true)
                {
                    if (c_numdes.Text.Count(c => Char.IsLetterOrDigit(c)) < 3)
                    {
                        MessageBox.Show("Favor inserir Número do Desenho do Produto!!!!!!!!");
                        return;
                    }
                    else
                    {
                        v_select = " C_DESEQU LIKE '%" + c_desequ.Text + "%' Order BY C_DESEQU DESC";
                        SF_CM0600A.DataSource = cm0600bll.RetornarProdutoCM0600(v_select);
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void btnPesquisaComponente_Click(object sender, EventArgs e)
        {
            TELA_PESQUISA_TIPO_EQUIPAMENTO pesqComponentes = new TELA_PESQUISA_TIPO_EQUIPAMENTO();
            pesqComponentes.ShowDialog();

            if(pesqComponentes.v_codcom != null)
            {
                c_codcom.Text = pesqComponentes.v_codcom;
                c_descom.Text = pesqComponentes.v_descom;
            }
            if (pesqComponentes.v_codcom == null)
            {
                c_codcom.Text = "";
                c_descom.Text = "";
            }

        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            TELA_CADASTROS_PRODUTOS_DETALHE cadastroProdutoDetalhe = new TELA_CADASTROS_PRODUTOS_DETALHE();
            cadastroProdutoDetalhe.v_codequ = SF_CM0600A.CurrentRow.Cells["C_CODEQU1"].Value.ToString();
            cadastroProdutoDetalhe.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion BUTTONS

        #region RADIO BUTTON EVENTS
        private void rbCodigo_Click(object sender, EventArgs e)
        {
            rbCodigo.Checked = true;
            rbDescricao.Checked = false;
            rbComponente.Checked = false;
            rbDesenho.Checked = false;

            c_codequ.Enabled = true;
            c_desequ.Text = "";
            c_desequ.Enabled = false;
            c_codcom.Text = "";
            c_descom.Text = "";
            c_numdes.Text = "";
            c_numdes.Enabled = false;

            btnPesquisaComponente.Enabled = false;
        }

        private void rbDescricao_Click(object sender, EventArgs e)
        {
            rbCodigo.Checked = false;
            rbDescricao.Checked = true;
            rbComponente.Checked = false;
            rbDesenho.Checked = false;

            c_desequ.Enabled=true;
            c_codequ.Enabled=false;
            c_codequ.Text = "";
            c_codcom.Text = "";
            c_descom.Text = "";
            c_numdes.Enabled=false;
            c_numdes.Text = "";

            btnPesquisaComponente.Enabled = false;
        }

        private void rbComponente_Click(object sender, EventArgs e)
        {
            rbCodigo.Checked = false;
            rbDescricao.Checked = false;
            rbComponente.Checked = true;
            rbDesenho.Checked = false;

            c_codequ.Enabled = false;
            c_codequ.Text = "";
            c_desequ.Enabled = false;
            c_desequ.Text = "";
            c_numdes.Enabled=false;
            c_numdes.Text = "";

            btnPesquisaComponente.Enabled = true;
        }

        private void rbDesenho_Click(object sender, EventArgs e)
        {
            rbCodigo.Checked = false;
            rbDescricao.Checked = false;
            rbComponente.Checked = false;
            rbDesenho.Checked = true;

            c_codequ.Enabled = false;
            c_codequ.Text = "";
            c_desequ.Enabled=false;
            c_desequ.Text = "";
            c_codcom.Text = "";
            c_descom.Text = "";
            c_numdes.Enabled = true;

            btnPesquisaComponente.Enabled = false;
        }


        #endregion RADIO BUTTON EVENTS

    }
}
