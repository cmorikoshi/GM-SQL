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
using Microsoft.Reporting.WinForms;

namespace CMSQL_DLL.RELATORIOS
{
    public partial class RPV_LISTA_COMPONENTES_PRODUTO : Form
    {
        CM0700BLL cm0700bll = new CM0700BLL();

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


        #endregion VARIÁVEIS
        public RPV_LISTA_COMPONENTES_PRODUTO()
        {
            InitializeComponent();
        }

        private void RPV_LISTA_COMPONENTES_PRODUTO_Load(object sender, EventArgs e)
        {
            try
            {
                rdlcListaMateriaisOS.ProcessingMode = ProcessingMode.Local;

                LocalReport report = rdlcListaMateriaisOS.LocalReport;
                report.ReportPath = @"C:\RELATORIOS\rdlcListaMateriaisOS.rdlc";

                ReportDataSource rdsLista = new ReportDataSource();
                rdsLista.Name = "dtListaOSCM0700";
                rdsLista.Value = RetornarListaProdutos(); 


            }
            catch (Exception error)
            {

                throw new Exception(error.Message);
            }
            this.rdlcListaMateriaisOS.Clear();
            this.rdlcListaMateriaisOS.RefreshReport();
        }

        public DataTable RetornarListaProdutos()
        {
            DataTable dTable = new DataTable();
            dTable = cm0700bll.RetornarListaComponentePorProduto(v_codequ);

            return dTable;
        }
    }
}
