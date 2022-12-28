using System;

namespace IJExit
{
    class Program
    {
        static void Main(string[] args)
        {
            string exitLoop = "";
            string isExit = "exit";
            Console.WriteLine("Для выхода из цикла введите exit");

            while (exitLoop != isExit)
            {
                exitLoop = Console.ReadLine();
            }
        }
    }
}
