using System;

namespace IJExit
{
    class Program
    {
        static void Main(string[] args)
        {
            string exitLoop = "";
            int count = 0;
            Console.WriteLine("Для выхода из цикла введите exit");
            while (exitLoop != "exit")
            {
                exitLoop = Console.ReadLine();
                Console.WriteLine(count++);
            }
        }
    }
}
