using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace apCaminhos
{
    internal class GrafoBacktraking
    {
        const int tamCodigo = 3,
        tamDistancia = 5,
        tamTempo = 4,
        tamCusto = 4;

        const int iniCodigoOrigem = 0,
                  iniCodigoDestino = iniCodigoOrigem + tamCodigo,
                  iniDistancia = iniCodigoDestino + tamCodigo,
                  iniTempo = iniDistancia + tamDistancia,
                  iniCusto = iniTempo + tamTempo;

        char tipoGrafo;
        int qtasCidades;
        int[,] matriz;

        public GrafoBacktraking(string nomeDeArquivo)
        {
            var arqruivo = new StreamReader(nomeDeArquivo);
            tipoGrafo = arqruivo.ReadLine()[0]; // vai acessar o primeiro caracter com o tipo do Grafo
            qtasCidades = int.Parse(arqruivo.ReadLine());
            matriz = new int[qtasCidades, qtasCidades];

            for (int linha = 0; linha < qtasCidades; linha++)
            {
                for (int coluna = 0; coluna < qtasCidades; coluna++)
                {
                    string arestas = arqruivo.ReadLine();
                    matriz[linha, coluna] = int.Parse(arestas.Substring(0,3));
                }
            }

        }

        public char TipoGrafo { get => tipoGrafo; set => tipoGrafo = value; }
        public int QuantasCidades { get => qtasCidades; set => qtasCidades = value; }
        public int[,] Matriz { get => matriz; set => matriz = value; }

        public void Exibir(DataGridView dvg)
        {
            dvg.RowCount = dvg.ColumnCount = qtasCidades;
            for (int coluna = 0; coluna < qtasCidades; coluna++)
            {
                dvg.Columns[coluna].HeaderText = coluna.ToString();
                dvg.Rows[coluna].HeaderCell.Value = coluna.ToString();
                dvg.Columns[coluna].Width = 30;
            }

            for (int linha = 0; linha < qtasCidades; linha++)
            {
                for (int coluna = 0; coluna < qtasCidades; coluna++)
                    if (matriz[linha, coluna] != 0)
                        dvg[coluna, linha].Value = matriz[coluna, linha];
            }
        }

        public PilhaLista<Movimento> BuscarCaminho(int origem, int destino, DataGridView dgvCaminho, DataGridView dgvGrafo)
        {
            int cidadeAtual, saidaAtual;
            bool achouCaminho = false,
            naoTemSaida = false;
            bool[] passou = new bool[qtasCidades];
            // inicia os valores de “passou” pois ainda não foi em nenhuma cidade
            for (int indice = 0; indice < qtasCidades; indice++)
                passou[indice] = false;
            cidadeAtual = origem;
            saidaAtual = 0;
            var pilha = new PilhaLista<Movimento>();
            while (!achouCaminho && !naoTemSaida)
            {
                naoTemSaida = (cidadeAtual == origem && saidaAtual == qtasCidades && pilha.EstaVazia);
                if (!naoTemSaida)
                {
                    while ((saidaAtual < qtasCidades) && !achouCaminho)
                    {
                        if (matriz[cidadeAtual, saidaAtual] == 0)
                            saidaAtual++;
                        else
                            if (passou[saidaAtual])
                            saidaAtual++;
                        else if (saidaAtual == destino)
                        {
                            Movimento movim = new Movimento(cidadeAtual, saidaAtual);
                            pilha.Empilhar(movim);
                            achouCaminho = true;
                           ExibirUmPasso();
                        }
                        else
                        {
                            ExibirUmPasso();
                            Movimento movim = new Movimento(cidadeAtual, saidaAtual);
                            pilha.Empilhar(movim);
                            passou[cidadeAtual] = true;
                            cidadeAtual = saidaAtual; // muda para a nova cidade 
                            saidaAtual = 0;
                        }
                    }
                }

                if (!achouCaminho)
                    if (!pilha.EstaVazia)
                    {
                        var movim = pilha.Desempilhar();
                        saidaAtual = movim.Destino;
                        cidadeAtual = movim.Origem;
                        ExibirUmPasso();
                        saidaAtual++;
                    }
            }

            var saida = new PilhaLista<Movimento>();
            if (achouCaminho)
            { // desempilha a configuração atual da pilha
              // para a pilha da lista de parâmetros
                while (!pilha.EstaVazia)
                {
                    Movimento movim = pilha.Desempilhar();
                    saida.Empilhar(movim);
                }
            }
            return saida;
            
            void ExibirUmPasso()
            {
                dgvGrafo.CurrentCell = dgvGrafo[saidaAtual, cidadeAtual];
                Exibir(dgvCaminho);
                Thread.Sleep(1000);
            }
        }
    }
}
