namespace CMSQL_DLL.FORMULARIOS
{
    partial class TELA_FORMA_IMPRESSAO
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
            this.label5 = new System.Windows.Forms.Label();
            this.c_codequ = new System.Windows.Forms.TextBox();
            this.c_descos = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbTodosComponentes = new System.Windows.Forms.RadioButton();
            this.rb_SemEstoqueDisponivel = new System.Windows.Forms.RadioButton();
            this.rb_ComEstoqutDisponivel = new System.Windows.Forms.RadioButton();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.c_numdes = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Produto:";
            // 
            // c_codequ
            // 
            this.c_codequ.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.c_codequ.Location = new System.Drawing.Point(84, 3);
            this.c_codequ.Name = "c_codequ";
            this.c_codequ.ReadOnly = true;
            this.c_codequ.Size = new System.Drawing.Size(114, 20);
            this.c_codequ.TabIndex = 21;
            this.c_codequ.TabStop = false;
            // 
            // c_descos
            // 
            this.c_descos.Location = new System.Drawing.Point(12, 40);
            this.c_descos.Multiline = true;
            this.c_descos.Name = "c_descos";
            this.c_descos.ReadOnly = true;
            this.c_descos.Size = new System.Drawing.Size(434, 84);
            this.c_descos.TabIndex = 20;
            this.c_descos.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.rbTodosComponentes);
            this.groupBox2.Controls.Add(this.rb_SemEstoqueDisponivel);
            this.groupBox2.Controls.Add(this.rb_ComEstoqutDisponivel);
            this.groupBox2.Location = new System.Drawing.Point(46, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 105);
            this.groupBox2.TabIndex = 142;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exibir no Relatório:";
            // 
            // rbTodosComponentes
            // 
            this.rbTodosComponentes.AutoSize = true;
            this.rbTodosComponentes.Location = new System.Drawing.Point(6, 21);
            this.rbTodosComponentes.Name = "rbTodosComponentes";
            this.rbTodosComponentes.Size = new System.Drawing.Size(123, 17);
            this.rbTodosComponentes.TabIndex = 29;
            this.rbTodosComponentes.Text = "Todos Componentes";
            this.rbTodosComponentes.UseVisualStyleBackColor = true;
            this.rbTodosComponentes.Click += new System.EventHandler(this.rbTodosComponentes_Click);
            // 
            // rb_SemEstoqueDisponivel
            // 
            this.rb_SemEstoqueDisponivel.AutoSize = true;
            this.rb_SemEstoqueDisponivel.Location = new System.Drawing.Point(6, 73);
            this.rb_SemEstoqueDisponivel.Name = "rb_SemEstoqueDisponivel";
            this.rb_SemEstoqueDisponivel.Size = new System.Drawing.Size(171, 17);
            this.rb_SemEstoqueDisponivel.TabIndex = 22;
            this.rb_SemEstoqueDisponivel.Text = "Só os SEM estoque disponível";
            this.rb_SemEstoqueDisponivel.UseVisualStyleBackColor = true;
            this.rb_SemEstoqueDisponivel.Click += new System.EventHandler(this.rb_SemEstoqueDisponivel_Click);
            // 
            // rb_ComEstoqutDisponivel
            // 
            this.rb_ComEstoqutDisponivel.AutoSize = true;
            this.rb_ComEstoqutDisponivel.Location = new System.Drawing.Point(6, 47);
            this.rb_ComEstoqutDisponivel.Name = "rb_ComEstoqutDisponivel";
            this.rb_ComEstoqutDisponivel.Size = new System.Drawing.Size(172, 17);
            this.rb_ComEstoqutDisponivel.TabIndex = 21;
            this.rb_ComEstoqutDisponivel.Text = "Só os COM estoque disponível";
            this.rb_ComEstoqutDisponivel.UseVisualStyleBackColor = true;
            this.rb_ComEstoqutDisponivel.Click += new System.EventHandler(this.rb_ComEstoqutDisponivel_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Image = global::CMSQL_DLL.Properties.Resources.imprimir;
            this.btnImprimir.Location = new System.Drawing.Point(355, 130);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(88, 73);
            this.btnImprimir.TabIndex = 155;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCancela
            // 
            this.btnCancela.FlatAppearance.BorderSize = 0;
            this.btnCancela.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnCancela.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnCancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancela.Image = global::CMSQL_DLL.Properties.Resources.botaoCancelaCupom;
            this.btnCancela.Location = new System.Drawing.Point(355, 209);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(75, 71);
            this.btnCancela.TabIndex = 154;
            this.btnCancela.Text = "Cancela";
            this.btnCancela.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // c_numdes
            // 
            this.c_numdes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.c_numdes.Location = new System.Drawing.Point(0, 260);
            this.c_numdes.Name = "c_numdes";
            this.c_numdes.ReadOnly = true;
            this.c_numdes.Size = new System.Drawing.Size(78, 20);
            this.c_numdes.TabIndex = 156;
            this.c_numdes.TabStop = false;
            this.c_numdes.Visible = false;
            // 
            // TELA_FORMA_IMPRESSAO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 281);
            this.Controls.Add(this.c_numdes);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.c_codequ);
            this.Controls.Add(this.c_descos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TELA_FORMA_IMPRESSAO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forma de Impressão";
            this.Load += new System.EventHandler(this.TELA_FORMA_IMPRESSAO_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox c_codequ;
        private System.Windows.Forms.TextBox c_descos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbTodosComponentes;
        private System.Windows.Forms.RadioButton rb_SemEstoqueDisponivel;
        private System.Windows.Forms.RadioButton rb_ComEstoqutDisponivel;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox c_numdes;
    }
}