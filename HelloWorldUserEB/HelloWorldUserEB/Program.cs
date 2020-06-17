using System;

namespace HelloWorldUserEB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Refer to example on https://docs.microsoft.com/en-us/dotnet/api/system.console.readkey?view=netcore-3.1
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}
