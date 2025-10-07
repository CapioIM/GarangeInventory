using GarangeInventory.Enum;
using GarangeInventory.Storage;
using GarangeInventory.DataOperations;

namespace GarangeInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SaveData saveData = new SaveData();
            saveData.storageUnits = TestData.TestDataStorageUnits();
            saveData.users = TestData.TestDataUsers();
            saveData.storageUnits[0].Users.Add(saveData.users[0]);
            saveData.storageUnits[0].Users.Add(saveData.users[1]);
            saveData.storageUnits[1].Users.Add(saveData.users[1]);
            saveData.items = TestData.GetAllItems(saveData.storageUnits);
            Serialize.SaveData(saveData, SerializationAppFilePath.GarageInventory);

            Console.WriteLine("Search Options\n1 - Expired items,\n2 - By keyword in name");
            int choice = UiMethods.GetUserChoice();
            SearchOptions searchOptions = UiMethods.GetSearchOptions(choice);
            switch (searchOptions)
            {
                case SearchOptions.ExpiryDate:
                    {
                        Expiry.DisplayExpiredItems(saveData.storageUnits);
                        break;
                    }
                case SearchOptions.ContainsName:
                    {
                        Search.DisplaySearchResult(saveData.storageUnits);
                        break;
                    }
            }

            TestData.ShowNames(saveData.storageUnits);

            Console.WriteLine("End of programm , press any key");
            Console.ReadKey();
        }
    }
}
