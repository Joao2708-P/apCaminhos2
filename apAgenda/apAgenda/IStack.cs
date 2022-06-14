public interface IStack<Dado>
{
  void Empilhar(Dado dado);   // empilha o objeto "dado" 
  Dado Desempilhar();         // remove e retorna o objeto do topo
  Dado OTopo();               // retorna o objeto do topo sem removê-lo
  int Tamanho { get; }        // informa a quantidade de itens empilhados
  bool EstaVazia { get; }     // informa se a pilha está ou não vazia  
}