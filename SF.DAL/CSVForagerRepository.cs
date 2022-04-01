using SF.Core;
using SF.Core.Interfaces;

namespace SF.DAL;

public class CSVForagerRepository : IForagerRepository
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

    public Result Add(Forager forager)
    {
        throw new NotImplementedException();
    }

    public Result Update(Forager forager)
    {
        throw new NotImplementedException();
    }
}