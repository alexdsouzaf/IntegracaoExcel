using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            /*do something
             dar um jeito de ler o arquivo em excel 
             para montar a gridview*/

        }
    }
}
