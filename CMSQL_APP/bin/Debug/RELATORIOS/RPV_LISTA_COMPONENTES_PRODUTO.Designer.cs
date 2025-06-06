namespace CMSQL_DLL.RELATORIOS
{
    partial class RPV_LISTA_COMPONENTES_PRODUTO
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
            this.rdlcListaMateriaisOS = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rdlcListaMateriaisOS
            // 
            this.rdlcListaMateriaisOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdlcListaMateriaisOS.Location = new System.Drawing.Point(0, 0);
            this.rdlcListaMateriaisOS.Name = "rdlcListaMateriaisOS";
            this.rdlcListaMateriaisOS.ServerReport.BearerToken = null;
            this.rdlcListaMateriaisOS.Size = new System.Drawing.Size(800, 450);
            this.rdlcListaMateriaisOS.TabIndex = 0;
            // 
            // RPV_LISTA_COMPONENTES_PRODUTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdlcListaMateriaisOS);
            this.Name = "RPV_LISTA_COMPONENTES_PRODUTO";
            this.Text = "RPV_LISTA_COMPONENTES_PRODUTO";
            this.Load += new System.EventHandler(this.RPV_LISTA_COMPONENTES_PRODUTO_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rdlcListaMateriaisOS;
    }
}