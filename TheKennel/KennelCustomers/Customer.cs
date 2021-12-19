using TheKennel.KennelAnimals;

namespace TheKennel.KennelCustomers
{
    public class Customer : IPerson
    {
       public string Name { get; set; }
       public string PhoneNo { get; set; }
       public IAnimal Dog { get; set; }
    }
}