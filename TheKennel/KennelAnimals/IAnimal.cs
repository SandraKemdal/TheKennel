using System.Collections.Generic;
using TheKennel.KennelCustomers;
using TheKennel.Treatments;

namespace TheKennel.KennelAnimals
{
    public interface IAnimal
    {
        string AnimalName { get; set; }
        IPerson Owner { get; set; }
        bool InKennel { get; set; }
        bool NeedsWash { get; set; }
        bool NeedsClawTrim { get; set; }
        List<ITreatments> AddTreatment { get; set; }
    }
}