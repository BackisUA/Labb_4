using System.Threading.Channels;

namespace Labb_4
{

    internal class Program
    {

        static void Main(string[] args)
        {
            List<Person> myPerson = new List<Person>();

            myPerson.Add(new Person("Linus Backlund",
                Gender.Male,
                new Hair("Kort", "Brunt"),
                new DateTime(2002, 07, 05),
                "Hazel"));

            foreach (var person in myPerson)
            {
                Console.WriteLine(person.ToString());
                Console.WriteLine("******************************");
            }
        }


        
    }
}
