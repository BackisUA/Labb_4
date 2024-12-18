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
        public string eyeColor {get; private set; }
        public int birthYear { get; set; }
        public Gender gender { get; set; }
        public Hair hair { get; set; }
        public string HairColor;
        public string HairLength;
    }

    //Constructor
    public Person(string eyeColor, int birthYear, Gender gender)
    {
        EyeColor = eyeColor;
        BirthYear = birthYear;

    }
}
