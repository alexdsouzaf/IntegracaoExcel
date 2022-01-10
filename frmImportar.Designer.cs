namespace IntegracaoExcel
{
    partial class frmImportar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPesquisarCaminho = new System.Windows.Forms.Button();
            this.lblCaminho = new System.Windows.Forms.Label();
            this.txtDestinoArquivo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(306, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnPesquisarCaminho
            // 
            this.btnPesquisarCaminho.Location = new System.Drawing.Point(227, 23);
            this.btnPesquisarCaminho.Name = "btnPesquisarCaminho";
            this.btnPesquisarCaminho.Size = new System.Drawing.Size(69, 23);
            this.btnPesquisarCaminho.TabIndex = 9;
            this.btnPesquisarCaminho.Text = "Pesquisar";
            this.btnPesquisarCaminho.UseVisualStyleBackColor = true;
            this.btnPesquisarCaminho.Click += new System.EventHandler(this.btnPesquisarCaminho_Click);
            // 
            // lblCaminho
            // 
            this.lblCaminho.AutoSize = true;
            this.lblCaminho.Location = new System.Drawing.Point(11, 9);
            this.lblCaminho.Name = "lblCaminho";
            this.lblCaminho.Size = new System.Drawing.Size(102, 13);
            this.lblCaminho.TabIndex = 8;
            this.lblCaminho.Text = "Caminho do Arquivo";
            // 
            // txtDestinoArquivo
            // 
            this.txtDestinoArquivo.Location = new System.Drawing.Point(14, 25);
            this.txtDestinoArquivo.Name = "txtDestinoArquivo";
            this.txtDestinoArquivo.Size = new System.Drawing.Size(210, 20);
            this.txtDestinoArquivo.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmImportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPesquisarCaminho);
            this.Controls.Add(this.lblCaminho);
            this.Controls.Add(this.txtDestinoArquivo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmImportar";
            this.Text = "frmImportar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPesquisarCaminho;
        private System.Windows.Forms.Label lblCaminho;
        private System.Windows.Forms.TextBox txtDestinoArquivo;
        private System.Windows.Forms.Button button1;
    }
}