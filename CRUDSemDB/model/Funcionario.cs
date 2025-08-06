namespace CRUDSemDB.model;

public class Funcionario
{  
    private string nome { get; set; }
    private string cpf { get; set; }
    private string cargo { get; set; }
    private double salario { get; set; }
    
    public Funcionario(string nome, string cpf, string cargo, double salario)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.cargo = cargo;
        this.salario = salario;
    }
    
    public Funcionario(){}
    
    
}