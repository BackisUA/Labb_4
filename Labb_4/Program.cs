namespace Labb_4
{

    internal class Program
    {
        
        static void Main(string[] args)
        {
            string personName = "Linus Backlund";
            Hair hair = new Hair { HairColor= "Blond", HairLength = "Kort"};
            Gender personGender = Gender.Male;
            string eyeColor = "Blå";

            DateTime yearOfBirth = new DateTime(1997,11,23);

            Person person = new Person(eyeColor,yearOfBirth,personGender,hair);
            //userinput?
            Console.WriteLine(person.ToString());
            
        }
    }
}
