using System;

namespace ConsoleApp1
{
    internal class DelegateExample
    {
        public int Double(int x)
        {
            return x + x;
        }

        public int Square(int x)
        {
            return x * x;
        }

        public void Cube(int x)
        {
            Console.WriteLine("Cube : " + (x * x * x));
        }
    }
}
