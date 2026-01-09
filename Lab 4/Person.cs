using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public Hair Hair { get; set; }
        public DateTime Birthday { get; set; }
        public string EyeColor { get; set; }

        public Person(string firstName, string lastName, Gender gender, Hair hair, string eyeColor, DateTime birthday)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Hair = hair;
            EyeColor = eyeColor;
            Birthday = birthday;
        }

        //Displays the created person object information the way I want it to in a console.writeline
        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}\nEyecolor: {EyeColor}\nBirthday: {Birthday:yyyy-MM-dd}\nGender: {Gender}\nHair: {Hair.Length}cm {Hair.Color}\n";
        }
    }
}
