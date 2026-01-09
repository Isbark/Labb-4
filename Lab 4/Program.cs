using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace Lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Bob = new Person("Bob", "Rock", Gender.Male, new Hair(10, "Purple"), "Blue", new DateTime(1990, 07, 28));
            Person Kim = new Person("Kim", "Bark", Gender.NonBinary, new Hair(16, "Black"), "Brown", new DateTime(2005, 01, 15));

            bool running = true;

            List<Person> list = new List<Person>();
            list.Add(Bob);
            list.Add(Kim);

            while (running)
            {
                Console.WriteLine("Lab 4");
                Console.WriteLine("--------------------------------");
                Console.Write("What action do you want to do?:\n1 to exit.\n2 to add a person.\n3 to list the people added to the list.\n> ");
                string input = Console.ReadLine();
                Console.WriteLine("--------------------------------");

                switch (input)
                {
                    case "1":
                        running = false;
                        break;
                    case "2":
                        ListManager.Add(list);
                        break;
                    case "3":
                        ListManager.ListPerson(list);
                        Console.WriteLine("Enter to continue");
                        Console.WriteLine("--------------------------------");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Invalid input!\nEnter to continue");
                        Console.ReadLine();
                        break;
                }

                Console.Clear();
            }
            Console.WriteLine("Program shuting down.");
        }
    }
}
