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
    public partial class TELA_CADASTRO_PALAVRAS_CHAVE : Form
    {
        CM0500BLL cm0500bll = new CM0500BLL();
        CM0500MODEL cm0500model = new CM0500MODEL();

        bool v_VerificaPalavraChaveEmUso = false;

        public TELA_CADASTRO_PALAVRAS_CHAVE()
        {
            InitializeComponent();
        }

        #region METHODS

        public void RetornarPalavrasChave()
        {
            if (c_chapes.Text.Count(c => Char.IsLetterOrDigit(c)) > 2)
            {
                SF0500A.DataSource = cm0500bll.RetornarPalavrasChaveConsulta(c_chapes.Text);
            }
            if (c_chapes.Text.Count(c => Char.IsLetterOrDigit(c)) == 0)
            {
                SF0500A.DataSource = cm0500bll.RetornarPalavrasChaveConsulta(c_chapes.Text);
            }
        }

        public void ExcluirPalavrasChave()
        {
            cm0500model.C_CHAPES = SF0500A.CurrentRow.Cells["C_CHAPES1"].Value.ToString();

            cm0500bll.ExcluirPalavraChave(cm0500model);
        }

        #endregion METHODS

        #region BUTTONS

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            TELA_CADASTRO_CHAVE_DETALHE cadastroPalavraChaveDetalhe = new TELA_CADASTRO_CHAVE_DETALHE();
            cadastroPalavraChaveDetalhe.operacao = Util.Operacao.Inclusao;
            cadastroPalavraChaveDetalhe.ShowDialog();

            RetornarPalavrasChave();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (SF0500A.SelectedRows.Count == 0)
            {
                MessageBox.Show("Favor selecionar um item para alterar!!!");
                return;
            }

            int linhaSelecionada = SF0500A.CurrentRow.Index;

            TELA_CADASTRO_CHAVE_DETALHE cadastroPalavraChaveDetalhe = new TELA_CADASTRO_CHAVE_DETALHE();
            cadastroPalavraChaveDetalhe.operacao = Util.Operacao.Alteracao;
            cadastroPalavraChaveDetalhe.v_chapes = SF0500A.CurrentRow.Cells["C_CHAPES1"].Value.ToString();
            cadastroPalavraChaveDetalhe.v_conest = SF0500A.CurrentRow.Cells["C_CONEST"].Value.ToString();
            cadastroPalavraChaveDetalhe.ShowDialog();

            RetornarPalavrasChave();

            if (SF0500A.RowCount > 0)
            {
                if (SF0500A.RowCount >= linhaSelecionada)
                {
                    SF0500A.CurrentCell = SF0500A.Rows[linhaSelecionada].Cells[0];
                }
                else
                {
                    SF0500A.CurrentCell = SF0500A.Rows[linhaSelecionada - 1].Cells[0];
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (SF0500A.SelectedRows.Count == 0)
            {
                MessageBox.Show("Favor selecionar um item para excluir!!!");
                return;
            }
            if (MessageBox.Show("Confirma a exclusão deste item??", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            v_VerificaPalavraChaveEmUso = cm0500bll.VerificaPalavraChaveEmUso(SF0500A.CurrentRow.Cells["C_CHAPES1"].Value.ToString());
            if(v_VerificaPalavraChaveEmUso == true)
            {
                MessageBox.Show("Esta palavra chave está em uso, não é possível excluir");
                return;
            }
            ExcluirPalavrasChave();
            RetornarPalavrasChave();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion BUTTONS

        private void c_chapes_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RetornarPalavrasChave();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
