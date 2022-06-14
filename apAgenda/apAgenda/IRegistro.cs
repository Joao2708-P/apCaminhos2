using System.IO;

public interface IRegistro<Dado>
{
    Dado LerRegistro(StreamReader arquivo);
    string ParaArquivo();
    void GravarRegistro(StreamWriter arquivo);
}