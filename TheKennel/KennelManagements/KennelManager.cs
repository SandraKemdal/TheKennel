using System;
using System.Threading;
using TheKennel.Data;
using TheKennel.KennelManagements.Prices;

namespace TheKennel.KennelManagements
{
    public class KennelManager : IKennelManager
    {
        public IDatabaseLists Db { get; set; }
        public IKennelServices KennelServices { get; set; }
        public IKennelPrices KennelPrice { get; set; }

        public KennelManager(IDatabaseLists db, IKennelServices kennelServices, IKennelPrices kennelPrice)
        {
            Db = db;
            KennelServices = kennelServices;
            KennelPrice = kennelPrice;
        }

        public void CheckInAnimal()
        {
           
            for (int i = 0; i < Db.AnimalList.Count; i++)
            {
                if (!Db.AnimalList[i].InKennel)
                {
                    Console.WriteLine($"{i}. {Db.AnimalList[i].AnimalName} ");
                } 
            }

            Console.WriteLine($"\nSelect the animal you want to drop off by writing the number for the animal listed above here: \n");
                   
            int animal = Convert.ToInt32(Console.ReadLine());
          
            Console.WriteLine($"\n{Db.AnimalList[animal].AnimalName} was succesfully checked in!");

            Db.AnimalList[animal].InKennel = true;


            int priceForStay = KennelPrices.priceForStay;
            Console.WriteLine($"Price for stay: {priceForStay} Kr");
                        
            KennelServices.GetAnimalClawTrim(animal);
            KennelServices.GetAnimalWashed(animal);

            Console.WriteLine($"\nThank you, we'll take good care of {Db.AnimalList[animal].AnimalName} for you! We'll See you later!");
            Console.WriteLine("Don't do anything, you will automatically be transferred back to the Main Menu!");

            int millisec = 6000;
            Thread.Sleep(millisec);
            Console.Clear();
        }

        public void CheckOutAnimal()
        {

            for (int i = 0; i < Db.AnimalList.Count; i++)
            {
                if (Db.AnimalList[i].InKennel)
                {
                    Console.WriteLine($"{i}. {Db.AnimalList[i].AnimalName}");
                } 
            }

            Console.WriteLine("\nPlease select the animal you want to check out by writing the number for the animal listed above here: \n");
            
            int animal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\n{Db.AnimalList[animal].AnimalName} was succesfully checked out!");

            Db.AnimalList[animal].InKennel = false;

            Console.WriteLine("\nPress enter for the receipt\n");
            Console.ReadLine();
            Console.WriteLine("Receipt");
            Console.WriteLine("--------\n");

            Console.WriteLine($"Price for 1 day at Kemdal's Kennel: {KennelPrices.priceForStay} Kr");
           
            if(Db.AnimalList[animal].NeedsClawTrim) 
            { 
                Console.WriteLine($"Claw trim: {KennelPrices.priceForClawTrim} Kr"); 
            }

            if (Db.AnimalList[animal].NeedsWash)
            {
                Console.WriteLine($"Animal wash: {KennelPrices.priceForWash} Kr");
            }


            Console.WriteLine($"\nThank you {Db.AnimalList[animal].Owner.Name} for bringing your animal to Kemdals Kennel! Hope to see you soon again :)");
            
            
            int millisec = 6000;
            Thread.Sleep(millisec);
            Console.Clear();
        }

        public void SeeAllCheckedInAnimalsWithOwner()
        { 
            Console.WriteLine("List of all animals at Kemdal's kennel right now and their owner: \n");

            for (int i = 0; i < Db.AnimalList.Count; i++)
            {
                if (Db.AnimalList[i].InKennel)
                {
                    Console.WriteLine($"{i}. {Db.AnimalList[i].AnimalName} is owned by {Db.AnimalList[i].Owner.Name}");
                }
            }

            Console.WriteLine("");
        }
    }
}