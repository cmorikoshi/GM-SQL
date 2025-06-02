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
    public partial class TELA_PESQUISA_TIPO_EQUIPAMENTO : Form
    {
        CM0100BLL cm0100bll = new CM0100BLL();  

        #region VARIÁVEIS


        private string V_CODCOM;
        public string v_codcom
        {
            get { return V_CODCOM; }
            set { V_CODCOM = value; }
        }

        private string V_DESCOM;
        public string v_descom
        {
            get { return V_DESCOM; }
            set { V_DESCOM = value; }
        }


        #endregion VARIÁVEIS
        public TELA_PESQUISA_TIPO_EQUIPAMENTO()
        {
            InitializeComponent();
        }

        private void TELA_PESQUISA_TIPO_EQUIPAMENTO_Load(object sender, EventArgs e)
        {
            rbCodigo.Checked = true;

        }


        #region METHODS

        public void RetornarComponentes()
        {
            string v_select = null;
            try
            {
                if(rbCodigo.Checked == true)
                {
                    v_select = " C_CODMAT LIKE '%" + c_codmat1.Text + "%' ORDER BY C_DESMAT";
                    SF_TD0100B.DataSource = cm0100bll.RetornarMaterialPesquisa(v_select);
                }
                if (rbDescricao.Checked == true)
                {
                    v_select = " C_DESMAT LIKE '%" + c_desmat1.Text + "%' ORDER BY C_DESMAT";
                    SF_TD0100B.DataSource = cm0100bll.RetornarMaterialPesquisa(v_select);
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }


        #endregion METHODS

        #region BUTTONS
        private void c_codmat1_TextChanged(object sender, EventArgs e)
        {
            if (c_codmat1.Text.Count(c => Char.IsLetterOrDigit(c)) > 3)
            {
                RetornarComponentes();
            }
        }

        private void c_desmat1_TextChanged(object sender, EventArgs e)
        {
            if (c_desmat1.Text.Count(c => Char.IsLetterOrDigit(c)) > 3)
            {
                RetornarComponentes();
            }
        }


        private void btnGravar_Click(object sender, EventArgs e)
        {
            if(SF_TD0100B.SelectedRows.Count > 0)
            {
                v_codcom = SF_TD0100B.CurrentRow.Cells["C_CODMAT"].Value.ToString();
                v_descom = SF_TD0100B.CurrentRow.Cells["C_DESMAT"].Value.ToString();
            }
            this.Close();

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
            rbDescricao.Checked = false;
            c_codmat1.Enabled = true;
            c_desmat1.Text = "";
            c_desmat1.Enabled = false;
        }

        private void rbDescricao_Click(object sender, EventArgs e)
        {
            rbCodigo.Checked = false;
            rbDescricao.Checked = true;
            c_codmat1.Enabled = false;
            c_codmat1.Text = "";
            c_desmat1.Enabled = true;
        }

        #endregion RADIO BUTTON EVENTS

    }
}
