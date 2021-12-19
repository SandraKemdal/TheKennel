using TheKennel.Data;
using TheKennel.Factory;
using TheKennel.KennelAnimals;
using TheKennel.KennelCustomers;

namespace TheKennel
{
    internal class MockUpData : IMockUpData
    {
        public IDatabaseLists Db { get; set; }

        public MockUpData(IDatabaseLists db)
        {
            Db = db;
        }

        public void CreateMockData()
        {
            
            IPerson person1 = CustomerFactory.Create();
            person1.Name = "Sandra";
            person1.PhoneNo = "073-123 45 67";
            Db.PeopleList.Add(person1);

            IPerson person2 = CustomerFactory.Create();
            person2.Name = "Alan";
            person2.PhoneNo = "073-123 45 67";
            Db.PeopleList.Add(person2);

            IPerson person3 = CustomerFactory.Create();
            person3.Name = "Melwin";
            person3.PhoneNo = "073-123 45 67";
            Db.PeopleList.Add(person3);


            IAnimal animal1 = AnimalFactory.Create();
            animal1.AnimalName = "Palle";
            animal1.Owner = Db.PeopleList[0];
            Db.AnimalList.Add(animal1);

            IAnimal animal2 = AnimalFactory.Create();
            animal2.AnimalName = "Jossi";
            animal2.Owner = Db.PeopleList[1];
            animal2.InKennel = true;
            Db.AnimalList.Add(animal2);

            IAnimal animal3 = AnimalFactory.Create();
            animal3.AnimalName = "Sindy";
            animal3.Owner = Db.PeopleList[2];
            Db.AnimalList.Add(animal3);
           
        }
    }
}