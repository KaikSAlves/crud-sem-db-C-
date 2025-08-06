namespace CRUDSemDB.util;

public class GeradorDeCpf : CpfUtil
{
    public static string gerarCpf()
    {
        Random rand = new Random();

        
        do
        {
            long cpf = rand.NextInt64(00000000000, 99999999999);
            Console.WriteLine(cpf);
        } while (true);
        
    }
}