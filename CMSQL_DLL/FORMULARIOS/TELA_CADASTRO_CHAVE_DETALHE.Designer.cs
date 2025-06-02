namespace CMSQL_DLL.FORMULARIOS
{
    partial class TELA_CADASTRO_CHAVE_DETALHE
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
            this.btnCancela = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_conest = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.c_chapes = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancela
            // 
            this.btnCancela.FlatAppearance.BorderSize = 0;
            this.btnCancela.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnCancela.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnCancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancela.Image = global::CMSQL_DLL.Properties.Resources.botaoCancelaCupom;
            this.btnCancela.Location = new System.Drawing.Point(371, 123);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(75, 55);
            this.btnCancela.TabIndex = 43;
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
            this.btnGravar.Location = new System.Drawing.Point(178, 123);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 55);
            this.btnGravar.TabIndex = 44;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_conest);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.c_chapes);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 96);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Controla Estoque:";
            // 
            // cb_conest
            // 
            this.cb_conest.FormattingEnabled = true;
            this.cb_conest.Items.AddRange(new object[] {
            "SIM",
            "NÃO"});
            this.cb_conest.Location = new System.Drawing.Point(110, 58);
            this.cb_conest.Name = "cb_conest";
            this.cb_conest.Size = new System.Drawing.Size(64, 21);
            this.cb_conest.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Palavra Chave:";
            // 
            // c_chapes
            // 
            this.c_chapes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.c_chapes.Location = new System.Drawing.Point(110, 23);
            this.c_chapes.Name = "c_chapes";
            this.c_chapes.Size = new System.Drawing.Size(283, 20);
            this.c_chapes.TabIndex = 0;
            // 
            // TELA_CADASTRO_CHAVE_DETALHE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 198);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnGravar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TELA_CADASTRO_CHAVE_DETALHE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Palavra Chave - Detalhe";
            this.Load += new System.EventHandler(this.TELA_CADASTRO_CHAVE_DETALHE_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_conest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox c_chapes;
    }
}