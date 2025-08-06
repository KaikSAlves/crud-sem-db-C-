namespace CRUDSemDB.util;

public abstract class CpfUtil
{
    public static int[] transformarCpfEmVetor(string cpf)
    {
        int[] cpfEmVetor = new int[11];
        
        cpf = cpf.Replace(".", "").Replace("-", "").Replace(" ", "");

        for (int i = 0; i < cpfEmVetor.Length; i++)
        {
            cpfEmVetor[i] = int.Parse(cpf[i].ToString());
        }
        
        return cpfEmVetor;
    }
}