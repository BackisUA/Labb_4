namespace Labb_4
{

    internal class Program
    {

        static void Main(string[] args)
        {
            List<Person> myPerson = new List<Person>();
            //välkomstmeddelande
            Console.WriteLine("***************************************************************************\n" + "Hello and welcome to the TemperatureCalculator!\n" + "***************************************************************************\n\n");

            bool bExit = false;
            while (bExit == false)
            {
                Console.Clear();//rensa consolen  
                Console.Write($"***************************************************************************\n" +
                    $"Choose an option from the menu:\n" +
                    $"1. Add person\n" +
                    $"2. Search for person\n" +
                    $"3. xxx\n" +
                    $"4. xxx\n" +
                    $"5. xxx\n" +
                    $"6. xxx\n" +
                    $"7. Exit the program\n" +
                    $"***************************************************************************\n" +
                    $"Put your input here:");
                string UserInputMainMenu = Console.ReadLine();

                switch (UserInputMainMenu)
                {
                    case "1":
                        {

                            Console.WriteLine("How many people do u want to add");
                            int sum=int.Parse(Console.ReadLine());
                            
                            for (int i = 0; i < sum ; i++)
                            {
                                Console.WriteLine($"Persons{i+1}:");
                                Console.Write("Name:");
                                string name=Console.ReadLine();

                                Console.Write("Gender) 1.Woman, 2.Man, 3.Non binary \nInput: ");
                                Gender gender=(Gender)int.Parse(Console.ReadLine());

                                Console.Write("Hairlenght: ");
                                string HairLenght=Console.ReadLine();

                                Console.Write("Haircolor: ");
                                string HairColor=Console.ReadLine();

                                Console.Write("Birthday in YYYY,MM,DD: ");
                                DateTime BirthYear =DateTime.Parse(Console.ReadLine());

                                Console.Write("Eyecolor: ");
                                string EyeColor =Console.ReadLine();

                                myPerson.Add(new Person(
                                    name,
                                    gender,
                                    new Hair(HairLenght, HairColor),
                                    BirthYear,
                                    EyeColor));
                                Console.WriteLine("*******************************************");

                            }




                            //myPerson.Add(new Person("Disa Dagg",
                            //    Gender.NonBinary,
                            //    new Hair("Blue", "Short"),
                            //    new DateTime(1939, 02, 28),
                            //    "Black"));

                            //myPerson.Add(new Person("Adam Adamsson",
                            //    Gender.Male,
                            //    new Hair("Blonde", "Long"),
                            //    new DateTime(1997, 1, 1),
                            //    "Blå"));

                            //myPerson.Add(new Person("Lena PH",
                            //    Gender.Female,
                            //    new Hair("Black", "long"),
                            //    new DateTime(1966, 1, 19),
                            //    "Blå"));

                            foreach (var person in myPerson)
                            {
                                Console.WriteLine(person.ToString());
                                Console.WriteLine("*******************************************");
                            }
                            return;
                        }

                    case "7":
                        {
                            Console.WriteLine("Thank you for using this program, hope to see you again soon\n***************************************************************************");
                            bExit = true;//flagga för att lämna aplikationen 
                            break;
                        }
                }


            }

        }

    }
}
