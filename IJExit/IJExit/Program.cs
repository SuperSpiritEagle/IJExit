using System;

namespace IJExit
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            string isExit = "exit";
            Console.WriteLine($"Для выхода из цикла введите {isExit}");

            while (userInput!=isExit)
            {
                userInput = Console.ReadLine();
            }
        }
    }
}
