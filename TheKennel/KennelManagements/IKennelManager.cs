using TheKennel.Data;

namespace TheKennel.KennelManagements
{
    public interface IKennelManager
    {
        IDatabaseLists Db { get; set; }
        void CheckInAnimal();
        void CheckOutAnimal();
        void SeeAllCheckedInAnimalsWithOwner();

    }
}