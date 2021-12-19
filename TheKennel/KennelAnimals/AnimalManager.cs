using System;
using System.Threading;
using TheKennel.Data;
using TheKennel.Factory;

namespace TheKennel.KennelAnimals
{
    public class AnimalManager : IAnimalManager
    {
        public IDatabaseLists Db { get; set; }
        public AnimalManager(IDatabaseLists db)
        {
            Db = db;
        }

        public void CreateAnimal()
        {
          
            IAnimal animal = AnimalFactory.Create();

            Console.WriteLine("Please enter your animals name here: \n");
            animal.AnimalName = Console.ReadLine();
            Console.WriteLine("");   

            for (int i = 0; i < Db.PeopleList.Count; i++)
            {
                var customer = Db.PeopleList[i].Name;
                Console.WriteLine($"{i}. {customer}");
            }

            Console.WriteLine($"\nSelect owner to {animal.AnimalName} by writing the number for the person listed above");
           
            var dogOwner = Convert.ToInt32(Console.ReadLine());
            animal.Owner = Db.PeopleList[dogOwner];

            Console.WriteLine($"\nWelcome {animal.AnimalName}!\n");
            Console.WriteLine($"{animal.Owner.Name} your dog {animal.AnimalName} was succesfully registreted as a new animal at Kemdal's Kennel!");
            Console.WriteLine("Don't do anything, you will automatically be transferred back to the Main Menu!");
            Db.AnimalList.Add(animal);
            
            int millisec = 6000;
            Thread.Sleep(millisec);

            Console.Clear();

        }

        public void SeeAllRegisteredAnimals()
        {
            Console.WriteLine("List of all registered animals at Kemdal's Kennel:\n");

            foreach (var animal in Db.AnimalList)
            {
                Console.WriteLine($"Animal: {animal.AnimalName}, At kennel: {animal.InKennel}");
            }

            Console.WriteLine("");
        }

        public void SeeAllAnimalsAndTheirOwner()
        {
            Console.WriteLine("List of all animals at Kemdal's kennel right now and their owner: \n");

            foreach (var animal in Db.AnimalList)
            {
                Console.WriteLine($"Animal: {animal.AnimalName}, Owner: {animal.Owner.Name}");
            }

            Console.WriteLine("");
        }

    }
}