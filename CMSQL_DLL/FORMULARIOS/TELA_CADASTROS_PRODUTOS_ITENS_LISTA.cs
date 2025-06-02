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
    public partial class TELA_CADASTROS_PRODUTOS_ITENS_LISTA : Form
    {
        CM0700BLL cm0700bll = new CM0700BLL();
        CM0700MODEL cm0700model = new CM0700MODEL(); 
        
        TD0100BLL td0100bll = new TD0100BLL();

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

        private string V_DESMAT;
        public string v_desmat
        {
            get { return V_DESMAT; }
            set { V_DESMAT = value; }
        }

        private string V_CODEQU;
        public string v_codequ
        {
            get { return V_CODEQU; }
            set { V_CODEQU = value; }
        }

        private string V_DESEQU;
        public string v_desequ
        {
            get { return V_DESEQU; }
            set { V_DESEQU = value; }
        }

        private string V_SEQEQU;
        public string v_seqequ
        {
            get { return V_SEQEQU; }
            set { V_SEQEQU = value; }
        }

        private string V_UNIMED;
        public string v_unimed
        {
            get { return V_UNIMED; }
            set { V_UNIMED = value; }
        }


        private string V_USUARIO;
        public string v_usuario
        {
            get { return V_USUARIO; }
            set { V_USUARIO = value; }
        }


        #endregion VARIÁVEIS

        public TELA_CADASTROS_PRODUTOS_ITENS_LISTA()
        {
            InitializeComponent();
        }

        private void TELA_CADASTROS_PRODUTOS_ITENS_LISTA_Load(object sender, EventArgs e)
        {
           if(operacao == Util.Operacao.Inclusao)
            {
                c_codequ.Text = v_codequ;
                c_desequ.Text = v_desequ;
                c_codmat.Text = v_codmat;
                c_desmat.Text = v_desmat;
                c_unimed.Text = v_unimed;
                c_seqequ.Text = cm0700bll.RetornarUltSequenciaListaMaterialCM0700(c_codequ.Text);

            }
           if(operacao == Util.Operacao.Alteracao)
            {
                c_codequ.Text = v_codequ;
                c_seqequ.Text = v_seqequ;
                c_desequ.Text = v_desequ;
                c_desmat.Text = v_desmat;
                RetornarDadosMaterialCM0700();

            }


        }

        #region METHODS
        public void InserirListaMaterialCM0700()
        {
            cm0700model.C_CODEQU = c_codequ.Text;
            cm0700model.C_CODMAT = c_codmat.Text;
            cm0700model.C_QTDMAT = Convert.ToDecimal(c_qtdmat.Text);
            cm0700model.C_UNIMED = c_unimed.Text;
            cm0700model.C_NUMDES = c_numdes.Text;
            cm0700model.C_ITEDES = c_itedes.Text;
            cm0700model.C_SEQEQU = c_seqequ.Text;

            cm0700bll.InserirListaCadastroMateriaisCM0700(cm0700model);
        }
        public void AlterarListaMaterialCM0700()
        {
            cm0700model.C_CODMAT = c_codmat.Text;
            cm0700model.C_QTDMAT = Convert.ToDecimal(c_qtdmat.Text);
            cm0700model.C_UNIMED = c_unimed.Text;
            cm0700model.C_NUMDES = c_numdes.Text;
            cm0700model.C_ITEDES = c_itedes.Text;

            cm0700model.C_CODEQU = c_codequ.Text;
            cm0700model.C_SEQEQU = c_seqequ.Text;

            cm0700bll.AlterarListaMaterialCM0700(cm0700model);
        }
        public void RetornarDadosMaterialCM0700()
        {
            try
            {
                cm0700bll.RetornarListaMateriaisAlteracao(cm0700model, c_codequ.Text, c_seqequ.Text);
                c_numdes.Text = cm0700model.C_NUMDES.TrimEnd();
                c_unimed.Text = cm0700model.C_UNIMED;
                c_codmat.Text = cm0700model.C_CODMAT;
                c_qtdmat.Text = cm0700model.C_QTDMAT.ToString();
                c_itedes.Text = cm0700model.C_ITEDES.TrimEnd();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        #endregion METHODS



        #region BUTTONS - EVENTS
        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (c_qtdmat.Text == String.Empty)
                {
                    MessageBox.Show("O campo Quantidade é obrigatório o preenchimento!!");
                    return;
                }
                if(operacao == Util.Operacao.Inclusao)
                {
                    InserirListaMaterialCM0700();
                }
                if (operacao == Util.Operacao.Alteracao)
                {
                    AlterarListaMaterialCM0700();
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
            operacao = Util.Operacao.Cancelado;
            this.Close();
        }

        private void btnPesquisaMaterial_Click(object sender, EventArgs e)
        {

        }

        #endregion BUTTONS - EVENTS


    }
}
