namespace SF.Core.Interfaces;

public interface IForagerRepository
{
    Result<Forager> Get(int id);
    Result<List<Forager>> GetAll();
    Result<List<Forager>> GetByState(string state);
    Result Add(Forager forager);
    Result Update(Forager forager);
}