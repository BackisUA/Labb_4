using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4
{
    internal class Person
    {
        //Properties
        public string Name { get; set; }
        public string EyeColor { get; set; }
        public DateTime YearOfBirth { get; set; }
        public Gender PersonGender { get; set; }
        public Hair PersonHair { get; set; }



        //Constructor
        public Person(string name, string eyeColor, DateTime yearOfBirth, Gender gender, Hair hair)
        {
            Name = name;
            EyeColor = eyeColor;
            YearOfBirth = yearOfBirth;
            PersonGender = gender;
            PersonHair = hair;
        }
        public override string ToString()
        {
            return $"\nNamn: {Name}" +
                $"\nKön: {PersonGender}" +
                $"\nFödelseår: {YearOfBirth}" +
                $"\nÖgonfärg: {EyeColor}" + 
                $"\nHår: {PersonHair}";

        }
    }
}
