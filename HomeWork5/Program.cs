using System;
using System.Collections.Generic;

namespace HomeWork5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 1.3 - Create list of IDeveloper
            List<IDeveloper> listDeveloper = new List<IDeveloper>();
            listDeveloper.Add(new Programmer("C#"));
            listDeveloper.Add(new Builder(".NET"));
            listDeveloper.Add(new Programmer("Python"));
            listDeveloper.Add(new Builder("Unity"));
            listDeveloper.Add(new Programmer("Java"));
            listDeveloper.Add(new Builder("Angular"));
            listDeveloper.Add(new Programmer("JS"));
            listDeveloper.Add(new Builder("ASP.NET"));
            foreach (var employee in listDeveloper)
            {
                employee.Create();
                employee.Destroy();
            }
            Console.WriteLine();

            //Part 1.4 - Implement interface IComparable for clases and sort array or list of IDeveloper
            Console.WriteLine("\t Unsort list");
            foreach (var employee in listDeveloper)
            {
                Console.WriteLine(employee.Tool);
            }
            Console.WriteLine();

            Console.WriteLine("\t Sort list");
            listDeveloper.Sort();
            foreach (var employee in listDeveloper)
            {
                Console.WriteLine(employee.Tool);
            }
            Console.WriteLine();
            //Part 2.1 - In the Main() method declare Dictionary<uint,string>. 
            Dictionary<int, string> dict = new Dictionary<int, string>()
            {
            //Part 2.2 - Add to Dictionary from Console 7 pairs (ID, Name) of some persons

                { 1, "Tom"},
                { 2, "Bob"},
                { 3, "Tim"},
                { 4, "Jack"},
                { 5, "Sara"},
                { 6, "Jessi"},
                { 7, "Max"}
            };
            Console.WriteLine("\tNew dictionary");
            foreach (var pers in dict)
            {
                Console.WriteLine($"Key: {pers.Key}, \t Name: {pers.Value}");
            }
            Console.WriteLine();
            //Part 2.3 - Ask user to enter ID, then find and write corresponding Name from your Dictionary
            Console.Write("Enter ID for search: \t");
            int search = int.Parse(Console.ReadLine());
            if (search > dict.Count)
            {
                Console.WriteLine("There isn't ID");
            }
            else
            foreach (var pers in dict)
            {
                if (pers.Key == search)
                {
                    Console.WriteLine($"for ID {pers.Key} have value {pers.Value}");
                }
            }
            Console.ReadLine();
        }
    }
}
