using SF.Core;
using SF.Core.Interfaces;

namespace SF.UI;

public class ItemController : IController
{
    private static IItemService _service;
    public ItemController(IItemService service)
    {
        _service = service;
    }
    public static void Run()
    {
        var isRunning = true;
        
        while (isRunning)
        {
            switch ((ItemMenuOption)View.GetItemMenuChoice())
            {
                case ItemMenuOption.Add:
                    Add();
                    break;
                case ItemMenuOption.Edit:
                    Update();
                    break;
                case ItemMenuOption.GetAll:
                    GetAll();
                    break;
                case ItemMenuOption.Get:
                    Get();
                    break;
                case ItemMenuOption.GetCategoryValueReport:
                    GetCategoryValueReport();
                    break;
                case ItemMenuOption.Return:
                    isRunning = false;
                    break;
                default:
                    View.DisplayRed("Invalid menu option");
                    break;
            }
        }
    }
    private static void GetCategoryValueReport()
    {
        View.Display("Get categoryvaluereport");
    }
    private static void Get()
    {
        View.Display("Get item");
    }
    private static void GetAll()
    {
        View.Display("Get all items");
    }
    private static void Update()
    {
        View.Display("Update item");
    }
    private static void Add()
    {
        Item i = new Item();
        Result<Item> result = new Result<Item>();
        result = _service.Add(i);
        View.DisplayRed(result.Messages[0]);
    }
}