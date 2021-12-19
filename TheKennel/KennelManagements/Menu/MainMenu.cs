using System;
using TheKennel.KennelAnimals;
using TheKennel.KennelCustomers;

namespace TheKennel.KennelManagements.Menu
{
    public class MainMenu : IMainMenu
    {
        public bool IsRunning { get; set; }
        public ICustomerManager CustomerManager { get; set; }
        public IAnimalManager AnimalManager { get; set; }
        public IKennelManager KennelManager { get; set; }
        public IKennelServices KennelService { get; set; }

        public MainMenu(ICustomerManager customerManager, IAnimalManager animalManager, IKennelManager kennelManager, IKennelServices kennelService)
        {
            CustomerManager = customerManager;
            AnimalManager = animalManager;
            KennelManager = kennelManager;
            KennelService = kennelService;

        }
     

        public void MenuChoises()
        {
            Console.WriteLine("Welcome to Kemdals Kennel!\n");
            Console.WriteLine("Please choose an alternative:\n");
            Console.WriteLine("1. Registrate a new customer");
            Console.WriteLine("2. Registrate a new animal");
            Console.WriteLine("3. View all the customers registered");
            Console.WriteLine("4. View all the animals registered");
            Console.WriteLine("5. View which animals belongs to which customers ");
            Console.WriteLine("6. View all the animals that are in Kemdal's Kennel right now and which customer they belong to");
            Console.WriteLine("7. Drop off your animal");
            Console.WriteLine("8. Pick up your animal");
            Console.WriteLine("9. Add treatment to animal \n");

        }

        public void ShowMenu()
        {
            MenuChoises();

            var usersChoise = Console.ReadLine();

            switch (usersChoise)
            {
                case "1":
                        Console.Clear();
                        CustomerManager.CreateCustomer();
                        ShowMenu();
                    break;
                case "2":
                        Console.Clear();
                        AnimalManager.CreateAnimal();
                        ShowMenu();
                    break;
                case "3":
                        Console.Clear();
                        CustomerManager.SeeAllRegisteredCustomers();
                        ShowMenu();
                    break;
                case "4":
                        Console.Clear();
                        AnimalManager.SeeAllRegisteredAnimals();
                        ShowMenu();
                    break;
                case "5":
                        Console.Clear();
                        AnimalManager.SeeAllAnimalsAndTheirOwner();
                        ShowMenu();
                    break;
                case "6":
                        Console.Clear();
                        KennelManager.SeeAllCheckedInAnimalsWithOwner();
                        ShowMenu();
                    break;
                case "7":
                        Console.Clear();
                        KennelManager.CheckInAnimal();
                        ShowMenu();
                    break;
                case "8":
                        Console.Clear();
                        KennelManager.CheckOutAnimal();
                        ShowMenu();
                    break;
                case "9":
                    Console.Clear();
                    KennelService.AddAnimalTreatment();
                    ShowMenu();
                    break;
                default:
                        Console.Clear();
                        Console.WriteLine("Unkown command, please try again \n");
                        ShowMenu();
                    break;
            }
        }
        
    }
}