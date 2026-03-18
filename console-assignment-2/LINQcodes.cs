using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp2
{
    internal static class LINQcodes
    {
        public static void RunAllExamples()
        {
            Filtering();
            Projection();
            Sorting();
            Aggregation();
            Partitioning();
            ElementOperators();
            SetOperators();
            Grouping();
            JoinExample();
            Conversion();
        }

        static void Filtering()
        {
            Console.WriteLine("\nFiltering");
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            var even = numbers.Where(n => n % 2 == 0);

            foreach (var n in even)
                Console.WriteLine(n);
        }

        static void Projection()
        {
            Console.WriteLine("\nProjection");
            int[] numbers = { 1, 2, 3 };
            var squares = numbers.Select(n => n * n);

            foreach (var n in squares)
                Console.WriteLine(n);

            string[] words = { "hello", "world" };
            var chars = words.SelectMany(w => w.ToCharArray());

            foreach (var c in chars)
                Console.Write(c + " ");
            Console.WriteLine();
        }

        static void Sorting()
        {
            Console.WriteLine("\nSorting");
            int[] nums = { 5, 1, 4, 2 };

            var asc = nums.OrderBy(n => n);
            var desc = nums.OrderByDescending(n => n);

            Console.WriteLine("Ascending: " + string.Join(", ", asc));
            Console.WriteLine("Descending: " + string.Join(", ", desc));
        }

        static void Aggregation()
        {
            Console.WriteLine("\nAggregation");
            int[] numbers = { 1, 2, 3, 4 };

            Console.WriteLine("Count: " + numbers.Count());
            Console.WriteLine("Sum: " + numbers.Sum());
            Console.WriteLine("Average: " + numbers.Average());
            Console.WriteLine("Min: " + numbers.Min());
            Console.WriteLine("Max: " + numbers.Max());
            Console.WriteLine("Any Even: " + numbers.Any(n => n % 2 == 0));
            Console.WriteLine("All Positive: " + numbers.All(n => n > 0));
        }

        static void Partitioning()
        {
            Console.WriteLine("\nPartitioning");
            int[] numbers = { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine("Take 2: " + string.Join(", ", numbers.Take(2)));
            Console.WriteLine("Skip 2: " + string.Join(", ", numbers.Skip(2)));
            Console.WriteLine("TakeWhile <4: " + string.Join(", ", numbers.TakeWhile(n => n < 4)));
            Console.WriteLine("SkipWhile <4: " + string.Join(", ", numbers.SkipWhile(n => n < 4)));
        }

        static void ElementOperators()
        {
            Console.WriteLine("\nElement Operators");
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine("First: " + numbers.First());
            Console.WriteLine("FirstOrDefault Even: " + numbers.FirstOrDefault(n => n % 2 == 0));
            Console.WriteLine("Last: " + numbers.Last());
            Console.WriteLine("ElementAt(2): " + numbers.ElementAt(2));
        }

        static void SetOperators()
        {
            Console.WriteLine("\nSet Operators");
            int[] set1 = { 1, 2, 3 };
            int[] set2 = { 3, 4, 5 };

            Console.WriteLine("Union: " + string.Join(", ", set1.Union(set2)));
            Console.WriteLine("Intersect: " + string.Join(", ", set1.Intersect(set2)));
            Console.WriteLine("Except: " + string.Join(", ", set1.Except(set2)));
        }

        static void Grouping()
        {
            Console.WriteLine("\nGrouping");

            var people = new[]
            {
                new { Name = "Alice", Age = 25 },
                new { Name = "Bob", Age = 30 },
                new { Name = "Charlie", Age = 25 }
            };

            var grouped = people.GroupBy(p => p.Age);

            foreach (var group in grouped)
            {
                Console.WriteLine($"Age: {group.Key}");
                foreach (var person in group)
                    Console.WriteLine("  " + person.Name);
            }
        }

        static void JoinExample()
        {
            Console.WriteLine("\nJoin");

            var employees = new[]
            {
                new { Id = 1, DeptId = 1, Name = "Alice" },
                new { Id = 2, DeptId = 2, Name = "Bob" }
            };

            var departments = new[]
            {
                new { Id = 1, Department = "HR" },
                new { Id = 2, Department = "IT" }
            };

            var result = employees.Join(
                departments,
                emp => emp.DeptId,
                dept => dept.Id,
                (emp, dept) => new { emp.Name, dept.Department });

            foreach (var r in result)
                Console.WriteLine($"{r.Name} - {r.Department}");
        }

        static void Conversion()
        {
            Console.WriteLine("\nConversion");
            int[] numbers = { 1, 2, 3 };

            List<int> list = numbers.ToList();
            int[] array = list.ToArray();

            Console.WriteLine("ToList Count: " + list.Count);
            Console.WriteLine("ToArray Length: " + array.Length);
        }
    }
}
