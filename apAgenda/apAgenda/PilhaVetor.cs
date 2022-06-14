using System;
using System.Collections.Generic;
public class PilhaVetor<Dado> : IStack<Dado>
{
  Dado[] p;
  int topo;
  public PilhaVetor(int maximo)
  {
    p = new Dado[maximo];
    topo = -1;          // pois acabamos de criar a pilha, VAZIA
  }

  public PilhaVetor() : this(500)
  { }

  public int Tamanho => topo + 1;
  public bool EstaVazia => topo < 0;
  public void Empilhar(Dado dado)
  {
    if (Tamanho == p.Length)
       throw new Exception("`Pilha cheia (Stack Overflow)!");
    
    topo = topo + 1;    // ou apenas
    p[topo] = dado;     // p[++topo] = dado;
  }
  public Dado Desempilhar()
  {
    if (EstaVazia)
       throw new Exception("Pilha vazia (Stack Underflow)!");
    Dado dadoEmpilhado = p[topo]; // ou
    topo = topo - 1;              // Dado dadoEmpilhado = p[topo--];
    return dadoEmpilhado;
  }
  public Dado OTopo()
  {
    if (EstaVazia)
      throw new Exception("Pilha vazia (Stack Underflow)!");

    Dado dadoEmpilhado = p[topo]; // copia o conteúdo da posição topo
                                  // e não altera o valor do índice topo
                                  // ou seja, mantém o estado da pilha,
                                  // apenas consultou o dado empilhado
                                  // no topo da pilha
    return dadoEmpilhado;
  }

  public List<Dado> DadosDaPilha()
  {
    List<Dado> lista = new List<Dado>();

    for (int indice = 0; indice <= topo; indice++)
      lista.Add(p[indice]);

    return lista;
  }
}