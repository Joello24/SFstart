using SF.Core;
using WADemo.UI;

namespace SF.UI;

public static class View
{
  public static int GetLoggingMode()
  {
    return (int)Validation.PromptUser4Num(@"What logging mode do you want to use?
1. No logging
2. Log to console
3. Log to file
", 1, 3);
  }

  internal static bool Confirm(string message = "Are you sure?")
  {
    Console.Write(message + " (y/n)");
    var input = Console.ReadLine() ?? string.Empty;

    return input.ToLower().StartsWith("y");
  }

  internal static void Display(string message)
  {
    Console.Write(message);
  }
  internal static void DisplayLine(string message)
  {
    Console.WriteLine(message);
  }
  internal static void DisplayYellow(string message)
  {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(message);
    Console.ResetColor();
  }
  internal static void DisplayRed(string message)
  {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message);
    Console.ResetColor();
  }
  internal static void DisplayBlue(string message)
  {
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(message);
    Console.ResetColor();
  }

  public static void DisplayHeader(string header)
  {
    Display(header);
    Display("------------------------------------------");
  }

  internal static void DisplayItem(Item item)
  {
    DisplayYellow(@$"Name: {item.Name}
Category: [{item.Category}] 
$/Kg: [{item.DollarPerKilogram}]
ID: [{item.Id}%]
");
  }

  internal static void DisplayItems(List<Item> items)
  {
    DisplayHeader("Weather Records");
    foreach (var item in items)
    {
      DisplayItem(item);
      Console.WriteLine("--------------");
    }
  }

  public static int GetApplicationMode()
  {
    DisplayHeader("Welcome to the Weather Almanac. Please select an option:");
    return (int)Validation.PromptUser4Num(@"What mode would you like to run in?
1. Live
2. Test
Select mode: 
", 1, 2);
  }

  internal static int GetMainMenuChoice()
  {
    DisplayYellow("Main Menu");
    

    return (int)Validation.PromptUser4Num(@"

1. Forage
2. Forager
3. Item
0. Exit
Enter Choice: 
", 0, 3);
  }
  
  internal static int GetForageMenuChoice()
  {
    DisplayYellow("Forage Menu");
    

    return (int)Validation.PromptUser4Num(@"
1. Add
2. Remove
3. Update
4. Get
0. <-< Return
Enter Choice: 
", 0, 4);
  }
  internal static int GetForagerMenuChoice()
  {
    DisplayYellow("Forager Menu");
    

    return (int)Validation.PromptUser4Num(@"
1. Add
2. Remove
3. Update
4. Get All
5. Get By State
6. Get Foragers Report
0. <-< Return
Enter Choice: 
", 0, 6);
  }
  internal static int GetItemMenuChoice()
  {
    DisplayYellow("Item Menu");
    

    return (int)Validation.PromptUser4Num(@"
1. Add
2. Update
3. Get All
4. Get by ID
0. <-< Return
Enter Choice: 
", 0, 4);
  }
  // TODO: Consider reusing this method to also get date ranges for start and end dates
  internal static DateOnly GetForageDate(string message = "Enter Forage Date: ")
  {
    return Validation.PromptUser4Date(message, DateOnly.FromDateTime(DateTime.Today));
  }

  internal static Forage AddForage()
  {
    var date = Validation.PromptUser4Date("Date (MM/dd/yyyy): ", DateOnly.FromDateTime(DateTime.Today));
    var foragerId = Validation.PromptRequired("Forager ID: ");
    var itemId = Validation.PromptRequired("Item ID: ");
    var kilograms = Validation.PromptUser4Num("Kilograms: ", 0, 250);

    return new Forage()
    {
      Date = date,
      ForagerId = foragerId,
      ItemId = itemId,
      Kilograms = kilograms
    };
  }
  public static bool GetYesOrNo(string message)
  {
    while (true)
    {
      Console.Write(message);
      Console.ForegroundColor= ConsoleColor.Green;
      Console.Write("~ ");
      string sender = Console.ReadLine();
      if (sender.ToUpper() == "Y")
      {
        Console.ResetColor();
        return true;
      }
      else if (sender.ToUpper() == "N")
      {
        Console.ResetColor();
        return false;
      }
    }
  }

  // internal static WeatherRecord UpdateWeatherRecord(WeatherRecord originalRecord)
  // {
  //   var updatedRecord = new WeatherRecord {Date = originalRecord.Date};
  //
  //   var newHigh = Validation.PromptUser($"High {originalRecord.HighTemp} (F): ");
  //   if (string.IsNullOrEmpty(newHigh)) updatedRecord.HighTemp = originalRecord.HighTemp;
  //   else
  //   {
  //     if (!int.TryParse(newHigh, out var newHighTemp))
  //     {
  //       updatedRecord.HighTemp = originalRecord.HighTemp;
  //     }
  //
  //     updatedRecord.HighTemp = newHighTemp;
  //   }
  //
  //   var newLow = Validation.PromptUser($"Low {originalRecord.LowTemp} (F): ");
  //   if (string.IsNullOrEmpty(newLow)) updatedRecord.LowTemp = originalRecord.LowTemp;
  //   else
  //   {
  //     if (!int.TryParse(newLow, out var newLowTemp))
  //     {
  //       updatedRecord.LowTemp = originalRecord.LowTemp;
  //     }
  //
  //     updatedRecord.LowTemp = newLowTemp;
  //   }
  //
  //   var newHumidity = Validation.PromptUser($"Humidity {originalRecord.Humidity} (%): ");
  //   if (string.IsNullOrEmpty(newHumidity)) updatedRecord.Humidity = originalRecord.Humidity;
  //   else
  //   {
  //     if (!decimal.TryParse(newHumidity, out var newHumidityTemp))
  //     {
  //       updatedRecord.Humidity = originalRecord.Humidity;
  //     }
  //
  //     updatedRecord.Humidity = newHumidityTemp;
  //   }
  //
  //   Display("Old Description: " + originalRecord.Description);
  //   var newDescription = Validation.PromptUser("New Description: ");
  //   updatedRecord.Description = string.IsNullOrEmpty(newDescription) ? originalRecord.Description : newDescription;
  //
  //   return updatedRecord;
  // }
}
