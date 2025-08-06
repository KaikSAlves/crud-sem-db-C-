using CRUDSemDB.model;

namespace CRUDSemDB.repository;

public interface FuncionarioRepository
{
    public int create(Funcionario funcionario);
    public Funcionario findById(int id);
    public List<Funcionario> getAll();
    public Funcionario update(int id, Funcionario funcionarioAtualizado);
    public void deleteById(int id);
}