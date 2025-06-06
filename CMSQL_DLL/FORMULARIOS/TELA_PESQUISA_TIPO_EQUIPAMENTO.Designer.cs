namespace CMSQL_DLL.FORMULARIOS
{
    partial class TELA_PESQUISA_TIPO_EQUIPAMENTO
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
            this.rbDescricao = new System.Windows.Forms.RadioButton();
            this.c_codmat1 = new System.Windows.Forms.TextBox();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.c_desmat1 = new System.Windows.Forms.TextBox();
            this.btnCancela = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.SF_TD0100B = new System.Windows.Forms.DataGridView();
            this.C_CODMAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_DESMAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SF_TD0100B)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDescricao);
            this.groupBox1.Controls.Add(this.c_codmat1);
            this.groupBox1.Controls.Add(this.rbCodigo);
            this.groupBox1.Controls.Add(this.c_desmat1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 76);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // rbDescricao
            // 
            this.rbDescricao.AutoSize = true;
            this.rbDescricao.Location = new System.Drawing.Point(6, 45);
            this.rbDescricao.Name = "rbDescricao";
            this.rbDescricao.Size = new System.Drawing.Size(76, 17);
            this.rbDescricao.TabIndex = 4;
            this.rbDescricao.TabStop = true;
            this.rbDescricao.Text = "Descrição:";
            this.rbDescricao.UseVisualStyleBackColor = true;
            this.rbDescricao.Click += new System.EventHandler(this.rbDescricao_Click);
            // 
            // c_codmat1
            // 
            this.c_codmat1.Location = new System.Drawing.Point(89, 18);
            this.c_codmat1.Name = "c_codmat1";
            this.c_codmat1.Size = new System.Drawing.Size(116, 20);
            this.c_codmat1.TabIndex = 1;
            this.c_codmat1.TextChanged += new System.EventHandler(this.c_codmat1_TextChanged);
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Location = new System.Drawing.Point(7, 19);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(61, 17);
            this.rbCodigo.TabIndex = 2;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Código:";
            this.rbCodigo.UseVisualStyleBackColor = true;
            this.rbCodigo.Click += new System.EventHandler(this.rbCodigo_Click);
            // 
            // c_desmat1
            // 
            this.c_desmat1.Location = new System.Drawing.Point(89, 44);
            this.c_desmat1.Name = "c_desmat1";
            this.c_desmat1.Size = new System.Drawing.Size(246, 20);
            this.c_desmat1.TabIndex = 3;
            this.c_desmat1.TextChanged += new System.EventHandler(this.c_desmat1_TextChanged);
            // 
            // btnCancela
            // 
            this.btnCancela.FlatAppearance.BorderSize = 0;
            this.btnCancela.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnCancela.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnCancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancela.Image = global::CMSQL_DLL.Properties.Resources.botaoCancelaCupom;
            this.btnCancela.Location = new System.Drawing.Point(358, 382);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(75, 68);
            this.btnCancela.TabIndex = 45;
            this.btnCancela.Text = "Cancelar";
            this.btnCancela.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.FlatAppearance.BorderSize = 0;
            this.btnGravar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnGravar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Image = global::CMSQL_DLL.Properties.Resources.confirmarnew;
            this.btnGravar.Location = new System.Drawing.Point(188, 382);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 68);
            this.btnGravar.TabIndex = 46;
            this.btnGravar.Text = "Confirmar";
            this.btnGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // SF_TD0100B
            // 
            this.SF_TD0100B.AllowUserToAddRows = false;
            this.SF_TD0100B.AllowUserToDeleteRows = false;
            this.SF_TD0100B.AllowUserToResizeColumns = false;
            this.SF_TD0100B.AllowUserToResizeRows = false;
            this.SF_TD0100B.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SF_TD0100B.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_CODMAT,
            this.C_DESMAT});
            this.SF_TD0100B.Location = new System.Drawing.Point(12, 94);
            this.SF_TD0100B.Name = "SF_TD0100B";
            this.SF_TD0100B.ReadOnly = true;
            this.SF_TD0100B.RowHeadersVisible = false;
            this.SF_TD0100B.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SF_TD0100B.Size = new System.Drawing.Size(421, 282);
            this.SF_TD0100B.TabIndex = 47;
            this.SF_TD0100B.TabStop = false;
            // 
            // C_CODMAT
            // 
            this.C_CODMAT.DataPropertyName = "C_CODMAT";
            this.C_CODMAT.HeaderText = "Código";
            this.C_CODMAT.Name = "C_CODMAT";
            this.C_CODMAT.Width = 70;
            // 
            // C_DESMAT
            // 
            this.C_DESMAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.C_DESMAT.DataPropertyName = "C_DESMAT";
            this.C_DESMAT.HeaderText = "Descrição";
            this.C_DESMAT.Name = "C_DESMAT";
            // 
            // TELA_PESQUISA_TIPO_EQUIPAMENTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 462);
            this.Controls.Add(this.SF_TD0100B);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TELA_PESQUISA_TIPO_EQUIPAMENTO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa Componente";
            this.Load += new System.EventHandler(this.TELA_PESQUISA_TIPO_EQUIPAMENTO_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SF_TD0100B)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox c_desmat1;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.DataGridView SF_TD0100B;
        private System.Windows.Forms.RadioButton rbDescricao;
        private System.Windows.Forms.TextBox c_codmat1;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_CODMAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_DESMAT;
    }
}