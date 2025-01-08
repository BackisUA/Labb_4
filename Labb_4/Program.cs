namespace Labb_4
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //Välkomstmeddelande, samtidigt initieras en lista som ska hålla personer. Samt meny för att lägga till personer eller avsluta programmet.
            Console.WriteLine("***************************************************************************\n" + "Hello and welcome to the Eye!\n" + "***************************************************************************\n\n");
            List<Person> myPerson = new List<Person>();
            bool bExit = false;
            while (bExit == false)
            {
                Console.Write($"***************************************************************************\n" +
                    $"Choose an option from the menu:\n" +
                    $"1. Add person\n" +
                    $"2. Exit the program\n" +
                    $"***************************************************************************\n" +
                    $"Put your input here:");
                string UserInputMainMenu = Console.ReadLine();

                switch (UserInputMainMenu)
                {
                    //Case 1: Lägga till valfritt antal personer
                    case "1":
                        {
                            int sum = 0;
                            while (true)
                            {
                                Console.WriteLine("How many people do u want to add?");
                                string inputPerson = Console.ReadLine();
                                if (int.TryParse(inputPerson, out sum) && sum > 0)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input, please use a positive number.");
                                }
                            }

                            //Loop för att lägga till personer
                            for (int i = 0; i < sum; i++)
                            {
                                Console.WriteLine($"Person: {i + 1}");
                                
                                Console.Write("Name:");
                                string name = Console.ReadLine();

                                //Kön
                                Gender gender;
                                while (true)
                                {
                                    Console.Write("Gender: 1.Man, 2.Woman, 3.Non binary \nInput: ");
                                    string genderInput = Console.ReadLine();
                                    if (int.TryParse(genderInput, out int genderValue) && Enum.IsDefined(typeof(Gender), genderValue))
                                    {
                                        gender = (Gender)genderValue;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid input, try a number between 1-3");
                                    }
                                }

                                //Hårfärg och hårlängd
                                Console.Write("Hairlength: ");
                                string HairLenght = Console.ReadLine();

                                Console.Write("Haircolor: ");
                                string HairColor = Console.ReadLine();

                                //Födelseår
                                DateTime birthYear;
                                while (true)
                                {
                                    Console.Write("Birthday in YYYY,MM,DD: ");
                                    string dateInput = Console.ReadLine();
                                    if (DateTime.TryParse(dateInput, out birthYear))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid input, enter a valid date in the form of YYYY,MM,DD: ");
                                    }
                                }

                                //Ögonfärg
                                Console.Write("Eyecolor: ");
                                string EyeColor = Console.ReadLine();

                                myPerson.Add(new Person(
                                    name,
                                    gender,
                                    new Hair(HairLenght, HairColor),
                                    birthYear,
                                    EyeColor));
                                Console.WriteLine("*******************************************");
                                Console.Clear();
                            }

                            //Skriver ut alla personer existerande listan
                            foreach (var person in myPerson)
                            {
                                Console.WriteLine("*******************************************\n" +
                                $"{person.ToString()}\n" +
                                "*******************************************");
                            }
                            break;
                        }

                    //Case 2: Avslutar programmet
                    case "2":
                        {
                            Console.WriteLine("Thank you for using this program, hope to see you again soon\n***************************************************************************");
                            bExit = true;
                            break;
                        }
                }
            }
        }
    }
}
        

    

