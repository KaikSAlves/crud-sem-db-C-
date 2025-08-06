using CRUDSemDB.util;

namespace CRUDSemDB.Application;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(VerificadorDeCpf.verificarCpf("123.456.789-09"));
    }
}