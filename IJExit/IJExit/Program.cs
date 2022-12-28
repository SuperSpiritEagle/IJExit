using System;

namespace IJExit
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            string exitLoop = "exit";
            Console.WriteLine($"Для выхода из цикла введите {exitLoop}");

            while (userInput!=exitLoop)
            {
                userInput = Console.ReadLine();
            }
        }
    }
}
