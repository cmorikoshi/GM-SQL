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
    public partial class TELA_FORMA_IMPRESSAO : Form
    {
        #region VARIÁVEIS

        private string V_NOMSIS;
        public string v_nomsis
        {
            get { return V_NOMSIS; }
            set { V_NOMSIS = value; }
        }

        private string V_EMPRESA;
        public string v_empresa
        {
            get { return V_EMPRESA; }
            set { V_EMPRESA = value; }
        }

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

        private string V_DESCOS;
        public string v_descos
        {
            get { return V_DESCOS; }
            set { V_DESCOS = value; }
        }

        private string V_NUMDES;
        public string v_numdes
        {
            get { return V_NUMDES; }
            set { V_NUMDES = value; }
        }

        private string V_RBCHECK;
        public string v_rbcheck
        {
            get { return V_RBCHECK; }
            set { V_RBCHECK = value; }
        }


        #endregion VARIÁVEIS
        public TELA_FORMA_IMPRESSAO()
        {
            InitializeComponent();
        }

        private void TELA_FORMA_IMPRESSAO_Load(object sender, EventArgs e)
        {
            c_codequ.Text = v_codequ;
            c_descos.Text = v_descos;
            c_numdes.Text = v_numdes;
            rbTodosComponentes.Checked = true;
        }

        #region RADIO BUTTON EVENTS
        private void rbTodosComponentes_Click(object sender, EventArgs e)
        {
            rbTodosComponentes.Checked = true;
            rb_ComEstoqutDisponivel.Checked = false;
            rb_SemEstoqueDisponivel.Checked = false;
            v_rbcheck = "rbTodosComponentes";
        }

        private void rb_ComEstoqutDisponivel_Click(object sender, EventArgs e)
        {
            rbTodosComponentes.Checked = false;
            rb_ComEstoqutDisponivel.Checked = true;
            rb_SemEstoqueDisponivel.Checked = false;
            v_rbcheck = "rb_ComEstoqutDisponivel";
        }

        private void rb_SemEstoqueDisponivel_Click(object sender, EventArgs e)
        {
            rbTodosComponentes.Checked = false;
            rb_ComEstoqutDisponivel.Checked = false;
            rb_SemEstoqueDisponivel.Checked = true;
            v_rbcheck = "rb_SemEstoqueDisponivel";
        }

        #endregion RADIO BUTTON EVENTS

        #region BUTTONS

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            RELATORIOS.RPV_LISTA_COMPONENTES_PRODUTO  listaComponentesProduto = new RELATORIOS.RPV_LISTA_COMPONENTES_PRODUTO();
            listaComponentesProduto.v_codequ = v_codequ;
            listaComponentesProduto.v_rbcheck = v_rbcheck;
            listaComponentesProduto.v_desequ = c_codequ.Text + " - " + c_descos.Text;
            listaComponentesProduto.v_numdes = c_numdes.Text == String.Empty ? "----" : c_numdes.Text;
            listaComponentesProduto.ShowDialog();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion BUTTONS

    }
}
