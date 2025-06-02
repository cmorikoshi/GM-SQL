namespace CMSQL_DLL.FORMULARIOS
{
    partial class TELA_CADASTRO_MATERIAIS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPesqMaterial = new System.Windows.Forms.Button();
            this.cbPalavraChave = new System.Windows.Forms.ComboBox();
            this.txtDesMat = new System.Windows.Forms.TextBox();
            this.txtCodmat = new System.Windows.Forms.TextBox();
            this.rbPalavraChave = new System.Windows.Forms.RadioButton();
            this.rbDescricao = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.SF_CM0100A = new System.Windows.Forms.DataGridView();
            this.C_CODMAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SF_CM0100A)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.btnPesqMaterial);
            this.groupBox1.Controls.Add(this.cbPalavraChave);
            this.groupBox1.Controls.Add(this.txtDesMat);
            this.groupBox1.Controls.Add(this.txtCodmat);
            this.groupBox1.Controls.Add(this.rbPalavraChave);
            this.groupBox1.Controls.Add(this.rbDescricao);
            this.groupBox1.Controls.Add(this.rbCodigo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // btnPesqMaterial
            // 
            this.btnPesqMaterial.FlatAppearance.BorderSize = 0;
            this.btnPesqMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqMaterial.Image = global::CMSQL_DLL.Properties.Resources.pesquisar_2020;
            this.btnPesqMaterial.Location = new System.Drawing.Point(418, 18);
            this.btnPesqMaterial.Name = "btnPesqMaterial";
            this.btnPesqMaterial.Size = new System.Drawing.Size(68, 64);
            this.btnPesqMaterial.TabIndex = 6;
            this.btnPesqMaterial.Text = "Pesquisar Material";
            this.btnPesqMaterial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesqMaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesqMaterial.UseVisualStyleBackColor = true;
            this.btnPesqMaterial.Click += new System.EventHandler(this.btnPesqMaterial_Click);
            // 
            // cbPalavraChave
            // 
            this.cbPalavraChave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPalavraChave.FormattingEnabled = true;
            this.cbPalavraChave.Location = new System.Drawing.Point(120, 64);
            this.cbPalavraChave.Name = "cbPalavraChave";
            this.cbPalavraChave.Size = new System.Drawing.Size(292, 21);
            this.cbPalavraChave.TabIndex = 5;
            // 
            // txtDesMat
            // 
            this.txtDesMat.Location = new System.Drawing.Point(120, 41);
            this.txtDesMat.MaxLength = 171;
            this.txtDesMat.Name = "txtDesMat";
            this.txtDesMat.Size = new System.Drawing.Size(292, 20);
            this.txtDesMat.TabIndex = 4;
            // 
            // txtCodmat
            // 
            this.txtCodmat.Location = new System.Drawing.Point(120, 18);
            this.txtCodmat.MaxLength = 7;
            this.txtCodmat.Name = "txtCodmat";
            this.txtCodmat.Size = new System.Drawing.Size(92, 20);
            this.txtCodmat.TabIndex = 3;
            // 
            // rbPalavraChave
            // 
            this.rbPalavraChave.AutoSize = true;
            this.rbPalavraChave.Location = new System.Drawing.Point(6, 65);
            this.rbPalavraChave.Name = "rbPalavraChave";
            this.rbPalavraChave.Size = new System.Drawing.Size(114, 17);
            this.rbPalavraChave.TabIndex = 2;
            this.rbPalavraChave.TabStop = true;
            this.rbPalavraChave.Text = "Por Palavra Chave";
            this.rbPalavraChave.UseVisualStyleBackColor = true;
            this.rbPalavraChave.Click += new System.EventHandler(this.rbPalavraChave_Click);
            // 
            // rbDescricao
            // 
            this.rbDescricao.AutoSize = true;
            this.rbDescricao.Location = new System.Drawing.Point(6, 42);
            this.rbDescricao.Name = "rbDescricao";
            this.rbDescricao.Size = new System.Drawing.Size(92, 17);
            this.rbDescricao.TabIndex = 1;
            this.rbDescricao.TabStop = true;
            this.rbDescricao.Text = "Por Descrição";
            this.rbDescricao.UseVisualStyleBackColor = true;
            this.rbDescricao.Click += new System.EventHandler(this.rbDescricao_Click);
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Location = new System.Drawing.Point(6, 19);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(77, 17);
            this.rbCodigo.TabIndex = 0;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Por Código";
            this.rbCodigo.UseVisualStyleBackColor = true;
            this.rbCodigo.Click += new System.EventHandler(this.rbCodigo_Click);
            // 
            // SF_CM0100A
            // 
            this.SF_CM0100A.AllowUserToAddRows = false;
            this.SF_CM0100A.AllowUserToDeleteRows = false;
            this.SF_CM0100A.AllowUserToResizeColumns = false;
            this.SF_CM0100A.AllowUserToResizeRows = false;
            this.SF_CM0100A.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SF_CM0100A.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_CODMAT,
            this.Column2,
            this.Column3,
            this.Column4});
            this.SF_CM0100A.Location = new System.Drawing.Point(12, 118);
            this.SF_CM0100A.Name = "SF_CM0100A";
            this.SF_CM0100A.ReadOnly = true;
            this.SF_CM0100A.RowHeadersVisible = false;
            this.SF_CM0100A.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SF_CM0100A.Size = new System.Drawing.Size(726, 275);
            this.SF_CM0100A.TabIndex = 1;
            // 
            // C_CODMAT
            // 
            this.C_CODMAT.DataPropertyName = "C_CODMAT";
            this.C_CODMAT.HeaderText = "Código";
            this.C_CODMAT.Name = "C_CODMAT";
            this.C_CODMAT.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "C_DESMAT";
            this.Column2.HeaderText = "Descrição do Material";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "C_CHAPES";
            this.Column3.HeaderText = "Palavra Chave";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "C_NUMDES";
            this.Column4.HeaderText = "Desenho";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.btnAlterar);
            this.groupBox2.Controls.Add(this.btnIncluir);
            this.groupBox2.Location = new System.Drawing.Point(510, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 90);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = global::CMSQL_DLL.Properties.Resources.excluir;
            this.btnExcluir.Location = new System.Drawing.Point(168, 23);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(54, 42);
            this.btnExcluir.TabIndex = 47;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Image = global::CMSQL_DLL.Properties.Resources.alterar;
            this.btnAlterar.Location = new System.Drawing.Point(86, 23);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(54, 42);
            this.btnAlterar.TabIndex = 46;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.FlatAppearance.BorderSize = 0;
            this.btnIncluir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluir.Image = global::CMSQL_DLL.Properties.Resources._new;
            this.btnIncluir.Location = new System.Drawing.Point(6, 23);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(54, 42);
            this.btnIncluir.TabIndex = 45;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Image = global::CMSQL_DLL.Properties.Resources.Sairnovo;
            this.btnSair.Location = new System.Drawing.Point(679, 400);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(59, 70);
            this.btnSair.TabIndex = 7;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(283, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Visible = false;
            // 
            // TELA_CADASTRO_MATERIAIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 482);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.SF_CM0100A);
            this.Controls.Add(this.groupBox1);
            this.Name = "TELA_CADASTRO_MATERIAIS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Cadastro de Materiais";
            this.Load += new System.EventHandler(this.TELA_CADASTRO_MATERIAIS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SF_CM0100A)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDesMat;
        private System.Windows.Forms.TextBox txtCodmat;
        private System.Windows.Forms.RadioButton rbPalavraChave;
        private System.Windows.Forms.RadioButton rbDescricao;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.Button btnPesqMaterial;
        private System.Windows.Forms.ComboBox cbPalavraChave;
        private System.Windows.Forms.DataGridView SF_CM0100A;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_CODMAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}