using TheKennel.Data;

namespace TheKennel.Treatments
{
    public class Wash : ITreatments
    {
        public string Name => "Wash";

        public bool TrueOrFalse { get; set; }
        public IDatabaseLists Db { get; set; }
               
    }
}
