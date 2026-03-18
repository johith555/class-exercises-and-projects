using ConsoleApp3.CRUD;
using ConsoleApp3.Events;
using ConsoleApp3.Models;
using ConsoleApp3.Subscribers;
using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {
            //ProductCrud pc = new ProductCrud();

            //while (true)
            //{
            //    Console.WriteLine("\n1.Add  2.Update  3.Delete  4.Fetch  5.Exit");
            //    Console.Write("Choose: ");

            //    int choice = int.Parse(Console.ReadLine());

            //    switch (choice)
            //    {
            //        case 1:
            //            Product p = new Product();

            //            Console.Write("Name: ");
            //            p.Name = Console.ReadLine();

            //            Console.Write("Category Id: ");
            //            p.CategId = int.Parse(Console.ReadLine());

            //            Console.WriteLine(pc.AddProduct(p));
            //            break;

            //        case 2:
            //            Product up = new Product();

            //            Console.Write("Id: ");
            //            up.Id = int.Parse(Console.ReadLine());

            //            Console.Write("New Name: ");
            //            up.Name = Console.ReadLine();

            //            Console.Write("New Category Id: ");
            //            up.CategId = int.Parse(Console.ReadLine());

            //            Console.WriteLine(pc.UpdateProduct(up));
            //            break;

            //        case 3:
            //            Console.Write("Enter Id: ");
            //            int id = int.Parse(Console.ReadLine());

            //            Console.WriteLine(pc.DeleteProduct(id));
            //            break;

            //        case 4:
            //            var list = pc.GetAllProducts();

            //            foreach (var item in list)
            //            {
            //                Console.WriteLine($"{item.Id} | {item.Name} | {item.CategId}");
            //            }
            //            break;

            //        case 5:
            //            return;
            //    }
            //}
            EventPublisher ep = new EventPublisher();
            EventSubscriber es = new EventSubscriber();

            ep.MyEvent += es.SubscriberMethod;

            ep.MyMethod("Hello");

            Console.ReadLine();
        }
    }
}
