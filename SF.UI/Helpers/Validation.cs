using SF.UI;

namespace WADemo.UI;

public static class Validation
{
  private static void Prompt2Continue()
  {
    Console.WriteLine("=====================================");
    Console.WriteLine("Press any key to continue...");

    Console.ReadLine();
  }

  internal static string PromptRequired(string message)
  {
    var res = PromptUser(message);
    while (string.IsNullOrEmpty(res))
    {
      Console.WriteLine("Input required❗");
      res = PromptUser(message);
    }

    return res;
  }

  internal static string PromptUser(string message)
  {
    Console.Write(message);
    Console.ForegroundColor = ConsoleColor.Green;
    View.Display("~ ");
    
    return Console.ReadLine() ?? string.Empty;
  }

  internal static decimal PromptUser4Num(string message)
  {
    decimal result;
    while (!decimal.TryParse(PromptUser(message), out result))
    {
      Console.ResetColor();
      PromptUser("Invalid Input. Press Enter to Continue");
    }
    Console.ResetColor();
    return result;
  }

  internal static decimal PromptUser4Num(string message, decimal min, decimal max)
  {
    decimal result;
    while (!decimal.TryParse(PromptUser(message), out result) || result < min || result > max)
    {
      Console.ResetColor();
      PromptUser($@"Invalid Input, must be between {min} and {max}
Press Enter to Continue");
    }
    Console.ResetColor();
    return result;
  }

  // default here means it takes the absolute minimum value for a DateOnly
  internal static DateOnly PromptUser4Date(string message, DateOnly max)
  {
    DateOnly result;
    while (!(DateOnly.TryParse(PromptUser(message), out result)) || (result > max))
    {
      Console.ResetColor();
      PromptUser($"Invalid Input, must be before {max}.");
      Prompt2Continue();
    }
    Console.ResetColor();
    return result;
  }
}
