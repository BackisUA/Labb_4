namespace Labb_4
{
    public class Person
    {
        //Properties
        public string Name { get; set; }
        public string EyeColor { get; set; }
        public DateTime BirthYear { get; set; }
        public Gender getGender { get; set; }
        public Hair getHair { get; set; }
    

    //Constructor
    public Person(string name, Gender gender, Hair hair, DateTime birthYear, string eyeColor)
        {
            Name = name;
            EyeColor = eyeColor;
            BirthYear = birthYear;
            getGender = gender;
            getHair = hair;

        }
        public override string ToString()
        {
            return $"Name: {Name}\nBirthday: {BirthYear:yyyy-MM-dd}\nEyecolor: {EyeColor}\nGender: {getGender}\n{getHair}" ;
        }
    } 
}

