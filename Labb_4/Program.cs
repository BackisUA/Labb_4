using System.Xml.Linq;

namespace Labb_4
{

    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<Person> myPerson = new List<Person>();

       

            Person person1= new Person(Name name = new Name { FirstName = "Linus", LastName = "Backlund" },
                Gender personGender = Gender.Male,);

            Person person2 = new Person(Name name = new Name { FirstName = "Linus", LastName = "Backlund" },
                Gender personGender = Gender.Male,);

            Person person3 = new Person(Name name = new Name { FirstName = "Linus", LastName = "Backlund" },
                Gender personGender = Gender.Male,);


            myPerson.Add(person1);
            myPerson.Add(person2);
            myPerson.Add(person3);
        }
    }
}
