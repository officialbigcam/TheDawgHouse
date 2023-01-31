using System;
using System.Text.Json;



namespace MyPetStore
{
    class Program
    {
        static void Main(string[] args)
        {


            // Entry point into the application - Everything starts here !


            // This section is only going to run once
            Console.WriteLine("Type 1 to add Cat Food");
            Console.WriteLine(" ");
            Console.WriteLine("Type 'exit' to exit program");
            Console.WriteLine(" ");
            Console.WriteLine(">> ");
            string userInput = Console.ReadLine();
            CatFood catFood = null;

            // This section is going to repeat until someone types exit
            while (userInput.ToLower() != "exit")
            {

                if (userInput == "1")
                {
                    Console.WriteLine("Is this for a kitten? enter Y or N");
                    Console.WriteLine(" ");
                    Console.WriteLine(">> ");
                    string kittenFood = Console.ReadLine();
                    bool boolKittenFood = false;

                    if (kittenFood == "y")
                    {
                        boolKittenFood = true;
                    }
                    Console.WriteLine("Weight of the kitten food?  10 or 20 lb bag? ");
                    Console.WriteLine(" ");
                    Console.WriteLine(">> ");
                    string kittenWeight = Console.ReadLine();
                    while (!(kittenWeight.ToLower() == "10" || kittenWeight.ToLower() == "20"))
                    {
                        Console.WriteLine("Weight of the kitten food?  10 or 20 lb bag? ");
                        Console.WriteLine(" ");
                        Console.WriteLine(">> ");
                        kittenWeight = Console.ReadLine();
                    }

                    // Create your object of CatFood
                    catFood = new CatFood();
                    catFood.KittenFood = boolKittenFood;
                    catFood.WeightPounds = Convert.ToDouble(kittenWeight);


                }

                Console.WriteLine("You have created a code object");
                Console.WriteLine(" ");
                Console.WriteLine(" Output");
                Console.WriteLine(" --------------------------------------------------");
                Console.WriteLine("Cat Food Details");
                Console.WriteLine(catFood.KittenFood.ToString());
                Console.WriteLine(catFood.WeightPounds);
                Console.WriteLine(" --------------------------------------------------");
                Console.WriteLine("Ending Program");

                // End Program
                Environment.Exit(0);


            }


            // We are out of the while loop, exiting - added this to make it make more sense
            Console.WriteLine("We have exiting, hit enter to close");
            userInput = Console.ReadLine();

        }
    }

}
