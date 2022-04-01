using SF.Core;
using SF.Core.Interfaces;

namespace SF.BLL;

public class ForagerService : IForagerService
{
    public Result<Forager> Get(int id)
    {
        throw new NotImplementedException();
    }

    public Result<List<Forager>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Result<List<Forager>> GetByState(string state)
    {
        throw new NotImplementedException();
    }

    public Result<Forager> Add(Forager forage)
    {
        throw new NotImplementedException();
    }

    public Result Update(Forager forager)
    {
        throw new NotImplementedException();
    }

    public Result<List<TopForagerListItem>> TopForagersReport()
    {
        throw new NotImplementedException();
    }
}