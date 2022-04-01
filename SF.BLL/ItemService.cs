using System.ComponentModel.Design;
using SF.Core;
using SF.Core.Interfaces;

namespace SF.BLL;

public class ItemService : IItemService
{
    private static IItemRepository _itemRepository;

    public ItemService(IItemRepository itemRepository)
    {
        _itemRepository = itemRepository;
    }
    
    public Result<List<Item>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Result<Item> Get(int id)
    {
        throw new NotImplementedException();
    }

    public Result<Item> Add(Item item)
    {
        _itemRepository.Add(item);
        return new Result<Item>()
        {
            Success = true,
            Messages = new List<string>() {"Item Added"},
        };
    }

    public Result<Item> Edit(Item item)
    {
        throw new NotImplementedException();
    }

    public Result<List<CategoryValueListItem>> GetCategoryValueReport()
    {
        throw new NotImplementedException();
    }
}