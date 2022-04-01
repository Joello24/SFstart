using System;

namespace SF.App;

public static class Program
{
    private static void Main()
    {
        Startup.Run();
    }
}




/*
 * NOTES:
 * Sustainable foraging project.
 * SF is an application that tracks foragers, foreagable items, and successful forages.
 *
 * Requirements:
 * - Item
 *    - Name is required & unique
 *    - Category is required
 *    - Dollars/kg is required
 *    - Dollars/Kg must be between $0(inedible, poisonous) and $7500
 *    - Item ID is a system generated unique sequential integer identifier
 * - Forager
 *   - First and last name are required
 *   - State is required
 *   - The combination of first, last name, and state must be unique
 *   - Forager ID is a system generated unique sequential integer identifier
 * - Forage
 *  - Item is required and must exist
 *  - Forager is required and must exist
 *  - Date is required and must be in the past
 *  - KiloGrams is required and must be between 0 and 250
 *  - The combination of item, forager, and date must be unique
 *  - Forage ID is a system generated unique sequential integer identifier
 *
 *      *** DATA MUST NOT CONTAIN COMMAS FOR CSV FILE TO BE READ CORRECTLY ***
 *  Data Storage:
 * - Each Model (Item, Forager, Forage) is stored in a CSV file with header row.
 * - file names are items.csv, foragers.csv, forages.csv
 *
 * TRICKY PART - Reasemble the Item and Forager info from the id's in the forages.csv file.
 *
 * 
 */