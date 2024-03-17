using System.Security.Cryptography.X509Certificates;

namespace GarangeInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Garage Inventory System ! \n" +
                              "Please choose storage unit from list or create new storage unit\n" +
                              "1 - Create New Storage Unit\n" +
                              "2 - Choose Storage Unit");

            var optionChoicePicked = UIMehods.GetUserOptionChoice();
            List<Storage.Storage> storages = new List<Storage.Storage>();
            var storageList = new List<Storage.Storage>();
            if (optionChoicePicked == 1)
            {
                UIMehods.MakeNewStorage(storageList);
            }

        }
    }
}
