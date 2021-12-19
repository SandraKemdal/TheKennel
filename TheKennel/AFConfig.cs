using Autofac;
using TheKennel.Data;
using TheKennel.KennelAnimals;
using TheKennel.KennelCustomers;
using TheKennel.KennelManagements;
using TheKennel.KennelManagements.Menu;
using TheKennel.KennelManagements.Prices;

namespace TheKennel
{
    internal class AFConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            //Register main application
            builder.RegisterType<Application>().As<IApplication>();

            //MockUpData
            builder.RegisterType<MockUpData>().As<IMockUpData>();

            //DatabaseList
            builder.RegisterType<DatabaseLists>().As<IDatabaseLists>().SingleInstance();

            // Register one by one
            builder.RegisterType<Customer>().As<IPerson>();
            builder.RegisterType<Dog>().As<IAnimal>();
            builder.RegisterType<MainMenu>().As<IMainMenu>();
            builder.RegisterType<CustomerManager>().As<ICustomerManager>();
            builder.RegisterType<AnimalManager>().As<IAnimalManager>();
            builder.RegisterType<KennelManager>().As<IKennelManager>();
            builder.RegisterType<KennelPrices>().As<IKennelPrices>();
            builder.RegisterType<KennelServices>().As<IKennelServices>();
     

            return builder.Build();
        }
    }
}