using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp2
{
    internal class Arrays
    {
        public void PrintAllElements(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
        public int SumOfAllElements(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            return sum;
        }
        public double AvgOfElements(int[] arr)
        {
            int sum = SumOfAllElements(arr);
            return (double)sum / arr.Length;
        }
        public int LargestOfArray(int[] arr)
        {
            int max = 0;
            foreach(int i in arr)
            {
                if(max < i)
                {
                    max = i; 
                }
            }
            return max;
        }
        public int SmallestOfArray(int[] arr)
        {
            int min = int.MaxValue;
            foreach (int i in arr)
            {
                if (min > i)
                {
                    min = i;
                }
            }
            return min;
        }
        public void CountEvenOrOdd(int[] arr)
        {
            int even = 0;
            int odd = 0;
            foreach( int i in arr)
            {
                if (i % 2 == 0)
                {
                    even++;
                }
                else odd++;
            }
            Console.WriteLine($"Even: {even}, Odd: {odd}");
        }
        public int SearchElement(int[] arr, int target)
        {
            foreach(int i in arr)
            {
                if (i == target)
                    Console.WriteLine($"The index is: {i}");
            }
            return -1;
        }
        public int[] Copyarray(int[] arr)
        {
            int []copy= new int[arr.Length];
            for(int i=0; i < arr.Length;i++)
            {
                copy[i] = arr[i];
            }
            return copy;
        }
        public int[] ReverseArray(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            int temp = 0;
            while (left < right)
            {
                temp=arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;

            }
            return arr;
        }
        public void EvenIndexes(int [] arr)
        {
            for(int i=0; i < arr.Length; i = i + 2)
            {
                Console.WriteLine(arr[i]);
            }
        }

    }
}
