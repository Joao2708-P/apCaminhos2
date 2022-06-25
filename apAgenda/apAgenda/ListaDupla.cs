using System;
using System.IO;
using System.Windows.Forms;

class ListaDupla<Dado> : IDados<Dado>
                where Dado : IComparable<Dado>, IRegistro<Dado>, new()
{
    NoDuplo<Dado> primeiro, ultimo, atual;
    int quantosNos;

    public ListaDupla()
    {
        primeiro = ultimo = atual = null;
        quantosNos = 0; 
    }

    public Situacao SituacaoAtual 
    { 
         get => SituacaoAtual; set => SituacaoAtual = value; 
    }
    public int PosicaoAtual 
    {
        get
        {
            Existe(DadoAtual(), out int ondeEsta);
            return ondeEsta;
        }

        set
        {
            PosicaoAtual = value;
        } 
    }
    public bool EstaNoInicio
    {
        get
        {
            return (atual == primeiro);
        }
    } 
    public bool EstaNoFim
    {
        get
        {
            return (atual == ultimo);
        }
    }
    public bool EstaVazio 
    {
        get 
        {
            return (primeiro == null);  // (bool) Verificar se está vazia
        } 
    }         
    public int Tamanho => quantosNos;

    public void LerDados(string nomeArquivo)    // fará a leitura e armazenamento dos dados do arquivo cujo nome é passado por parâmetro
    {
        if (nomeArquivo != null)
        {
            var arquivo = new StreamReader(nomeArquivo);

            while (!arquivo.EndOfStream)
            {
                var dado = new Dado().LerRegistro(arquivo);

                IncluirAposFim(dado);
            }

            arquivo.Close();
        }
    }
    public void GravarDados(string nomeArquivo)  // gravará sequencialmente, no arquivo cujo nome é passado por parâmetro, os dados armazenados na lista
    {
        if (nomeArquivo != null)
            atual = primeiro;

        var arquivo = new StreamWriter(nomeArquivo);

        while (atual != null)
        {
            atual.Info.GravarRegistro(arquivo);
            atual = atual.Prox;
        }
        arquivo.Close();
    }
    public void PosicionarNoPrimeiro()        // Posicionar atual no primeiro nó para ser acessado
    {
        if (EstaVazio)
            atual = null;
        else
            atual = primeiro;
    }
    public void RetrocederPosicao()        // Retroceder atual para o nó anterior para ser acessado
    {
        if (EstaVazio)
            atual = null;
        if (atual != null)
            atual = atual.Ant;
    }
    public void AvancarPosicao()
    {
        if (EstaVazio)
            atual = null;

        if (atual != null)
            atual = atual.Prox;
    }
    public void PosicionarNoUltimo()        // posicionar atual no último nó para ser acessado
    {
        if (EstaVazio)
            atual = null;
        else
            atual = primeiro;
    }
    public void PosicionarEm(int posicaoDesejada)
    {
        PosicionarNoPrimeiro(); // posicionamos no inicio da lista, para assim então podermos percorre-la

        if (EstaVazio)
            atual = null;

        for (int i = 0; i < posicaoDesejada; i++)
        {
            atual = atual.Prox;
        }
    }

    // (bool) Pesquisar Dado procurado em ordem crescente; a pesquisa
    // posicionará o ponteiro atual no nó procurado quando este
    // or encontrado ou, se não achar, no nó seguinte a local
    // onde deveria estar o nó procurado
    public bool Existe(Dado procurado, out int ondeEsta)
    {
        ondeEsta = 0;
        if (EstaVazio)
        {
            ondeEsta = -1;
            return false;
        }

        if (procurado.CompareTo(primeiro.Info) < 0)
        {
            ondeEsta = -1;
            return false;
        }

        if (procurado.CompareTo(ultimo.Info) > 0)
        {
            PosicionarNoUltimo();
            ondeEsta = -1;
            return false;
        }

        bool encontrou = false;
        bool terminou = false;
        PosicionarNoPrimeiro();
        while (!encontrou && !terminou)
        {
            if (atual == null)
                terminou = true;
            else
                 if (procurado.CompareTo(atual.Info) == 0)
                encontrou = true;
            else
                 if (atual.Info.CompareTo(procurado) > 0)
                terminou = true;
            else
            {
                ondeEsta++;
                AvancarPosicao();
            }
        }
        return encontrou;
    }
    public bool Excluir(Dado dadoAExcluir)
    {
        if (dadoAExcluir == null) // verificamos se ele não é nulo
            return false;

        if (EstaVazio)
            return false;

        if (Existe(dadoAExcluir, out int ondeEsta)) // Vemos se ele existe ou não,
        {                                          // então quebramos essa conexão
            //PosicionarEm(ondeEsta);                // Com os outros dados da lista
            if (atual.Ant != null)
                atual.Ant.Prox = atual.Prox;

            if (atual.Prox != null)
            {
                atual.Prox.Ant = atual.Ant;
                atual = atual.Prox;
                quantosNos--;
                return true;
            }
        }
        return false;
    }
    public bool IncluirNoInicio(Dado novoValor)
    {
        if (novoValor == null)
            return false;

        var novoNo = new NoDuplo<Dado>(novoValor); // Passa o novo valor no nó da lista

        if (EstaVazio) // Se ela estiver vazia, ficará inculido no primeiro
        {
            primeiro = ultimo = novoNo;
        }
        else
        {
            novoNo.Prox = primeiro;
            novoNo.Ant = null;
            primeiro.Ant = novoNo;
            primeiro = novoNo;
        }
        quantosNos++;

        return true;
    }
    public bool IncluirAposFim(Dado novoValor)
    {
        if(novoValor == null)
            return false;

        var novoNo = new NoDuplo<Dado>(novoValor);

        if (EstaVazio)
        {
            primeiro = ultimo = novoNo;
        }
        else
        {
            novoNo.Ant = ultimo;
            novoNo.Prox = null;
            ultimo.Prox = novoNo;
            ultimo = novoNo;
        }
        quantosNos++;

        return true;
    }
    public bool Incluir(Dado novoValor)         // (bool) Inserir nó com Dado em ordem crescente
    {
        if (novoValor == null)
            return false;
        if (!Existe(novoValor, out int _))
        {
            if (EstaVazio)
            {
                IncluirNoInicio(novoValor);
            }
            else
            {
                if (EstaNoFim)
                {
                    IncluirAposFim(novoValor);
                }
                else if (EstaNoInicio)

                {
                    IncluirNoInicio(novoValor);
                }
                else
                {
                    NoDuplo<Dado> novoNo = new NoDuplo<Dado>(novoValor);

                    novoNo.Ant = atual.Ant;
                    novoNo.Prox = atual;
                    atual.Ant = novoNo;
                    novoNo.Ant.Prox = novoNo;
                    atual = novoNo;
                }
            }
            quantosNos++;
            return true;
        }
        return false;
    }
    public bool Incluir(Dado novoValor, int posicaoDeInclusao)  // inclui novo nó na posição indicada da lista
    {

        if (novoValor == null)
            return false;
        if (EstaVazio)
        {
            IncluirNoInicio(novoValor);
        }
        if (atual == null)
            return false;

        var colocar = new NoDuplo<Dado>(novoValor);
        if (posicaoDeInclusao >= 0)
        {
            //PosicionarEm(posicaoDeInclusao);
            colocar.Ant = atual;
            atual.Prox = colocar;
            atual = colocar.Prox;
            colocar.Ant = atual.Ant;
            atual.Ant = colocar;
        }
        quantosNos++;
        return true;
    }
    public Dado this[int indice]
    {
        get
        {
            PosicionarEm(indice);
            return DadoAtual();
        }
        set
        {
            PosicionarEm(indice);
            atual.Info = value;
        }
    }
    public Dado DadoAtual()  // retorna o dado atualmente visitado
    {
        if (atual != null)

            return atual.Info; // null.Info

        return default(Dado);
    }
    public void ExibirDados()   // lista os dados armazenados na lista em modo console
    {
        Console.Clear(); //Primeiro limpamos no conslole e posicionamos no primeiro 
        PosicionarNoPrimeiro();

        while (atual != null)
        {
            Console.WriteLine(atual.Info.ToString());
            atual = atual.Prox;
        }
    }
    public void ExibirDados(ListBox lista)  // lista os dados armazenados na lista no listbox passado como parâmetro
    {
        lista.Items.Clear();
        PosicionarNoPrimeiro();
        while (atual != null)
        {
            lista.Items.Add(atual.Info.ToString());
            atual = atual.Prox;
        }
    }
    public void ExibirDados(ComboBox lista) // lista os dados armazenados na lista no combobox passado como parâmetro
    {
        lista.Items.Clear();
        PosicionarNoPrimeiro();
        while (atual != null)
        {
            lista.Items.Add(atual.Info.ToString());
            atual = atual.Prox;
        }
    }
    public void ExibirDados(TextBox lista)
    {
        lista.Clear();
        PosicionarNoPrimeiro();
        while (atual != null)
        {
            lista.Text = atual.Info.ToString();
            atual = atual.Prox;
        }
    }
    public void Ordenar()
    {
        ListaDupla<Dado> ordenada = new ListaDupla<Dado>();

        PosicionarNoPrimeiro();

        while (!EstaNoFim)
        {
            ordenada.Incluir(DadoAtual());

            AvancarPosicao();
        }

        primeiro = ordenada.primeiro;
        ultimo = ordenada.ultimo;
    }

    
}