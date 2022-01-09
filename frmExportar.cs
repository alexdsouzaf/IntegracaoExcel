using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegracaoExcel
{
    public partial class frmExportar : Form
    {
        public frmExportar()
        {
            InitializeComponent();
        }

        private void ExecutaExportacao()
        {
            try
            {
                string sArquivo = txtNomeArquivo.Text;
                string sExternsao = ".xls";
                string sDiretorio = txtDestinoArquivo.Text;
                string sCaminhoCompleto = sDiretorio + $@"\{sArquivo}{sExternsao}";
                
                StreamWriter sw = new StreamWriter(sCaminhoCompleto,true);//cria ou sobrescreve
                
                //cabeçalho
                for (int i = 0; i < grdPlanilha.ColumnCount; i++)
                {
                    sw.Write(grdPlanilha.Columns[i].HeaderText.ToString() + " \t");
                }
                sw.WriteLine();

                //valores
                for (int i = 0; i < grdPlanilha.RowCount; i++)
                {
                    for (int j = 0; j < grdPlanilha.ColumnCount; j++)
                    {
                        if (grdPlanilha.Rows[i].Cells[j].Value != null)
                            sw.Write(grdPlanilha.Rows[i].Cells[j].Value.ToString() + " \t");
                    }
                    sw.WriteLine();
                }
                sw.Close();
                sw.Dispose();
                MessageBox.Show("Tabela exportada com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();  
            if (string.IsNullOrEmpty(txtDestinoArquivo.Text))
                stringBuilder.AppendLine(" - Caminho de destino do arquivo não pode estar vazio!");

            if (string.IsNullOrEmpty(txtNomeArquivo.Text))
                stringBuilder.AppendLine(" - Deve ser informado um nome para o arquivo!");


            if (string.IsNullOrEmpty(stringBuilder.ToString()))
                MessageBox.Show(stringBuilder.ToString());
            else
                ExecutaExportacao();
        }

        private void btnPesquisarCaminho_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();    
            
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtDestinoArquivo.Text = fbd.SelectedPath;
            }
        }
    }
}
