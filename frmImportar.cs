using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelApp = Microsoft.Office.Interop.Excel;

namespace IntegracaoExcel
{
    public partial class frmImportar : Form
    {
        public frmImportar()
        {
            InitializeComponent();
        }

        private void btnPesquisarCaminho_Click(object sender, EventArgs e)
        {
            OpenFileDialog fbd = new OpenFileDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
                txtDestinoArquivo.Text = fbd.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            try
            {

                ExcelApp.Application excelApp = new ExcelApp.Application();
                DataRow drwLinha;
                DataTable tabela;


                ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(txtDestinoArquivo.Text);
                ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
                ExcelApp.Range excelRange = excelSheet.UsedRange;

                int rows = excelRange.Rows.Count;
                int cols = excelRange.Columns.Count;

                tabela = new DataTable("PLANILHA");

                tabela.Columns.Add("id", typeof(string));
                tabela.Columns.Add("descricao", typeof(string));

                //first row using for heading, start second row for data
                for (int i = 2; i < rows; i++)
                {
                    drwLinha = tabela.NewRow();
                    drwLinha["id"] = excelRange.Cells[i, 1].Value2.ToString();
                    drwLinha["descricao"] = excelRange.Cells[i, 2].Value2.ToString();
                
                    tabela.Rows.Add(drwLinha);
                }

                excelApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                
                grdImportados.DataSource = tabela;
            }
            catch (Exception ex)
            {
                var erro = ex.Message;
            }
        }
    }
}
