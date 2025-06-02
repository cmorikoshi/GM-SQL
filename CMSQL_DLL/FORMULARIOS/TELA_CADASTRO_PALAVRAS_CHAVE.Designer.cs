namespace CMSQL_DLL.FORMULARIOS
{
    partial class TELA_CADASTRO_PALAVRAS_CHAVE
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SF0500A = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.c_chapes = new System.Windows.Forms.TextBox();
            this.C_CHAPES1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_CONEST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SF0500A)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.btnAlterar);
            this.groupBox2.Controls.Add(this.btnIncluir);
            this.groupBox2.Location = new System.Drawing.Point(12, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 90);
            this.groupBox2.TabIndex = 3;
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
            this.btnSair.Image = global::CMSQL_DLL.Properties.Resources.SairSetaDireita48x48;
            this.btnSair.Location = new System.Drawing.Point(317, 355);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(76, 73);
            this.btnSair.TabIndex = 4;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // SF0500A
            // 
            this.SF0500A.AllowUserToAddRows = false;
            this.SF0500A.AllowUserToDeleteRows = false;
            this.SF0500A.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SF0500A.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_CHAPES1,
            this.C_CONEST});
            this.SF0500A.Location = new System.Drawing.Point(12, 75);
            this.SF0500A.Name = "SF0500A";
            this.SF0500A.ReadOnly = true;
            this.SF0500A.RowHeadersVisible = false;
            this.SF0500A.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SF0500A.Size = new System.Drawing.Size(381, 246);
            this.SF0500A.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.c_chapes);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 57);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Palavra chave:";
            // 
            // c_chapes
            // 
            this.c_chapes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.c_chapes.Location = new System.Drawing.Point(100, 20);
            this.c_chapes.Name = "c_chapes";
            this.c_chapes.Size = new System.Drawing.Size(275, 20);
            this.c_chapes.TabIndex = 0;
            this.c_chapes.TextChanged += new System.EventHandler(this.c_chapes_TextChanged);
            // 
            // C_CHAPES1
            // 
            this.C_CHAPES1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.C_CHAPES1.DataPropertyName = "C_CHAPES";
            this.C_CHAPES1.HeaderText = "Palavra Chave";
            this.C_CHAPES1.Name = "C_CHAPES1";
            this.C_CHAPES1.ReadOnly = true;
            // 
            // C_CONEST
            // 
            this.C_CONEST.DataPropertyName = "C_CONEST";
            this.C_CONEST.HeaderText = "C/E";
            this.C_CONEST.Name = "C_CONEST";
            this.C_CONEST.ReadOnly = true;
            this.C_CONEST.Width = 60;
            // 
            // TELA_CADASTRO_PALAVRAS_CHAVE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SF0500A);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TELA_CADASTRO_PALAVRAS_CHAVE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Palavras Chaves";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SF0500A)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView SF0500A;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox c_chapes;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_CHAPES1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_CONEST;
    }
}