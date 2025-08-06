namespace CRUDSemDB.util;

public class VerificadorDeCpf : CpfUtil
{
    public static bool verificarCpf(string cpf)
    {
        int[] cpfEmVetor = CpfUtil.transformarCpfEmVetor(cpf);
        int primeiroDigitoVerificador = calcularPrimeiroDigitoVerificador(cpfEmVetor);
        int segundoDigitoVerificador = calcularSegundoDigitoVerificador(cpfEmVetor, primeiroDigitoVerificador);

        if (cpfEmVetor[9] == primeiroDigitoVerificador)
        {
            
            return cpfEmVetor[10] == segundoDigitoVerificador;
        }

        return false;
    }
     
    public static bool verificarCpf(long cpf)
    {
        int[] cpfEmVetor = cpf.ToString().Select(c => int.Parse(c.ToString())).ToArray();
        int primeiroDigitoVerificador = calcularPrimeiroDigitoVerificador(cpfEmVetor);
        int segundoDigitoVerificador = calcularSegundoDigitoVerificador(cpfEmVetor, primeiroDigitoVerificador);

        if (cpfEmVetor[9] == primeiroDigitoVerificador)
        {
            
            return cpfEmVetor[10] == segundoDigitoVerificador;
        }

        return false;
    }

    private static int calcularPrimeiroDigitoVerificador(int[] cpf)
    {
        int sum = 0;
        
        for (int i = 0; i < 9; i++)
        {
            sum += cpf[i] * (i + 1);
        }

        sum %= 11;

        int result = sum == 10 ? 0 : sum;

        return result;
    }

    private static int calcularSegundoDigitoVerificador(int[] cpf, int primeiroDigitoVerificador)
    {
        int sum = 0;
        
        for (int i = 0; i < 9; i++)
        {
            sum += cpf[i] * i;
        }

        sum += primeiroDigitoVerificador * 9;
        
        sum %= 11;

        int result = sum == 10 ? 0 : sum;

        return result;
    }
}