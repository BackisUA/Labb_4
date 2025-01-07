﻿namespace Labb_4
{
    public class Person
    {
        //Klass för att hålla koll på personens namn, ögonfärg, födelsedatum, kön och hår
        public string Name { get; set; }
        public string EyeColor { get; set; }
        public DateTime BirthYear { get; set; }
        public Gender getGender { get; set; }
        public Hair getHair { get; set; }

        //Konstruktor för att skapa en instans av Person
        public Person(string name, Gender gender, Hair hair, DateTime birthYear, string eyeColor)
        {
            Name = name;
            EyeColor = eyeColor;
            BirthYear = birthYear;
            getGender = gender;
            getHair = hair;

        }

        //Metod som returnerar en sträng med information om personen
        public override string ToString()
        {
            return $"Name: {Name}\nBirthday: {BirthYear:yyyy-MM-dd}\nEyecolor: {EyeColor}\nGender: {getGender}\n{getHair}";
        }
    }
}

