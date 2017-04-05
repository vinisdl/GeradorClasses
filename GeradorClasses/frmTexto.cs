using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Macoratti
{
    public partial class frmTexto : Form
    {
        String arquivoCodigo = "";
        public frmTexto(string arquivo)
        {
            InitializeComponent();
            arquivoCodigo = arquivo;
        }

        private void frmTexto_Load(object sender, EventArgs e)
        {
            leCodigo(arquivoCodigo);
            Text = Text + " - " + arquivoCodigo;
        }
        private void leCodigo(string arquivo)
        {
            try
            {
                // cria um instância de StreamReader para ler o arquivo
                using (StreamReader sr = new StreamReader(arquivo))
                {
                    String linha;
                    // Le e exibe as linhasa do arquivo ate o fim de arquivo
                    while ((linha = sr.ReadLine()) != null)
                    {
                        txtTexto.Text += linha + Environment.NewLine;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
