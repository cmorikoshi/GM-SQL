namespace CMSQL_DLL.FORMULARIOS
{
    partial class TELA_CADASTRO_MATERIAIS_PRODUTO_DETALHE
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
            this.label3 = new System.Windows.Forms.Label();
            this.cb_desmat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.c_desmat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.c_codmat = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cb_tipmat = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cb_orimat = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.c_numdes = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_unimed = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_chapes = new System.Windows.Forms.ComboBox();
            this.btnCancela = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_desmat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.c_desmat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.c_codmat);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 130);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descrição do Material";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descrição Similar:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cb_desmat
            // 
            this.cb_desmat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.cb_desmat.FormattingEnabled = true;
            this.cb_desmat.Location = new System.Drawing.Point(70, 89);
            this.cb_desmat.Name = "cb_desmat";
            this.cb_desmat.Size = new System.Drawing.Size(747, 21);
            this.cb_desmat.TabIndex = 6;
            this.cb_desmat.SelectedIndexChanged += new System.EventHandler(this.cb_desmat_SelectedIndexChanged);
            this.cb_desmat.TextChanged += new System.EventHandler(this.cb_desmat_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição:";
            // 
            // c_desmat
            // 
            this.c_desmat.Location = new System.Drawing.Point(70, 44);
            this.c_desmat.Multiline = true;
            this.c_desmat.Name = "c_desmat";
            this.c_desmat.Size = new System.Drawing.Size(751, 42);
            this.c_desmat.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // c_codmat
            // 
            this.c_codmat.Location = new System.Drawing.Point(70, 19);
            this.c_codmat.Name = "c_codmat";
            this.c_codmat.ReadOnly = true;
            this.c_codmat.Size = new System.Drawing.Size(83, 20);
            this.c_codmat.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cb_tipmat);
            this.groupBox5.Location = new System.Drawing.Point(224, 207);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(164, 47);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tipo";
            // 
            // cb_tipmat
            // 
            this.cb_tipmat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipmat.FormattingEnabled = true;
            this.cb_tipmat.Location = new System.Drawing.Point(6, 19);
            this.cb_tipmat.Name = "cb_tipmat";
            this.cb_tipmat.Size = new System.Drawing.Size(148, 21);
            this.cb_tipmat.TabIndex = 7;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cb_orimat);
            this.groupBox6.Location = new System.Drawing.Point(21, 207);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(177, 47);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Origem / Tipo";
            // 
            // cb_orimat
            // 
            this.cb_orimat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_orimat.FormattingEnabled = true;
            this.cb_orimat.Location = new System.Drawing.Point(6, 19);
            this.cb_orimat.Name = "cb_orimat";
            this.cb_orimat.Size = new System.Drawing.Size(165, 21);
            this.cb_orimat.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.c_numdes);
            this.groupBox4.Location = new System.Drawing.Point(492, 148);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(347, 53);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Desenho";
            // 
            // c_numdes
            // 
            this.c_numdes.Location = new System.Drawing.Point(18, 20);
            this.c_numdes.Name = "c_numdes";
            this.c_numdes.Size = new System.Drawing.Size(319, 20);
            this.c_numdes.TabIndex = 7;
            this.c_numdes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_unimed);
            this.groupBox3.Location = new System.Drawing.Point(388, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(87, 53);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Unid. Medida";
            // 
            // cb_unimed
            // 
            this.cb_unimed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_unimed.FormattingEnabled = true;
            this.cb_unimed.Location = new System.Drawing.Point(8, 19);
            this.cb_unimed.Name = "cb_unimed";
            this.cb_unimed.Size = new System.Drawing.Size(58, 21);
            this.cb_unimed.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_chapes);
            this.groupBox2.Location = new System.Drawing.Point(18, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 53);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Palavra Chave";
            // 
            // cb_chapes
            // 
            this.cb_chapes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_chapes.FormattingEnabled = true;
            this.cb_chapes.Location = new System.Drawing.Point(6, 19);
            this.cb_chapes.Name = "cb_chapes";
            this.cb_chapes.Size = new System.Drawing.Size(352, 21);
            this.cb_chapes.TabIndex = 7;
            // 
            // btnCancela
            // 
            this.btnCancela.FlatAppearance.BorderSize = 0;
            this.btnCancela.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnCancela.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnCancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancela.Image = global::CMSQL_DLL.Properties.Resources.botaoCancelaCupom;
            this.btnCancela.Location = new System.Drawing.Point(764, 208);
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
            this.btnGravar.Location = new System.Drawing.Point(492, 208);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 55);
            this.btnGravar.TabIndex = 44;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // TELA_CADASTRO_MATERIAIS_PRODUTO_DETALHE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 281);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TELA_CADASTRO_MATERIAIS_PRODUTO_DETALHE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Materiais - Detalhe";
            this.Load += new System.EventHandler(this.TELA_CADASTRO_MATERIAIS_PRODUTO_DETALHE_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_desmat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox c_desmat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox c_codmat;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cb_tipmat;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cb_orimat;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox c_numdes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cb_unimed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_chapes;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Button btnGravar;
    }
}