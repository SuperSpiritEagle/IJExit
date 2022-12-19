using System;

namespace IJExit
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string exitLoop;
            bool isExit = true;
            Console.WriteLine("Для выхода из программы введите exit");
            while (isExit)
            {
                exitLoop = Console.ReadLine();
                if (exitLoop == "exit")
                {
                    isExit = false;
                }
                Console.WriteLine(count++);
            }
        }
    }
}
