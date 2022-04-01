namespace SF.Core.Interfaces;

public interface IForageRepository
{
    Result<List<Forage>> GetByDate(DateTime date);
    Result<Forage> Add(Forage forage);
    Result Update(Forage forage);
    Result Remove(Forage forage);
}