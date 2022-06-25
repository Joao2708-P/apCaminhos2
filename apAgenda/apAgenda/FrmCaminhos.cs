using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apCaminhos
{
    public partial class FrmCaminhos : Form
    {
        ListaDupla<Cidade> cidadeListaDupla;
        ListaDupla<Ligacao> ligacaoListaDupla;
        GrafoBacktraking oGrafo;
        public FrmCaminhos()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAgenda_Load(object sender, EventArgs e)
        {
            int indice = 0;
            Caminhos.ImageList = imlBotoes;
            foreach (ToolStripItem item in Caminhos.Items)
                if (item is ToolStripButton)
                    (item as ToolStripButton).ImageIndex = indice++;

             if(dlgAbrir.ShowDialog() == DialogResult.OK)
             {
                cidadeListaDupla=new ListaDupla<Cidade>();
                cidadeListaDupla.LerDados(dlgAbrir.FileName);
             }

            if (dlgAbrir2.ShowDialog() == DialogResult.OK)
            {
                //Leitura dos arquivos das cidades
                ligacaoListaDupla = new ListaDupla<Ligacao>();
                ligacaoListaDupla.LerDados(dlgAbrir2.FileName);
                oGrafo = new GrafoBacktraking(dlgAbrir2.FileName);
            }

            cidadeListaDupla.PosicionarNoPrimeiro();

            while (cidadeListaDupla.DadoAtual() != null)
            {
                cbxOrigem.Items.Add(cidadeListaDupla.DadoAtual().Nome);
                cbxDestino.Items.Add(cidadeListaDupla.DadoAtual().Nome);
                cidadeListaDupla.AvancarPosicao();
            }

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //Cidade cidade = cidadeListaDupla.DadoAtual();

            //    int x = (int)(cidade.X * pictureBox1.Width);
            //    int y = (int)(cidade.Y * pictureBox1.Height);

            //    e.Graphics.DrawEllipse(Pens.Red, new Rectangle(x, y, 5, 5));
            cidadeListaDupla.PosicionarNoPrimeiro();

            while (cidadeListaDupla.DadoAtual() != null)
            {
                Cidade cidade = cidadeListaDupla.DadoAtual();

                int x = (int)(cidade.X * pictureBox1.Width);
                int y = (int)(cidade.Y * pictureBox1.Height);

                string nome = (string)(cidade.Nome);

                StringFormat formatter = new StringFormat();
              //  formatter.LineAlignment = StringAlignment.Center;
                //formatter.Alignment = StringAlignment.Center;

                Rectangle rectangle = new Rectangle(x, y, pictureBox1.Width, pictureBox1.Height);

                e.Graphics.FillEllipse(Brushes.Black, new RectangleF(x, y, 5, 5));
                e.Graphics.DrawString(nome, pictureBox1.Font, Brushes.Black, rectangle, formatter);

                cidadeListaDupla.AvancarPosicao();
            }
        }


        private int retornaIndice(string nome)
        {
            while (cidadeListaDupla.DadoAtual() != null)
            {
                if (cidadeListaDupla.DadoAtual().Nome == nome)
                    return int.Parse(cidadeListaDupla.DadoAtual().Codigo);

                cidadeListaDupla.AvancarPosicao();
            }
            return -1;
        }

        private void btnCaminhos_Click(object sender, EventArgs e)
        {
            int origem = cbxOrigem.SelectedIndex;
            int destino = cbxDestino.SelectedIndex;
            var pilhaCaminho = oGrafo.BuscarCaminho(origem, destino, dgvMelhorCaminho, dgvCaminhosEncontrados);


            if (pilhaCaminho.EstaVazia)
                MessageBox.Show("Não achou caminho");
            else
            {
                MessageBox.Show("Achou caminho");
                var caminho = pilhaCaminho.DadosDaPilha();
                dgvCaminhosEncontrados.ColumnCount = caminho.Count + 1;
                dgvCaminhosEncontrados.RowCount = 3;
                dgvCaminhosEncontrados[0, 0].Value = "Origem";
                dgvCaminhosEncontrados[0, 1].Value = "Destino";
                int indice = 1;
                foreach (var c in caminho)
                {
                    dgvCaminhosEncontrados[indice, 0].Value = c.Origem;
                    dgvCaminhosEncontrados[indice, 1].Value = c.Destino;
                    indice++;
                }
            }
        }

        private void cbxOrigem_SelectedIndexChanged(object sender, EventArgs e)
        {
            cidadeListaDupla.Equals(cbxOrigem.SelectedIndex);
        }
    }
}