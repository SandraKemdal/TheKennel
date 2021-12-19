using System;
using TheKennel.Data;
using TheKennel.KennelManagements.Menu;
using TheKennel.KennelManagements.Prices;
using TheKennel.Treatments;

namespace TheKennel.KennelManagements
{
    public class KennelServices : IKennelServices
    {
        public IDatabaseLists Db { get; set; }
        public IMainMenu MainMenu { get; set; }
        public ITreatments AddTreatments { get; }
        public bool TrueOrFalse { get; set; }

        public KennelServices(IDatabaseLists db)
        {
            TrueOrFalse = false;
            Db = db; 

        }

        public void GetAnimalClawTrim(int animal)
        {
            Console.WriteLine($"\nDoes {Db.AnimalList[animal].AnimalName} need to trim it's claws, Yes/No?");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "yes")
            {
                Db.AnimalList[animal].NeedsClawTrim = true;
                Console.WriteLine("\nClaw trim added");

            } else
            {
                Console.WriteLine("\nNo claw trim added");
            }
        }

        public void GetAnimalWashed(int animal)
        {
            Console.WriteLine($"\nDoes {Db.AnimalList[animal].AnimalName} need a wash, Yes/No?");
            
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "yes")
            {
                Db.AnimalList[animal].NeedsWash = true;
                Console.WriteLine("\nWash added");

            } else
            {
                Console.WriteLine("\nNo wash added");
            }
        }


        public void AddAnimalTreatment()
        {
            Console.WriteLine("Animals in Kemdals Kennel right now: \n");
            for (int i = 0; i < Db.AnimalList.Count; i++)
            {
                if (Db.AnimalList[i].InKennel)
                {
                    Console.WriteLine($"{i}. {Db.AnimalList[i].AnimalName}");

                }
            }
            
            Console.WriteLine("\nPlease select the animal you want to add treatment to by writing the number for the animal listed above here: \n");

            int animal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nWhat treatment is {Db.AnimalList[animal].AnimalName} having?\n");
            Console.WriteLine("1. Claw trim");
            Console.WriteLine("2. Wash");
            Console.WriteLine("3. No treamtents today");
            Console.WriteLine("4. Want to go back to the Main Menu? \n");


            var userInput = Console.ReadKey(true).Key;

            switch (userInput)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    ITreatments clawTrim = new ClawTrim();
                    Console.WriteLine($"Claw trim treatment added");
                    Db.AnimalList[animal].AddTreatment.Add(clawTrim);
                    TrueOrFalse = true;
                    int priceForClawTrim = KennelPrices.priceForClawTrim;
                    Console.WriteLine($"Price for claw trim: {priceForClawTrim} Kr \n");
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    ITreatments wash = new Wash();
                    Console.WriteLine($"Wash treatment added");
                    Db.AnimalList[animal].AddTreatment.Add(wash);
                    TrueOrFalse = true;
                    int priceForWash = KennelPrices.priceForWash;
                    Console.WriteLine($"Price for wash: {priceForWash} Kr \n");
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Console.WriteLine("No treatment added \n");
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    Console.WriteLine("Press enter to go back");
                    Console.ReadKey(true);
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Unkown command, please try again. \n");
                    break;
            }
        }

    }
}