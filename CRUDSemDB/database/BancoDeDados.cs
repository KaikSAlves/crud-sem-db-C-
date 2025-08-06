using CRUDSemDB.model;

namespace CRUDSemDB.database;

public class BancoDeDados
{
    private static BancoDeDados bd;
    private static Dictionary<int, Funcionario> dados;

    private BancoDeDados()
    {
        dados = new  Dictionary<int, Funcionario>();
    }

    public static BancoDeDados getInstancia()
    {
        if (bd == null)
        {
            bd = new BancoDeDados();
        }

        return bd;
    }
}