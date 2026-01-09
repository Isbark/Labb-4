using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    //The class is set to static so it can be called on without creating a instance of it.
    public static class ListManager
    {
        // This add method goes through and asks the user for all the person data needed for a Person object to be created and creates it at the end.
        public static void Add(List<Person> list)
        {
            string firstName = ErrorCheck.StringCheck("Whatr is the persons first name?");
            string lastName = ErrorCheck.StringCheck("What is the persons last name?");
            string eyeColor = ErrorCheck.StringCheck("What is the persons eye color?");
            string hairColor = ErrorCheck.StringCheck("What is the persons hair color?");
            int hairLength = ErrorCheck.IntCheck("What is the persons hair length?");
            DateTime birthday = ErrorCheck.DateTimeCheck("What is the persons birthday? (YYYY-MM-DD)");

            bool genderLoop = true;
            Gender gender = Gender.Other;
            while (genderLoop)
            {
                int count = 1;
                Console.WriteLine("What is the persons gender?");
                foreach (var value in Enum.GetValues(typeof(Gender)))
                {
                    Console.WriteLine(count + " " + value.ToString());
                    count++;
                }
                Console.Write("> ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        gender = Gender.Male;
                        genderLoop = false;
                        break;
                    case "2":
                        gender = Gender.Female;
                        genderLoop = false;
                        break;
                    case "3":
                        gender = Gender.NonBinary;
                        genderLoop = false;
                        break;
                    case "4":
                        gender = Gender.Other;
                        genderLoop = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }

            }


            list.Add(new Person(firstName, lastName, gender, new Hair(hairLength, hairColor), eyeColor, birthday));
        }

        //This methods simply lists out all the Person objects in the list.
        public static void ListPerson(List<Person> list)
        {
            foreach (Person person in list)
            {
                Console.WriteLine(person);
                Console.WriteLine();
            }
        }
    }
}
