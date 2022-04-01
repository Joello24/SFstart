namespace SF.Core.Interfaces;

public interface IForageService
{
    Result<List<Forage>> GetByDate(DateTime date);
    Result<Forage> Add(Forage forage);
    Result Update(Forage forage);
    Result Remove(Forage forage);
}