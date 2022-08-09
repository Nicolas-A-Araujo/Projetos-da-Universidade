namespace Viagem
{
    partial class FrmRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorio));
            this.rtRelatorio = new System.Windows.Forms.RichTextBox();
            this.btSair = new System.Windows.Forms.Button();
            this.btExportarTXT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtRelatorio
            // 
            this.rtRelatorio.Location = new System.Drawing.Point(1, 0);
            this.rtRelatorio.Name = "rtRelatorio";
            this.rtRelatorio.Size = new System.Drawing.Size(493, 292);
            this.rtRelatorio.TabIndex = 0;
            this.rtRelatorio.Text = "";
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Location = new System.Drawing.Point(406, 298);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(88, 37);
            this.btSair.TabIndex = 1;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btExportarTXT
            // 
            this.btExportarTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExportarTXT.Location = new System.Drawing.Point(288, 298);
            this.btExportarTXT.Name = "btExportarTXT";
            this.btExportarTXT.Size = new System.Drawing.Size(112, 37);
            this.btExportarTXT.TabIndex = 2;
            this.btExportarTXT.Text = "ExportarTXT";
            this.btExportarTXT.UseVisualStyleBackColor = true;
            this.btExportarTXT.Click += new System.EventHandler(this.btExportarTXT_Click);
            // 
            // FrmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 364);
            this.Controls.Add(this.btExportarTXT);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.rtRelatorio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRelatorio";
            this.Text = "Relátorio de Gastos";
            this.Load += new System.EventHandler(this.FrmRelatorio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtRelatorio;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btExportarTXT;
    }
}