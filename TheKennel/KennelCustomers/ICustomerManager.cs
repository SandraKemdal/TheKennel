using TheKennel.Data;

namespace TheKennel.KennelCustomers
{
    public interface ICustomerManager
    {
        IDatabaseLists Db { get; set; }

        void CreateCustomer();
        void SeeAllRegisteredCustomers();
    }
}