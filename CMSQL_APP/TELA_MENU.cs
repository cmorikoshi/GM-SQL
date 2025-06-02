using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSQL_APP
{
    public partial class TELA_MENU : Form
    {
        string v_usuario = null;
        public TELA_MENU()
        {
            InitializeComponent();
        }

        private void TELA_MENU_Load(object sender, EventArgs e)
        {
            RetornarUsuario();
        }

        #region METHODS

        public void RetornarUsuario()
        {
            v_usuario = System.IO.File.ReadAllText(@"C:\sgasql\mdsql\d_usuario.txt");
            v_usuario = v_usuario.Substring(4, Convert.ToInt32((v_usuario.Length) - 4));
        }

        #endregion METHODS


        #region BUTTONS
        private void btnCadastroMateriais_Click(object sender, EventArgs e)
        {
            CMSQL_DLL.FORMULARIOS.TELA_CADASTRO_MATERIAIS cadastroMateriais = new CMSQL_DLL.FORMULARIOS.TELA_CADASTRO_MATERIAIS();
            cadastroMateriais.v_usuario = v_usuario;
            cadastroMateriais.ShowDialog();
        }
        private void btnCadastroPalavrasChaves_Click(object sender, EventArgs e)
        {
            CMSQL_DLL.FORMULARIOS.TELA_CADASTRO_PALAVRAS_CHAVE cadastroPalavrasChave = new CMSQL_DLL.FORMULARIOS.TELA_CADASTRO_PALAVRAS_CHAVE();
            cadastroPalavrasChave.ShowDialog();
        }

        private void btnCadastroProdutos_Click(object sender, EventArgs e)
        {
            CMSQL_DLL.FORMULARIOS.TELA_CADASTROS_PRODUTOS cadastroProdutos = new CMSQL_DLL.FORMULARIOS.TELA_CADASTROS_PRODUTOS();
            cadastroProdutos.v_usuario = v_usuario;
            cadastroProdutos.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion BUTTONS

    }
}
