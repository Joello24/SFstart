using Ninject;
using SF.BLL;
using SF.Core;
using SF.Core.Interfaces;
using SF.DAL;
using SF.UI;

namespace SF.App;

public static class NinjectContainer
{
    public static StandardKernel Kernel { get; private set; }
    public static void Configure(string foragerFile, string forageFile, string itemFile, string logFile, LoggingMode logMode) 
    {
        Kernel = new StandardKernel();
        
        if (logMode == LoggingMode.Console)
        {
            Kernel.Bind<ILogger>().To<ConsoleLogger>();
        }
        else if(logMode == LoggingMode.File)
        {
            Kernel.Bind<ILogger>().To<FileLogger>().WithConstructorArgument("filePath", logFile);  
        }
        else
        {
            Kernel.Bind<ILogger>().To<NullLogger>();            
        }
        // APPMODE GOES HERE
        
        // REPOSITORIES GO HERE
        Kernel.Bind<IForageRepository>().To<CSVForageRepository>().WithConstructorArgument(forageFile);
        Kernel.Bind<IForagerRepository>().To<CSVForagerRepository>().WithConstructorArgument(foragerFile);
        Kernel.Bind<IItemRepository>().To<CSVItemRepository>().WithConstructorArgument(itemFile);
        
        // SERVICES GO HERE
        Kernel.Bind<IForagerService>().To<ForagerService>();
        Kernel.Bind<IForageService>().To<ForageService>();
        Kernel.Bind<IItemService>().To<ItemService>();
        
        // CONTROLLERS GO HERE
        Kernel.Bind<ItemController>().To<ItemController>();
        Kernel.Bind<ForageController>().To<ForageController>();
        Kernel.Bind<ForagerController>().To<ForagerController>();
    }
}