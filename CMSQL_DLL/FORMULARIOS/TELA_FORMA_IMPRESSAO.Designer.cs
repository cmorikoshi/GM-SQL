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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.c_descos = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rb_lmc = new System.Windows.Forms.RadioButton();
            this.rb_pedido = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnCancela = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
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
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(84, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(114, 20);
            this.textBox1.TabIndex = 21;
            // 
            // c_descos
            // 
            this.c_descos.Location = new System.Drawing.Point(12, 29);
            this.c_descos.Multiline = true;
            this.c_descos.Name = "c_descos";
            this.c_descos.ReadOnly = true;
            this.c_descos.Size = new System.Drawing.Size(434, 84);
            this.c_descos.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.rb_lmc);
            this.groupBox2.Controls.Add(this.rb_pedido);
            this.groupBox2.Location = new System.Drawing.Point(55, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 105);
            this.groupBox2.TabIndex = 142;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exibir no Relatório:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(123, 17);
            this.radioButton1.TabIndex = 29;
            this.radioButton1.Text = "Todos Componentes";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rb_lmc
            // 
            this.rb_lmc.AutoSize = true;
            this.rb_lmc.Location = new System.Drawing.Point(6, 73);
            this.rb_lmc.Name = "rb_lmc";
            this.rb_lmc.Size = new System.Drawing.Size(171, 17);
            this.rb_lmc.TabIndex = 22;
            this.rb_lmc.Text = "Só os SEM estoque disponível";
            this.rb_lmc.UseVisualStyleBackColor = true;
            // 
            // rb_pedido
            // 
            this.rb_pedido.AutoSize = true;
            this.rb_pedido.Location = new System.Drawing.Point(6, 47);
            this.rb_pedido.Name = "rb_pedido";
            this.rb_pedido.Size = new System.Drawing.Size(172, 17);
            this.rb_pedido.TabIndex = 21;
            this.rb_pedido.Text = "Só os COM estoque disponível";
            this.rb_pedido.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(56, 247);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 17);
            this.checkBox1.TabIndex = 143;
            this.checkBox1.Text = "Mostrar estoque atual";
            this.checkBox1.UseVisualStyleBackColor = true;
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
            // 
            // TELA_FORMA_IMPRESSAO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 292);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.c_descos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TELA_FORMA_IMPRESSAO";
            this.Text = "Forma de Impressão";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox c_descos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rb_lmc;
        private System.Windows.Forms.RadioButton rb_pedido;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Button btnImprimir;
    }
}