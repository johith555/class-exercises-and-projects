using ConsoleApp1;
using System;
using System.Collections;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using static Program;
using System.Configuration;


class Program
{
    static void Main()
    {
        //Polymorphism obj = new Polymorphism(22);
        //obj.AgeCalculator();
        //FileOperations.WriteLines();
        //FileOperations.AppendText();
        //FileOperations.CheckExists();
        //FileOperations.ReadAll();
        //FileOperations.CopyFile();
        //FileOperations.CreateDirectory();
        //FileOperations.ListFiles();
        //FileOperations.FileStreamDemo();
        //FileOperations.OverwriteAndAppend();
        //Car c = new Car();
        //c.CustomerDetails(phone: "323322", zipcode: 650606, id: 1, name: "Rahul");
        //ThreadingExample te = new ThreadingExample();

        //Thread t1 = new Thread(te.Even);
        //Thread t2 = new Thread(te.Odd);

        //t2.Start();
        //Thread.Sleep(2);  
        //t1.Start();

        //DelegateExample de = new DelegateExample();

        //List<int> results = new List<int>();

        //Func<int, int> f1 = de.Square;
        //f1 += de.Double;   // multicast

        //Console.WriteLine("Last Result: " + f1(10));

        //var invocations = f1.GetInvocationList().Cast<Func<int, int>>();

        //foreach (var inv in invocations)
        //{
        //    results.Add(inv.Invoke(10));
        //}

        //foreach (int i in results)
        //{
        //    Console.WriteLine(i);
        //}

        //Action<int> act = de.Cube;
        //act(3);
        //Hashtable ht = new Hashtable();
        //ht.Add(1, "India");
        //ht.Add(2, "Japan");

        //Console.WriteLine("Hashtable:");
        //foreach (DictionaryEntry de in ht)
        //{
        //    Console.WriteLine(de.Key + " " + de.Value);
        //}

        //SortedList<int, string> sl = new SortedList<int, string>();
        //sl.Add(1, "Country");
        //sl.Add(3, "District");
        //sl.Add(2, "State");

        //Console.WriteLine("\nSortedList:");

        //foreach (KeyValuePair<int, string> kvp in sl)
        //{
        //    Console.WriteLine(kvp.Key + " " + kvp.Value);
        //}
        string cs = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();

        SqlConnection con = new SqlConnection(cs);

        try
        {
            con.Open();
            Console.WriteLine("Connected!");

            SqlCommand cmd = new SqlCommand("SELECT * FROM Users", con);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine($"ID: {dr["Id"]}, Name: {dr["Name"]}, Email: {dr["Email"]}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            con.Close();
        }

        Console.ReadLine();
        }
    }

