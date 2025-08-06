namespace CRUDSemDB.util;

public class GeradorDeCpf : CpfUtil
{
    public static string gerarCpf()
    {
        long cpf;
        Random rand = new Random();
        
        while (true)
        {

            cpf = rand.NextInt64(000000000000, 99999999999);

            if (cpf.ToString().Length < 11) continue;
        
            Console.WriteLine(cpf);
            if (VerificadorDeCpf.verificarCpf(cpf))
            {
                break;
            }
        }

        return cpf.ToString();
    }
}