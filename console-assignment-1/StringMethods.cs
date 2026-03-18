using System;

namespace ConsoleApp1
{
    internal class StringMethods
    {
        private string str;

        public StringMethods(string input)
        {
            str = input;
        }

        public void RunAllMethods()
        {
            Console.WriteLine("Original String: " + str);

            Console.WriteLine("Length: " + str.Length);
            Console.WriteLine("ToUpper: " + str.ToUpper());
            Console.WriteLine("ToLower: " + str.ToLower());
            Console.WriteLine("Substring(1,2): " + str.Substring(1, 2));
            Console.WriteLine("Contains 'lo': " + str.Contains("lo"));
            Console.WriteLine("IndexOf 'l': " + str.IndexOf("l"));
            Console.WriteLine("Replace l->x: " + str.Replace("l", "x"));
            Console.WriteLine("Trim: " + str.Trim());

            string[] arr = str.Split(',');
            Console.WriteLine("Split:");
            foreach (string s in arr)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("StartsWith He: " + str.StartsWith("He"));
            Console.WriteLine("EndsWith lo: " + str.EndsWith("lo"));
            Console.WriteLine("Join: " + string.Join(",", arr));

            string name = "John";
            int age = 25;
            Console.WriteLine(string.Format("My name is {0} and I am {1}", name, age));

            Console.WriteLine("PadLeft: " + str.PadLeft(10, '0'));
            Console.WriteLine("PadRight: " + str.PadRight(10, '0'));

            Console.WriteLine("Equals 'hello': " + str.Equals("hello"));

            Console.WriteLine("Char[1]: " + str[1]);

            Console.WriteLine("IsNullOrEmpty: " + string.IsNullOrEmpty(str));
            Console.WriteLine("IsNullOrWhiteSpace: " + string.IsNullOrWhiteSpace(str));

            Console.WriteLine("Compare apple/banana: " + string.Compare("apple", "banana"));
            Console.WriteLine("CompareTo banana: " + "apple".CompareTo("banana"));
            Console.WriteLine("CompareOrdinal: " + string.CompareOrdinal("apple", "banana"));

            Console.WriteLine("Remove(1,2): " + str.Remove(1, 2));
            Console.WriteLine("Insert: " + str.Insert(str.Length, " World"));
            Console.WriteLine("Concat: " + string.Concat(str, " Test"));

            object obj = str;
            Console.WriteLine("ToString: " + obj.ToString());

            Console.WriteLine("LastIndexOf l: " + str.LastIndexOf("l"));
            Console.WriteLine("IndexOfAny: " + str.IndexOfAny(new char[] { 'o', 'i' }));
            Console.WriteLine("LastIndexOfAny: " + str.LastIndexOfAny(new char[] { 'o', 'l' }));

            char[] chars = str.ToCharArray();
            Console.WriteLine("ToCharArray:");
            foreach (char c in chars)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Normalize: " + "e\u0301".Normalize());
        }
    }
}
