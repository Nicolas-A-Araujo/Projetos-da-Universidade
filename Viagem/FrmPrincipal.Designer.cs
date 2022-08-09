namespace Viagem
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbDistancia = new System.Windows.Forms.Label();
            this.lbConsumo = new System.Windows.Forms.Label();
            this.lbCombustivel = new System.Windows.Forms.Label();
            this.ckGastoPedagio = new System.Windows.Forms.CheckBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.txtCombustivel = new System.Windows.Forms.TextBox();
            this.lbPedagio = new System.Windows.Forms.Label();
            this.txtPedagio = new System.Windows.Forms.TextBox();
            this.lbCifraoPedagio = new System.Windows.Forms.Label();
            this.lbCifrao = new System.Windows.Forms.Label();
            this.lbKML = new System.Windows.Forms.Label();
            this.lbKm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.Location = new System.Drawing.Point(12, 31);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(294, 29);
            this.lbInfo.TabIndex = 0;
            this.lbInfo.Text = "Informe dados da Viagem:";
            // 
            // lbDistancia
            // 
            this.lbDistancia.AutoSize = true;
            this.lbDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDistancia.Location = new System.Drawing.Point(12, 113);
            this.lbDistancia.Name = "lbDistancia";
            this.lbDistancia.Size = new System.Drawing.Size(189, 24);
            this.lbDistancia.TabIndex = 1;
            this.lbDistancia.Text = "Distancia a Percorrer:";
            // 
            // lbConsumo
            // 
            this.lbConsumo.AutoSize = true;
            this.lbConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsumo.Location = new System.Drawing.Point(11, 163);
            this.lbConsumo.Name = "lbConsumo";
            this.lbConsumo.Size = new System.Drawing.Size(251, 24);
            this.lbConsumo.TabIndex = 2;
            this.lbConsumo.Text = "Consumo Médio do Veículo:";
            // 
            // lbCombustivel
            // 
            this.lbCombustivel.AutoSize = true;
            this.lbCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCombustivel.Location = new System.Drawing.Point(12, 213);
            this.lbCombustivel.Name = "lbCombustivel";
            this.lbCombustivel.Size = new System.Drawing.Size(194, 24);
            this.lbCombustivel.TabIndex = 3;
            this.lbCombustivel.Text = "Valor do Combustivel:";
            // 
            // ckGastoPedagio
            // 
            this.ckGastoPedagio.AutoSize = true;
            this.ckGastoPedagio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckGastoPedagio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckGastoPedagio.Location = new System.Drawing.Point(15, 263);
            this.ckGastoPedagio.Name = "ckGastoPedagio";
            this.ckGastoPedagio.Size = new System.Drawing.Size(264, 28);
            this.ckGastoPedagio.TabIndex = 4;
            this.ckGastoPedagio.Text = "Houve Gasto com pedágio?";
            this.ckGastoPedagio.UseVisualStyleBackColor = true;
            this.ckGastoPedagio.CheckedChanged += new System.EventHandler(this.ckGastoPedagio_CheckedChanged);
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.Yellow;
            this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(16, 380);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(452, 49);
            this.btCalcular.TabIndex = 5;
            this.btCalcular.Text = "Calcular Gasto com essa Viagem";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // txtDistancia
            // 
            this.txtDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistancia.Location = new System.Drawing.Point(291, 113);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(68, 27);
            this.txtDistancia.TabIndex = 6;
            // 
            // txtConsumo
            // 
            this.txtConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsumo.Location = new System.Drawing.Point(291, 164);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(68, 27);
            this.txtConsumo.TabIndex = 7;
            // 
            // txtCombustivel
            // 
            this.txtCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCombustivel.Location = new System.Drawing.Point(291, 210);
            this.txtCombustivel.Name = "txtCombustivel";
            this.txtCombustivel.Size = new System.Drawing.Size(68, 27);
            this.txtCombustivel.TabIndex = 8;
            // 
            // lbPedagio
            // 
            this.lbPedagio.AutoSize = true;
            this.lbPedagio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPedagio.Location = new System.Drawing.Point(14, 317);
            this.lbPedagio.Name = "lbPedagio";
            this.lbPedagio.Size = new System.Drawing.Size(180, 24);
            this.lbPedagio.TabIndex = 9;
            this.lbPedagio.Text = "Gasto com Pedagio:";
            this.lbPedagio.Visible = false;
            // 
            // txtPedagio
            // 
            this.txtPedagio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedagio.Location = new System.Drawing.Point(291, 314);
            this.txtPedagio.Name = "txtPedagio";
            this.txtPedagio.Size = new System.Drawing.Size(68, 27);
            this.txtPedagio.TabIndex = 10;
            this.txtPedagio.Visible = false;
            // 
            // lbCifraoPedagio
            // 
            this.lbCifraoPedagio.AutoSize = true;
            this.lbCifraoPedagio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCifraoPedagio.Location = new System.Drawing.Point(252, 317);
            this.lbCifraoPedagio.Name = "lbCifraoPedagio";
            this.lbCifraoPedagio.Size = new System.Drawing.Size(33, 22);
            this.lbCifraoPedagio.TabIndex = 11;
            this.lbCifraoPedagio.Text = "R$";
            this.lbCifraoPedagio.Visible = false;
            // 
            // lbCifrao
            // 
            this.lbCifrao.AutoSize = true;
            this.lbCifrao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCifrao.Location = new System.Drawing.Point(252, 213);
            this.lbCifrao.Name = "lbCifrao";
            this.lbCifrao.Size = new System.Drawing.Size(33, 22);
            this.lbCifrao.TabIndex = 12;
            this.lbCifrao.Text = "R$";
            // 
            // lbKML
            // 
            this.lbKML.AutoSize = true;
            this.lbKML.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKML.Location = new System.Drawing.Point(365, 167);
            this.lbKML.Name = "lbKML";
            this.lbKML.Size = new System.Drawing.Size(51, 22);
            this.lbKML.TabIndex = 13;
            this.lbKML.Text = "Km/L";
            // 
            // lbKm
            // 
            this.lbKm.AutoSize = true;
            this.lbKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKm.Location = new System.Drawing.Point(365, 116);
            this.lbKm.Name = "lbKm";
            this.lbKm.Size = new System.Drawing.Size(36, 22);
            this.lbKm.TabIndex = 14;
            this.lbKm.Text = "Km";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.lbKm);
            this.Controls.Add(this.lbKML);
            this.Controls.Add(this.lbCifrao);
            this.Controls.Add(this.lbCifraoPedagio);
            this.Controls.Add(this.txtPedagio);
            this.Controls.Add(this.lbPedagio);
            this.Controls.Add(this.txtCombustivel);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.ckGastoPedagio);
            this.Controls.Add(this.lbCombustivel);
            this.Controls.Add(this.lbConsumo);
            this.Controls.Add(this.lbDistancia);
            this.Controls.Add(this.lbInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "Calculadora da Viagem";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label lbDistancia;
        private System.Windows.Forms.Label lbConsumo;
        private System.Windows.Forms.Label lbCombustivel;
        private System.Windows.Forms.CheckBox ckGastoPedagio;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.TextBox txtCombustivel;
        private System.Windows.Forms.Label lbPedagio;
        private System.Windows.Forms.TextBox txtPedagio;
        private System.Windows.Forms.Label lbCifraoPedagio;
        private System.Windows.Forms.Label lbCifrao;
        private System.Windows.Forms.Label lbKML;
        private System.Windows.Forms.Label lbKm;
    }
}

