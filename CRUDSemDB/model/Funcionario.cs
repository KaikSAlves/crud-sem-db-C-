namespace CRUDSemDB.model;

public class Funcionario
{
    private int id { get; set; }
    private string nome { get; set; }
    private string cpf { get; set; }
    private string cargo { get; set; }
    private double salario { get; set; }
    
    public Funcionario(int id, string nome, string cpf, string cargo, double salario)
    {
        this.id = id;
        this.nome = nome;
        this.cpf = cpf;
        this.cargo = cargo;
        this.salario = salario;
    }
    
    public Funcionario(){}
    
    
}