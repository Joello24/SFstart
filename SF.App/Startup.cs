using Ninject;
using System;
using SF.Core;
using SF.UI;
using WADemo.UI;

namespace SF.App;

public class Startup
{
    public static void Run()
    {
        // Update this as needed to match your project
        // ⚠️ Can't use var with const - have to specify type explicitly
        const string dataDir = "../data/";
        const string foragerFile = "forager.csv" + dataDir;
        const string forageFile = "forage.csv" + dataDir;
        const string itemFile = "items.csv" + dataDir;
        const string logFile = "log.csv" + dataDir;
        
        View.DisplayHeader("Welcome to Weather Almanac");
        
        LoggingMode logMode = (LoggingMode)View.GetLoggingMode() switch
        {
            LoggingMode.None => LoggingMode.None,
            LoggingMode.Console => LoggingMode.Console,
            LoggingMode.File => LoggingMode.File,
            _ => throw new ArgumentOutOfRangeException()
        };
        
        // ApplicationMode mode = (ApplicationMode)View.GetApplicationMode() switch
        // {
        //     ApplicationMode.Live => ApplicationMode.Live,
        //     ApplicationMode.Test => ApplicationMode.Test,
        //     _ => throw new ArgumentOutOfRangeException()
        // };
    
        NinjectContainer.Configure(foragerFile, forageFile, itemFile, logFile, logMode);
        var controller = NinjectContainer.Kernel.Get<Controller>();
        controller.Run();
    }
}

