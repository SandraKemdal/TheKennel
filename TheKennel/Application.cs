using TheKennel.Data;
using TheKennel.KennelManagements.Menu;

namespace TheKennel
{
    public class Application : IApplication
    {

        public IDatabaseLists Db { get; set; }
        public IMainMenu MainMenu { get; set; }
        public IMockUpData MockUpData { get; set; }

     
        public Application(IDatabaseLists db, IMainMenu mainMenu, IMockUpData mockUpData)
        {
            Db = db;
            MainMenu = mainMenu;
            MockUpData = mockUpData;
        }

        public void Run()
        {
            MockUpData.CreateMockData();
            MainMenu.ShowMenu();
        }

    }
}