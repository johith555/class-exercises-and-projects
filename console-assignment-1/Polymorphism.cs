using System;

namespace ConsoleApp1
{
    internal class Polymorphism
    {
        private int number;

        public Polymorphism(int age)
        {
            number = age;
        }

        public void AgeCalculator()
        {
            if (number > 0 && number <= 15)
            {
                Console.WriteLine("Teenager");
            }
            else if (number > 15 && number <= 25)
            {
                Console.WriteLine("Adult");
            }
            else if (number > 25 && number <= 40)
            {
                Console.WriteLine("Middle Aged");
            }
            else
            {
                Console.WriteLine("Senior");
            }
        }
    }
}
