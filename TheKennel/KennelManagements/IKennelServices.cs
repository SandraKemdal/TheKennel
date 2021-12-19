namespace TheKennel.KennelManagements
{
    public interface IKennelServices
    {
        void GetAnimalClawTrim(int animal);
        void GetAnimalWashed(int animal);
        void AddAnimalTreatment();
    }
}