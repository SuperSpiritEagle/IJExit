using System;

namespace IJExit
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Для выхода из программы введите exit");

            while (true)
            {
                string exit = Convert.ToString(Console.ReadLine());
                if (exit == "exit")
                {
                    break;
                }
                Console.WriteLine(count++);
            }
        }
    }
}
