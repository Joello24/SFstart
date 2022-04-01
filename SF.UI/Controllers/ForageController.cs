using System.Security.Cryptography.X509Certificates;
using SF.Core.Interfaces;

namespace SF.UI;

public class ForageController : IController
{
    IForageService _forageService;
    public ForageController(IForageService forageService)
    {
        _forageService = forageService;
    }
    public static void Run()
    {
        var isRunning = true;

        while (isRunning)
        {
            switch ((ForageMenuOption)View.GetForageMenuChoice())
            {
                case ForageMenuOption.Add:
                    Add();
                    break;
                case ForageMenuOption.Remove:
                    Remove();
                    break;
                case ForageMenuOption.Update:
                    Update();
                    break;
                case ForageMenuOption.Get:
                    Get();
                    break;
                case ForageMenuOption.Return:
                    isRunning = false;
                    break;
                default:
                    View.DisplayRed("Invalid menu option");
                    break;
            }
        }
    }

    public static void Add()
    {
        View.Display("Add a forage");
    }

    public static void Remove()
    {
        View.Display("Remove a forage");
    }

    public static void Update()
    {
        View.Display("Update a forage");
    }

    public static void Get()
    {
        View.Display("Get a forage");
    }
}