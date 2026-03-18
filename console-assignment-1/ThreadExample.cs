using System;

namespace ConsoleApp1
{
    internal class ThreadingExample
    {
        public void Even()
        {
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("Even : " + i);
            }
        }

        public void Odd()
        {
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine("Odd : " + i);
            }
        }
    }
}
