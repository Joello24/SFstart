namespace SF.Core.Interfaces;

public interface IItemService
{
    Result<List<Item>> GetAll();
    Result<Item> Get(int id);
    Result<Item> Add(Item item);
    Result<Item> Edit(Item item);
    //Result<Item> Delete(int id);
    // Maybe add this delete method
    Result<List<CategoryValueListItem>> GetCategoryValueReport();
}