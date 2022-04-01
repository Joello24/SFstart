namespace SF.Core.Interfaces;

public interface IForagerService
{
    Result<Forager> Get(int id);
    Result<List<Forager>> GetAll();
    Result<List<Forager>> GetByState(string state);
    Result<Forager> Add(Forager forage);
    Result Update(Forager forager);

    Result<List<TopForagerListItem>> TopForagersReport();

}