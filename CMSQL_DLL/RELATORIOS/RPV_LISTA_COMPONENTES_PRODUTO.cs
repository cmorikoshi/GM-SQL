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

        private string V_DESEQU;
        public string v_desequ
        {
            get { return V_DESEQU; }
            set { V_DESEQU = value; }
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
        public RPV_LISTA_COMPONENTES_PRODUTO()
        {
            InitializeComponent();

        }

        private void RPV_LISTA_COMPONENTES_PRODUTO_Load(object sender, EventArgs e)
        {
            v_codemp = "01";
            try
            {
                rdlcListaMateriaisOS.ProcessingMode = ProcessingMode.Local;

                LocalReport report = rdlcListaMateriaisOS.LocalReport;
                report.ReportPath = @"C:\D_FILES\SGA_NEW\GMSQL\CMSQL_DLL\RELATORIOS\ListaComponentesProduto.rdlc";
                //report.ReportPath = @".\RELATORIOS\ListaComponentesProduto.rdlc";

                ReportDataSource rdsLista = new ReportDataSource();
                rdsLista.Name = "dtListaOSCM0700";
                rdsLista.Value = RetornarListaProdutos();

                if (v_codemp == "01")
                {
                    report.EnableExternalImages = true;
                    //ReportParameter rp_logo = new ReportParameter("param_logo", @"\\192.168.0.2\sgasql$\mdsql\LogoPB01.bmp");
                    ReportParameter rp_logo = new ReportParameter("param_logo", @"C:\sgasql\mdsql\Logo01.bmp");
                    report.SetParameters(new ReportParameter[] { rp_logo });
                }

                if (v_codemp == "02")
                {
                    report.EnableExternalImages = true;
                    ReportParameter rp_logo = new ReportParameter("param_logo", @"C:\sgasql\mdsql\Logo02.bmp");
                    //ReportParameter rp_logo = new ReportParameter("param_logo", @"\\192.168.0.2\sgasql$\mdsql\LogoPB02.bmp");

                    report.SetParameters(new ReportParameter[] { rp_logo });
                }
                if (v_rbcheck == "rbTodosComponentes")
                {
                    ReportParameter rp_rbcheck = new ReportParameter("param_rbcheck", "(Lista Todos os Componentes)");
                    report.SetParameters(new ReportParameter[] { rp_rbcheck });
                }
                if (v_rbcheck == "rb_ComEstoqutDisponivel")
                {
                    ReportParameter rp_rbcheck = new ReportParameter("param_rbcheck", "(Lista com Estoque Disponível)");
                    report.SetParameters(new ReportParameter[] { rp_rbcheck });
                }
                if (v_rbcheck == "rb_SemEstoqueDisponivel")
                {
                    ReportParameter rp_rbcheck = new ReportParameter("param_rbcheck", "(Lista sem Estoque Disponível)");
                    report.SetParameters(new ReportParameter[] { rp_rbcheck });
                }

                ReportParameter rp_desequ = new ReportParameter("param_desequ", v_desequ);
                ReportParameter rp_numdes = new ReportParameter("param_numdes", v_numdes);
                report.SetParameters(new ReportParameter[] { rp_desequ, rp_numdes });

                report.DataSources.Add(rdsLista);
                this.rdlcListaMateriaisOS.Clear();
                this.rdlcListaMateriaisOS.RefreshReport();


            }
            catch (Exception error)
            {

                throw new Exception(error.Message);
            }

        }

        public DataTable RetornarListaProdutos()
        {
            string v_select = null;
            DataTable dTable = new DataTable();
            if (v_rbcheck == "rbTodosComponentes")
            {
                v_select = "";
            }
            if (v_rbcheck == "rb_ComEstoqutDisponivel")
            {
                v_select = " AND B.C_DISQTD > 0 ";
            }
            if (v_rbcheck == "rb_SemEstoqueDisponivel")
            {
                v_select = " AND B.C_DISQTD = 0 ";
            }

            dTable = cm0700bll.RetornarListaComponentePorProduto(v_codequ, v_select);
            return dTable;
        }
    }
}
