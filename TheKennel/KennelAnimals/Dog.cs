using System.Collections.Generic;
using TheKennel.KennelCustomers;
using TheKennel.Treatments;

namespace TheKennel.KennelAnimals
{
    public class Dog : IAnimal
    {
        public string AnimalName { get; set; }
        public IPerson Owner { get; set; }
        public bool InKennel { get; set; }
        public bool NeedsWash { get; set; }
        public bool NeedsClawTrim { get; set; }
        public List<ITreatments> AddTreatment { get; set; }

        public Dog()
        {
            InKennel = false;
            NeedsWash = false;
            NeedsClawTrim = false;
            AddTreatment = new List<ITreatments>();
        }
    }
}