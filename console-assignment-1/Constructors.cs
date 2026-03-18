using System;
using System.Security.Principal;

namespace ConsoleApp1
{
    internal class Constructors
    {
        // private fields
        private int length;
        private int breadth=0;

        // Constructor for Square (one integer)
        public Constructors(int side)
        {
            length = side;
        }

        // Constructor for Rectangle (two integers)
        public Constructors(int l, int b)
        {
            length = l;
            breadth = b;
        }

        // Method to calculate area
        public int CalculateArea()
        {
            if (breadth == 0)
            {
                return length * length;
            }
            else
            {
                return length * breadth;
            }
               
        }
    }
}
