using TheKennel.Data;

namespace TheKennel.Treatments
{
    public interface ITreatments
    {
        IDatabaseLists Db { get; set; }
        string Name { get; }

    }
}
