using TheKennel.KennelAnimals;

namespace TheKennel.KennelCustomers
{
    public interface IPerson
    {
        string Name { get; set; }
        string PhoneNo { get; set; }
        IAnimal Dog { get; set; }
    }
}