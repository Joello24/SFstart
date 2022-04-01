using System.ComponentModel.Design;
using SF.Core;
using SF.Core;
using SF.Core.Interfaces;

namespace SF.DAL;

public class CSVItemRepository : IItemRepository
{
    private ILogger _logger;
    private string _filePath;
    private List<Item> _items;
    public CSVItemRepository(ILogger logger, string filePath)
    {
        _logger = logger;
        _filePath = filePath;
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
        Result<Item> result = new Result<Item>();
        _items.Add(item);
        result.Success = true;
        result.Messages.Add("Item added");
        Console.WriteLine("Item added");
        return result;
    }
    public Result<Item> Edit(Item item)
    {
        throw new NotImplementedException();
    }
}