using SF.Core;
using SF.Core.Interfaces;

namespace SF.UI;

public class Controller
{
    private static IForagerService _foragerService;
    private static IForageService _forageService;
    private static IItemService _itemService;
    private static IController _foragerController;
    private static IController _forageController;
    private static IController _itemController;
    
    public Controller(IForagerService foragerService, IForageService forageService, IItemService itemService)
    {
        _foragerService = foragerService;
        _forageService = forageService;
        _itemService = itemService;
        _itemController = new ItemController(_itemService);
        _forageController = new ForageController(_forageService);
        _itemController = new ItemController(_itemService);
    }
    public void Run()
    {
        var isRunning = true;
        
        while (isRunning)
        {
            switch ((MainMenuOption)View.GetMainMenuChoice())
            {
                case MainMenuOption.Forage:
                    ForageController.Run();
                    break;
                case MainMenuOption.Forager:
                    ForagerController.Run();
                    break;
                case MainMenuOption.Item:
                    ItemController.Run();
                    break;
                case MainMenuOption.Quit:
                    QuitSave();
                    isRunning = false;
                    break;
                default:
                    View.DisplayRed("Invalid menu option");
                    break;
            }
        }
    }

    private void QuitSave()
    {
        Result<string> ret;
        Console.ForegroundColor = ConsoleColor.Blue;
        bool save = View.GetYesOrNo("Quitting, would you like to save changes to drive? (Y/N): ");
        Console.ResetColor();   
        // if (save)
        // {
        //     ret = Service.SaveQuit();
        //     if (ret.Success)
        //         _ui.Error("Save Successful!");
        //     //_ui.Display(ret.Data.ToString());
        //     else
        //         _ui.Display(ret.Message);
        // }
    }
}