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
            List<Storage.StorageUnit> storages = new List<Storage.StorageUnit>();
            var storageList = new List<Storage.StorageUnit>();
            if (optionChoicePicked == 1)
            {
                UIMehods.MakeNewStorage(storageList);
            }

        }
    }
}
