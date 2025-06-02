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
    public partial class TELA_CADASTRO_CHAVE_DETALHE : Form
    {
        CM0500BLL cm0500bll = new CM0500BLL();
        CM0500MODEL cm0500model = new CM0500MODEL();

        #region ENUMS

        Util.Operacao OPERACAO;

        public Util.Operacao operacao
        {
            get { return OPERACAO; }
            set { OPERACAO = value; }
        }

        #endregion ENUMS

        #region VARIÁVEIS

        private string V_NOMUSU;
        public string v_nomusu
        {
            get { return V_NOMUSU; }
            set { V_NOMUSU = value; }
        }


        private string V_CHAPES;
        public string v_chapes
        {
            get { return V_CHAPES; }
            set { V_CHAPES = value; }
        }

        private string V_CONEST;
        public string v_conest
        {
            get { return V_CONEST; }
            set { V_CONEST = value; }
        }

        private string V_CHAPES_OLD;
        public string v_chapesOld
        {
            get { return V_CHAPES_OLD; }
            set { V_CHAPES_OLD = value; }
        }

        bool v_VerificaExistePalavraChave = false;


        #endregion VARIÁVEIS
        public TELA_CADASTRO_CHAVE_DETALHE()
        {
            InitializeComponent();
        }

        private void TELA_CADASTRO_CHAVE_DETALHE_Load(object sender, EventArgs e)
        {
            if (operacao == Util.Operacao.Alteracao)
            {
                v_chapesOld = v_chapes;
                c_chapes.Text = v_chapes.TrimEnd();
                if(v_conest == "S")
                    cb_conest.SelectedItem = "SIM";
                if (v_conest == "N")
                    cb_conest.SelectedItem = "NÃO";
            }
        }
        #region METHODS
        public void GravarPalavraChave()
        {
            cm0500model.C_KEYDYN = "";
            cm0500model.C_CHAPES = c_chapes.Text.TrimEnd();
            cm0500model.C_CONEST = cb_conest.Text == "SIM" ? "S" : "N";

            if (operacao == Util.Operacao.Alteracao)
                cm0500bll.AlterarPalavraChave(cm0500model, v_chapesOld);
            if (operacao == Util.Operacao.Inclusao)
               cm0500bll.InserirPalavraChave(cm0500model);
        }

        #endregion METHODS

        #region BUTTONS

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                v_VerificaExistePalavraChave = cm0500bll.VerificaExistePalavraChave(c_chapes.Text);
                if(v_VerificaExistePalavraChave == false)
                {
                    GravarPalavraChave();
                    this.Close();
                }
                if(v_VerificaExistePalavraChave == true)
                {
                    MessageBox.Show("Esta palavra chave já está cadastrada!!!");
                    return;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        private void btnCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion BUTTONS

    }
}
