namespace IntegracaoExcel
{
    partial class frmExportar
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
            this.grdPlanilha = new System.Windows.Forms.DataGridView();
            this.clnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExportar = new System.Windows.Forms.Button();
            this.txtNomeArquivo = new System.Windows.Forms.TextBox();
            this.lblNomeArquivo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPesquisarCaminho = new System.Windows.Forms.Button();
            this.lblDestino = new System.Windows.Forms.Label();
            this.txtDestinoArquivo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdPlanilha)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdPlanilha
            // 
            this.grdPlanilha.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdPlanilha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPlanilha.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnID,
            this.clnDESCRICAO});
            this.grdPlanilha.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdPlanilha.Location = new System.Drawing.Point(0, 116);
            this.grdPlanilha.Name = "grdPlanilha";
            this.grdPlanilha.Size = new System.Drawing.Size(405, 234);
            this.grdPlanilha.TabIndex = 0;
            // 
            // clnID
            // 
            this.clnID.HeaderText = "ID";
            this.clnID.Name = "clnID";
            // 
            // clnDESCRICAO
            // 
            this.clnDESCRICAO.HeaderText = "DESCRICAO";
            this.clnDESCRICAO.Name = "clnDESCRICAO";
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(318, 87);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 1;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNomeArquivo
            // 
            this.txtNomeArquivo.Location = new System.Drawing.Point(12, 28);
            this.txtNomeArquivo.Name = "txtNomeArquivo";
            this.txtNomeArquivo.Size = new System.Drawing.Size(100, 20);
            this.txtNomeArquivo.TabIndex = 2;
            // 
            // lblNomeArquivo
            // 
            this.lblNomeArquivo.AutoSize = true;
            this.lblNomeArquivo.Location = new System.Drawing.Point(9, 12);
            this.lblNomeArquivo.Name = "lblNomeArquivo";
            this.lblNomeArquivo.Size = new System.Drawing.Size(89, 13);
            this.lblNomeArquivo.TabIndex = 3;
            this.lblNomeArquivo.Text = "Nome do Arquivo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPesquisarCaminho);
            this.groupBox1.Controls.Add(this.lblDestino);
            this.groupBox1.Controls.Add(this.txtDestinoArquivo);
            this.groupBox1.Controls.Add(this.btnExportar);
            this.groupBox1.Controls.Add(this.lblNomeArquivo);
            this.groupBox1.Controls.Add(this.txtNomeArquivo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 116);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnPesquisarCaminho
            // 
            this.btnPesquisarCaminho.Location = new System.Drawing.Point(333, 26);
            this.btnPesquisarCaminho.Name = "btnPesquisarCaminho";
            this.btnPesquisarCaminho.Size = new System.Drawing.Size(69, 23);
            this.btnPesquisarCaminho.TabIndex = 6;
            this.btnPesquisarCaminho.Text = "Pesquisar";
            this.btnPesquisarCaminho.UseVisualStyleBackColor = true;
            this.btnPesquisarCaminho.Click += new System.EventHandler(this.btnPesquisarCaminho_Click);
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(117, 12);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(97, 13);
            this.lblDestino.TabIndex = 5;
            this.lblDestino.Text = "Destino do Arquivo";
            // 
            // txtDestinoArquivo
            // 
            this.txtDestinoArquivo.Location = new System.Drawing.Point(120, 28);
            this.txtDestinoArquivo.Name = "txtDestinoArquivo";
            this.txtDestinoArquivo.Size = new System.Drawing.Size(210, 20);
            this.txtDestinoArquivo.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmExportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 350);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdPlanilha);
            this.Name = "frmExportar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exportar";
            ((System.ComponentModel.ISupportInitialize)(this.grdPlanilha)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdPlanilha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDESCRICAO;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.TextBox txtNomeArquivo;
        private System.Windows.Forms.Label lblNomeArquivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPesquisarCaminho;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.TextBox txtDestinoArquivo;
        private System.Windows.Forms.Button button1;
    }
}

