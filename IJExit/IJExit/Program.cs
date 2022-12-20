using System;

namespace IJExit
{
    class Program
    {
        static void Main(string[] args)
        {
            int exitLoop = 0;
            bool isExit = true;

            while (isExit)
            {
                if (exitLoop == 100)
                {
                    isExit = false;
                }
                Console.WriteLine(exitLoop++);
            }

        }
    }
}
