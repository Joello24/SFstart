using SF.Core.Interfaces;

namespace SF.UI;

public class ForagerController : IController
{
    IForagerService _foragerService;
    public ForagerController(IForagerService foragerService)
    {
        _foragerService = foragerService;
    }
    public static void Run()
    {
        var isRunning = true;
        while (isRunning)
        {
            switch ((ForagerMenuOption)View.GetForagerMenuChoice())
            {
                case ForagerMenuOption.Add:
                    Add();
                    break;
                case ForagerMenuOption.Remove:
                    Remove();
                    break;
                case ForagerMenuOption.Update:
                    Update();
                    break;
                case ForagerMenuOption.GetAll:
                    GetAll();
                    break;
                case ForagerMenuOption.GetByState:
                    GetByState();
                    break;
                case ForagerMenuOption.GetForagersReport:
                    GetForagersReport();
                    break;
                case ForagerMenuOption.Return:
                    isRunning = false;
                    break;
                default:
                    View.DisplayRed("Invalid menu option");
                    break;
            }
        }
    }

    private static void GetForagersReport()
    {
        View.Display("Get foragers report");
    }
    private static void GetByState()
    {
        View.Display("Get foragers by state");
    }
    private static void GetAll()
    {
        View.Display("Get all forager");
    }
    public static void Add()
    {
        View.Display("Add a forager");
    }
    public static void Remove()
    {
        View.Display("Remove a forager");
    }
    public static void Update()
    {
        View.Display("Update a forager");
    }
    public static void Get()
    {
        View.Display("Get a forager");
    }
}
