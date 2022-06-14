using System;
using System.IO;

namespace apCaminhos
{
  class Cidade : IComparable<Cidade>, IRegistro<Cidade>
  {
    const int tamCodigo = 3,
              tamNome = 15,
              tamX = 7,
              tamY = 7;

    const int iniCodigo = 0,
              iniNome = iniCodigo + tamCodigo,
              iniX = iniNome + tamNome,
              iniY = iniX + tamX;

    string codigo, nome;
    decimal x, y;

    public string Codigo { get => codigo; set => codigo = value.PadLeft(tamCodigo,'0').Substring(0,tamCodigo); }
    public string Nome   { get => nome; set => nome = value.PadRight(tamCodigo, ' ').Substring(0, tamNome); }
    public decimal X         { get => x; set => x = value; }
    public decimal Y         { get => y; set => y = value; }

    public Cidade(string codigo, string nome, int x, int y)
    {
        Codigo = codigo;
        Nome = nome;
        X = x;
        Y = y;
    }

    public int CompareTo(Cidade outro)
    {
        return codigo.ToUpperInvariant().CompareTo(outro.codigo.ToUpperInvariant());
    }

     public Cidade()
     { }
    public Cidade LerRegistro(StreamReader arquivo)
    {
      if (arquivo != null) // arquivo aberto?
      {
        string linha = arquivo.ReadLine();
        Codigo = linha.Substring(iniCodigo, tamCodigo);
        Nome = linha.Substring(iniNome, tamNome);
        X = decimal.Parse(linha.Substring(iniX, tamX));
        Y = decimal.Parse(linha.Substring(iniY));
        return this; // retorna o próprio objeto Contato, com os dados
      }
      return default(Cidade);
    }

    public void GravarRegistro(StreamWriter arq)
    {
      if (arq != null)  // arquivo de saída aberto?
      {
        arq.WriteLine(ParaArquivo());
      }
    }
    public string ParaArquivo()
    {
      return Codigo + Nome + X.ToString() + Y.ToString();
    }

    public override string ToString()
    {
      return Codigo + " " + Nome + " " + X.ToString().PadLeft(tamX,' ') + Y.ToString().PadLeft(tamY, ' ');
    }
  }
}
