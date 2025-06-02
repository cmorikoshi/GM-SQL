namespace CMSQL_DLL.FORMULARIOS
{
    partial class TELA_CADASTROS_PRODUTOS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnPesquisaComponente = new System.Windows.Forms.Button();
            this.c_descom = new System.Windows.Forms.TextBox();
            this.c_codcom = new System.Windows.Forms.TextBox();
            this.c_numdes = new System.Windows.Forms.TextBox();
            this.c_desequ = new System.Windows.Forms.TextBox();
            this.c_codequ = new System.Windows.Forms.TextBox();
            this.rbDesenho = new System.Windows.Forms.RadioButton();
            this.rbComponente = new System.Windows.Forms.RadioButton();
            this.rbDescricao = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.SF_CM0600A = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.C_CODEQU1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_DESEQU1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_NUMDES1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SF_CM0600A)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVisualizar);
            this.groupBox1.Controls.Add(this.btnPesquisaComponente);
            this.groupBox1.Controls.Add(this.c_descom);
            this.groupBox1.Controls.Add(this.c_codcom);
            this.groupBox1.Controls.Add(this.c_numdes);
            this.groupBox1.Controls.Add(this.c_desequ);
            this.groupBox1.Controls.Add(this.c_codequ);
            this.groupBox1.Controls.Add(this.rbDesenho);
            this.groupBox1.Controls.Add(this.rbComponente);
            this.groupBox1.Controls.Add(this.rbDescricao);
            this.groupBox1.Controls.Add(this.rbCodigo);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa:";
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVisualizar.FlatAppearance.BorderSize = 0;
            this.btnVisualizar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnVisualizar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizar.Image = global::CMSQL_DLL.Properties.Resources.Consultar48x48;
            this.btnVisualizar.Location = new System.Drawing.Point(588, 19);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(115, 108);
            this.btnVisualizar.TabIndex = 44;
            this.btnVisualizar.Text = "Visualizar Item";
            this.btnVisualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVisualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnPesquisaComponente
            // 
            this.btnPesquisaComponente.AutoSize = true;
            this.btnPesquisaComponente.FlatAppearance.BorderSize = 0;
            this.btnPesquisaComponente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisaComponente.Image = global::CMSQL_DLL.Properties.Resources.pesquisar_2020;
            this.btnPesquisaComponente.Location = new System.Drawing.Point(195, 78);
            this.btnPesquisaComponente.Name = "btnPesquisaComponente";
            this.btnPesquisaComponente.Size = new System.Drawing.Size(31, 31);
            this.btnPesquisaComponente.TabIndex = 9;
            this.btnPesquisaComponente.UseVisualStyleBackColor = true;
            this.btnPesquisaComponente.Click += new System.EventHandler(this.btnPesquisaComponente_Click);
            // 
            // c_descom
            // 
            this.c_descom.Location = new System.Drawing.Point(232, 84);
            this.c_descom.Name = "c_descom";
            this.c_descom.ReadOnly = true;
            this.c_descom.Size = new System.Drawing.Size(360, 20);
            this.c_descom.TabIndex = 8;
            // 
            // c_codcom
            // 
            this.c_codcom.Location = new System.Drawing.Point(128, 84);
            this.c_codcom.Name = "c_codcom";
            this.c_codcom.ReadOnly = true;
            this.c_codcom.Size = new System.Drawing.Size(58, 20);
            this.c_codcom.TabIndex = 7;
            // 
            // c_numdes
            // 
            this.c_numdes.Location = new System.Drawing.Point(126, 120);
            this.c_numdes.Name = "c_numdes";
            this.c_numdes.Size = new System.Drawing.Size(114, 20);
            this.c_numdes.TabIndex = 6;
            // 
            // c_desequ
            // 
            this.c_desequ.Location = new System.Drawing.Point(128, 50);
            this.c_desequ.Name = "c_desequ";
            this.c_desequ.Size = new System.Drawing.Size(464, 20);
            this.c_desequ.TabIndex = 5;
            // 
            // c_codequ
            // 
            this.c_codequ.Location = new System.Drawing.Point(128, 18);
            this.c_codequ.Name = "c_codequ";
            this.c_codequ.Size = new System.Drawing.Size(93, 20);
            this.c_codequ.TabIndex = 4;
            this.c_codequ.TabStop = false;
            // 
            // rbDesenho
            // 
            this.rbDesenho.AutoSize = true;
            this.rbDesenho.Location = new System.Drawing.Point(15, 121);
            this.rbDesenho.Name = "rbDesenho";
            this.rbDesenho.Size = new System.Drawing.Size(90, 17);
            this.rbDesenho.TabIndex = 3;
            this.rbDesenho.Text = "Por Desenho:";
            this.rbDesenho.UseVisualStyleBackColor = true;
            this.rbDesenho.Click += new System.EventHandler(this.rbDesenho_Click);
            // 
            // rbComponente
            // 
            this.rbComponente.AutoSize = true;
            this.rbComponente.Location = new System.Drawing.Point(15, 87);
            this.rbComponente.Name = "rbComponente";
            this.rbComponente.Size = new System.Drawing.Size(107, 17);
            this.rbComponente.TabIndex = 2;
            this.rbComponente.Text = "Por Componente:";
            this.rbComponente.UseVisualStyleBackColor = true;
            this.rbComponente.Click += new System.EventHandler(this.rbComponente_Click);
            // 
            // rbDescricao
            // 
            this.rbDescricao.AutoSize = true;
            this.rbDescricao.Location = new System.Drawing.Point(15, 53);
            this.rbDescricao.Name = "rbDescricao";
            this.rbDescricao.Size = new System.Drawing.Size(95, 17);
            this.rbDescricao.TabIndex = 1;
            this.rbDescricao.Text = "Por Descrição:";
            this.rbDescricao.UseVisualStyleBackColor = true;
            this.rbDescricao.Click += new System.EventHandler(this.rbDescricao_Click);
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Location = new System.Drawing.Point(15, 19);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(80, 17);
            this.rbCodigo.TabIndex = 0;
            this.rbCodigo.Text = "Por Código:";
            this.rbCodigo.UseVisualStyleBackColor = true;
            this.rbCodigo.Click += new System.EventHandler(this.rbCodigo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.btnIncluir);
            this.groupBox2.Location = new System.Drawing.Point(12, 443);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 89);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = global::CMSQL_DLL.Properties.Resources.excluir;
            this.btnExcluir.Location = new System.Drawing.Point(117, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 79);
            this.btnExcluir.TabIndex = 47;
            this.btnExcluir.Text = "Excluir Produto";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.FlatAppearance.BorderSize = 0;
            this.btnIncluir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluir.Image = global::CMSQL_DLL.Properties.Resources._new;
            this.btnIncluir.Location = new System.Drawing.Point(6, 4);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(86, 85);
            this.btnIncluir.TabIndex = 45;
            this.btnIncluir.Text = "Incluir/Alterar Componentes";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIncluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // SF_CM0600A
            // 
            this.SF_CM0600A.AllowUserToAddRows = false;
            this.SF_CM0600A.AllowUserToDeleteRows = false;
            this.SF_CM0600A.AllowUserToResizeColumns = false;
            this.SF_CM0600A.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SF_CM0600A.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SF_CM0600A.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SF_CM0600A.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_CODEQU1,
            this.C_DESEQU1,
            this.C_NUMDES1});
            this.SF_CM0600A.Location = new System.Drawing.Point(18, 165);
            this.SF_CM0600A.MultiSelect = false;
            this.SF_CM0600A.Name = "SF_CM0600A";
            this.SF_CM0600A.ReadOnly = true;
            this.SF_CM0600A.RowHeadersVisible = false;
            this.SF_CM0600A.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SF_CM0600A.Size = new System.Drawing.Size(725, 276);
            this.SF_CM0600A.TabIndex = 6;
            this.SF_CM0600A.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Image = global::CMSQL_DLL.Properties.Resources.SairSetaDireita48x48;
            this.btnSair.Location = new System.Drawing.Point(667, 453);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(76, 73);
            this.btnSair.TabIndex = 5;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // C_CODEQU1
            // 
            this.C_CODEQU1.DataPropertyName = "C_CODEQU";
            this.C_CODEQU1.HeaderText = "Código";
            this.C_CODEQU1.Name = "C_CODEQU1";
            this.C_CODEQU1.ReadOnly = true;
            this.C_CODEQU1.Width = 60;
            // 
            // C_DESEQU1
            // 
            this.C_DESEQU1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.C_DESEQU1.DataPropertyName = "C_DESEQU";
            this.C_DESEQU1.HeaderText = "Descrição do Produto";
            this.C_DESEQU1.Name = "C_DESEQU1";
            this.C_DESEQU1.ReadOnly = true;
            // 
            // C_NUMDES1
            // 
            this.C_NUMDES1.DataPropertyName = "C_NUMDES";
            this.C_NUMDES1.HeaderText = "Desenho";
            this.C_NUMDES1.Name = "C_NUMDES1";
            this.C_NUMDES1.ReadOnly = true;
            this.C_NUMDES1.Width = 150;
            // 
            // TELA_CADASTROS_PRODUTOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 544);
            this.Controls.Add(this.SF_CM0600A);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TELA_CADASTROS_PRODUTOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.TELA_CADASTROS_PRODUTOS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SF_CM0600A)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.TextBox c_descom;
        private System.Windows.Forms.TextBox c_codcom;
        private System.Windows.Forms.TextBox c_numdes;
        private System.Windows.Forms.TextBox c_desequ;
        private System.Windows.Forms.TextBox c_codequ;
        private System.Windows.Forms.RadioButton rbDesenho;
        private System.Windows.Forms.RadioButton rbComponente;
        private System.Windows.Forms.RadioButton rbDescricao;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPesquisaComponente;
        private System.Windows.Forms.DataGridView SF_CM0600A;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_CODEQU1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_DESEQU1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_NUMDES1;
    }
}