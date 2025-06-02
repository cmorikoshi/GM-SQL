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
    public partial class TELA_IMPORTACAO_OS_PRODUTO : Form
    {

        CM0100BLL cm0100bll = new CM0100BLL();
        TD0100BLL td0100bll = new TD0100BLL();

        OS0300BLL os0300bll = new OS0300BLL();
        OS0300MODEL os0300model = new OS0300MODEL();


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

        public TELA_IMPORTACAO_OS_PRODUTO()
        {
            InitializeComponent();
        }

        private void TELA_IMPORTACAO_OS_PRODUTO_Load(object sender, EventArgs e)
        {


        }

        #region RETURN METHODS
        public void RetornarListaMateriaisCM0700()
        {
            string v_select = null;
            try
            {
                if (rbPorCliente.Checked == true)
                {
                    v_select = " C_CODCLI = '" + c_codcli.Text + "' ";
                }
                if (rbPorOS.Checked == true)
                {
                    v_select = " C_NUMOSE = '" + c_numose.Text + "' ";
                }
                if (rbPorJOB.Checked == true)
                {
                    string v_numjob = "" + c_anojob.Text + "" + c_numjob1.Text + "";
                    v_select = " (C_ANOJOB+C_NUMJOB) = '" + v_numjob + "' ";
                }
                SF_OS0300A.DataSource = os0300bll.RetornarOS0300LMC(v_select);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void RetornarDadosInformacoesOS()
        {
            try
            {
                if (c_numose.Text == String.Empty)
                {
                    string v_rescoo = null;
                    os0300bll.RetornarDadosInformacoesOS0300(os0300model, c_numose1.Text);
                    c_numjob.Text = os0300model.C_NUMJOB;
                    c_dtabos.Text = Util.CTOD(os0300model.C_DTABOS);
                    c_qtdeos.Text = os0300model.C_QTDEOS.ToString();
                    c_nomose.Text = os0300model.C_NOMOSE;
                    c_descos.Text = os0300model.C_DESCOS;
                    v_rescoo = os0300model.C_RESCOO;
                    c_nomcoo.Text = td0100bll.RetornarResponsavelLista(v_rescoo);
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public void AtualizarFormulario()
        {
            if (SF_OS0300A.Rows.Count > 0)
            {
                string v_select = " C_NUMOSE = '00000'";
                SF_OS0300A.DataSource = os0300bll.RetornarOS0300LMC(v_select); 
                SF_OS0300A.Refresh();
            }
            c_numjob.Text = "";
            c_numose1.Text = "";
            c_dtabos.Text = "";
            c_descos.Text = "";
            c_nomose.Text = "";
            c_nomcoo.Text = "";
            c_qtdeos.Text = "";
        }

        #endregion RETURN METHODS

        #region BUTTONS

        private void btnCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion BUTTONS

        #region EVENTOS RADIO-BUTTON

        private void rbPorOS_Click(object sender, EventArgs e)
        {
            c_numose.Focus();
            c_numose.ReadOnly = false;
            c_codcli.ReadOnly = true;
            c_codcli.Text = "";
            c_anojob.Text = "";
            c_anojob.ReadOnly = true;
            c_numjob1.Text = "";
            c_numjob1.ReadOnly = true;
            AtualizarFormulario();

        }

        private void rbPorCliente_Click(object sender, EventArgs e)
        {
            c_numose.Text = "";
            c_numose.ReadOnly = true;
            c_codcli.Focus();
            c_codcli.ReadOnly = false;
            c_anojob.Text = "";
            c_anojob.ReadOnly = true;
            c_numjob1.Text = "";
            c_numjob1.ReadOnly = true;
            AtualizarFormulario();
        }

        private void rbPorJOB_Click(object sender, EventArgs e)
        {
            c_numose.Text = "";
            c_numose.ReadOnly = true;
            c_codcli.Text = "";
            c_codcli.ReadOnly = true;
            c_anojob.ReadOnly = false;
            c_numjob1.ReadOnly = false;
            AtualizarFormulario();
        }

        #endregion EVENTOS RADIO-BUTTON


        #region EVENTS
        private void c_numose_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (c_numose.Text.Length == 5)
                {
                    RetornarListaMateriaisCM0700();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        private void c_codcli_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (c_codcli.Text.Length == 6)
                {

                    RetornarListaMateriaisCM0700();

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void c_anojob_TextChanged(object sender, EventArgs e)
        {
            try
            {
                c_anojob.Focus();
                c_anojob.SelectionStart = 0;
                if (c_anojob.Text.Length == 2)
                {
                    c_numjob1.Focus();
                    c_numjob1.SelectionStart = 0;
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void c_numjob1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (c_numjob1.Text.Length == 5)
                {
                    RetornarListaMateriaisCM0700();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void SF_OS0300A_SelectionChanged(object sender, EventArgs e)
        {
            if (SF_OS0300A.Rows.Count > 0)
            {
                c_numose1.Text = SF_OS0300A.CurrentRow.Cells["C_NUMOSE2"].Value.ToString();
                RetornarDadosInformacoesOS();

            }

        }

        #endregion EVENTS


    }
}
