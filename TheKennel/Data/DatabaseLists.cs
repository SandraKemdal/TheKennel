using System.Collections.Generic;
using TheKennel.KennelAnimals;
using TheKennel.KennelCustomers;

namespace TheKennel.Data
{
    public class DatabaseLists : IDatabaseLists
    {
        public List<IAnimal> AnimalList { get; set; }
        public List<IPerson> PeopleList { get; set; }

        public DatabaseLists()
        {
            AnimalList = new List<IAnimal>();
            PeopleList = new List<IPerson>();
        }
       
    }
}