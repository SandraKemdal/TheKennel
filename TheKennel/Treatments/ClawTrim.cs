using TheKennel.Data;

namespace TheKennel.Treatments
{
    public class ClawTrim : ITreatments
    {
        public string Name => "Claw trim";

        public bool TrueOrFalse { get; set; }
        public IDatabaseLists Db { get; set; }
    }
}

