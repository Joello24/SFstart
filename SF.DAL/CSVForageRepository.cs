using SF.Core;
using SF.Core.Interfaces;

namespace SF.DAL;

public class CSVForageRepository : IForageRepository
{
    
    public Result<List<Forage>> GetByDate(DateTime date)
    {
        throw new NotImplementedException();
    }

    public Result<Forage> Add(Forage forage)
    {
        throw new NotImplementedException();
    }

    public Result Update(Forage forage)
    {
        throw new NotImplementedException();
    }

    public Result Remove(Forage forage)
    {
        throw new NotImplementedException();
    }
}