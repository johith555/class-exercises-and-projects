using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Car
    {
        public void CustomerDetails(String name, String phone, int zipcode, int id)
        {
            Console.WriteLine($"Name: {name}, Phone: {phone}, Zipcode: {zipcode}, Id: {id}");

        }
    }
}
