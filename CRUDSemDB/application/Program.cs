using CRUDSemDB.util;

namespace CRUDSemDB.Application;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write(VerificadorDeCpf.verificarCpf("462.180.658-00"));
    }
}