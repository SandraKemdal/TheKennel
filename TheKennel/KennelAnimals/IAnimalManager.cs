using TheKennel.Data;

namespace TheKennel.KennelAnimals
{
    public interface IAnimalManager
    {
        IDatabaseLists Db { get; set; }

        void CreateAnimal();
        void SeeAllAnimalsAndTheirOwner();
        void SeeAllRegisteredAnimals();
    }
}