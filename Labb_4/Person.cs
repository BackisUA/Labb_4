namespace Labb_4
{
    public class Person
    {
        //Properties
        public string Name { get; set; }
        public string EyeColor { get; set; }
        public DateTime BirthYear { get; set; }
        public Gender gender { get; set; }
        public Hair hair { get; set; }
    

    //Constructor
    public Person(string name, Gender gender, Hair hair, DateTime birthYear, string eyeColor)
        {
            Name = name;
            EyeColor = eyeColor;
            BirthYear = birthYear;

        }
        public override string ToString()
        {
            return $"Name: {Name}\nBirthday: {BirthYear:yyyy-mm-dd}\nEyecolor: {EyeColor}";
        }
    } 
}

