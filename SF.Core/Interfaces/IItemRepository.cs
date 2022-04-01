namespace SF.Core.Interfaces;

public interface IItemRepository
{
    Result<List<Item>> GetAll();
    Result<Item> Get(int id);
    Result<Item> Add(Item item);
    Result<Item> Edit(Item item);
}