using System.Collections.Generic;
using TheKennel.KennelAnimals;
using TheKennel.KennelCustomers;

namespace TheKennel.Data
{
    public interface IDatabaseLists
    {
        List<IAnimal> AnimalList { get; set; }
        List<IPerson> PeopleList { get; set; }
     
    }
}