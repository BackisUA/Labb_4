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
        public string HairColor {  get; set; }
        public string HairLength {  get; set; }
    }

    //Constructor
    public Person(string eyeColor, int birthYear, Gender gender, Hair hair, HairColor hairColor, HairLength hairLength)
    {
        EyeColor = eyeColor;
        BirthYear = birthYear;
        Gender = gender;
        Hair = hair;
        HairColor = hairColor;
        HairLength = hairLength;
    }
    public override ToString()
    {
        return $"Kön: {Gender}" +
            $"\nFödelseår: {BirthYear}" +
            $"\nÖgonfärg: {EyeColor}" +
            $"\nHårfärg: {HairColor}" +
            $"\nHårlängd: {HairLength}"

    }
}
