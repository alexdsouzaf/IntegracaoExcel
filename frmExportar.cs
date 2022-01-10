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
        string sCaminhoDefault = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); 
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
            if (Permitido() && ConfirmaCaminho())
                ExecutaExportacao();
            
        }

        private void btnPesquisarCaminho_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();    
            
            if (fbd.ShowDialog() == DialogResult.OK)
                txtDestinoArquivo.Text = fbd.SelectedPath;
            
        }

        private bool Permitido()
        {
            if (string.IsNullOrEmpty(txtNomeArquivo.Text))
            {
                MessageBox.Show(" - Caminho de destino do arquivo não pode estar vazio!");
                return false;
            }
            return true;
        }

        private bool ConfirmaCaminho()
        {
            bool bOK = false;
            if (string.IsNullOrEmpty(txtDestinoArquivo.Text))
                if (MessageBox.Show(" - Nenhum Caminho foi informado. Deseja utilizar o padrão?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    txtDestinoArquivo.Text = sCaminhoDefault;
                    bOK = true;
                }
                else
                    bOK = false;
               
            return bOK;
        }

        private void testeDataTable()
        {
            DataTable dtb = new DataTable();
            dtb.TableName = "Planilha";
            dtb.Columns.Add("ID");
            dtb.Columns.Add("DESCRICAO");
            DataRow row = dtb.NewRow();
            row["ID"] = "1";
            row["DESCRICAO"] = "Hello2";
            dtb.Rows.Add(row); 


            DataTable clonada = new DataTable();
            clonada = dtb.Clone();

            DataSet dts = new DataSet();
            dts.Tables.Add(clonada);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            testeDataTable();
        }


        private void testeDataSet()
        {
       
        }
    }
}
