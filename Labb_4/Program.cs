namespace Labb_4
{

    internal class Program
    {
        
        static void Main(string[] args)
        {
            string name = "Linus Backlund";
            Hair hairColor = new Hair { HairColor= "Blond", HairLength = "Kort"};
            Gender personGender = Gender.Male;
            string eyeColor = "Blå";
            DateTime yearOfBirth = new DateTime(1997,11,23);

            Person person1 = new Person(name,eyeColor,yearOfBirth,personGender,hairColor);
            Console.WriteLine(person1.ToString());

           
            
        }
    }
}
