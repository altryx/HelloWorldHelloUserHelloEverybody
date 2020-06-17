using System;

namespace HelloWorldUserEB
{
    public class Program
    {
        public static ConsoleKey keyPressed;

        public static void Main()
        {
            Console.WriteLine("Hello World!");

            while (keyPressed != ConsoleKey.Enter) 
            {
                Console.WriteLine("\nPress the Enter key to end this program...");
                // Citation:
                // Refer to example on https://docs.microsoft.com/en-us/dotnet/api/system.console.readkey?view=netcore-3.1 (ReadKey() method)
                // and https://docs.microsoft.com/en-us/dotnet/api/system.consolekeyinfo.key?view=netcore-3.1#System_ConsoleKeyInfo_Key (ConsoleKeyInfo.Key property) 
                // Reads the keypress by the user (using the ReadKey() method) and saves the ConsoleKeyInfo object's Key property value into the variable keyPressed (var type ConsoleKey)
                keyPressed = Console.ReadKey().Key;
            }
        }
    }
}
