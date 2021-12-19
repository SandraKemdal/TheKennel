using TheKennel.KennelCustomers;

namespace TheKennel.Factory
{
    public static class CustomerFactory
    {
        public static IPerson Create()
        {
            return new Customer();
        }
    }
}
