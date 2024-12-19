using System.Threading.Channels;

namespace Labb_4
{

    internal class Program
    {

        static void Main(string[] args)
        {
            List<Person> myPerson = new List<Person>();

            myPerson.Add(new Person("Disa Dagg",
                Gender.NonBinary,
                new Hair("Blue", "Short"),
                new DateTime(1939,02,28),
                "Black"));
            
            myPerson.Add(new Person("Adam Adamsson",
                Gender.Male,
                new Hair("Blonde", "Long"),
                new DateTime(1997, 1, 1),
                "Blå"));

            myPerson.Add(new Person("Lena PH",
                Gender.Female,
                new Hair("Black", "long"),
                new DateTime(1966, 1, 19),
                "Blå"));

            foreach (var person in myPerson)
            {
                Console.WriteLine(person.ToString());
                Console.WriteLine("*******************************************");
            }
        }


        
    }
}
