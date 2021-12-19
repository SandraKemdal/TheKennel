using TheKennel.KennelAnimals;

namespace TheKennel.Factory
{
    public class AnimalFactory
    {
        public static IAnimal Create()
        {
            return new Dog();
        }
    }
}
