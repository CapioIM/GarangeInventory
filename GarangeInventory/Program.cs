using GarangeInventory.Enum;
using GarangeInventory.Storage;
using GarangeInventory.XmlData;
using System.Runtime.Serialization.Json;

namespace GarangeInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<StorageUnit> storages = new List<StorageUnit>();
            storages = TestData.TestDataStorageUnits();
            Serialize.SaveData(storages,SerializationAppFilePath.GarageInventory); 

            Console.WriteLine("Search Options\n1 - Expired items,\n2 - By keyword in name");
            int choice = UiMethods.GetUserInt();
            SearchOptions searchOptions = UiMethods.GetSearchOptions(choice);
            switch (searchOptions)
            {
                case SearchOptions.ExpiryDate:
                    {
                        Expiry.DisplayExpiredItems(storages);
                        break;
                    }
                    case SearchOptions.ContainsName:
                    {
                        Search.DisplaySearchResult(storages);
                        break;
                    }
            }

            Console.WriteLine("End of programm , press any key");
            Console.ReadKey();
        }
    }
}
