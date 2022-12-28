using System;

namespace IJExit
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            string output = "exit";
            Console.WriteLine($"Для выхода из цикла введите {output}");

            while (userInput!=output)
            {
                userInput = Console.ReadLine();
            }
        }
    }
}
