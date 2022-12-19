using System;

namespace IJExit
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string exit;
            bool isExit = true;
            Console.WriteLine("Для выхода из программы введите exit");

            while (isExit)
            {
                exit = Convert.ToString(Console.ReadLine());
                if (exit == "exit")
                {
                    isExit = false;
                }
                Console.WriteLine(count++);
            }
        }
    }
}
