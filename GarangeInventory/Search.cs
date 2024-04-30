using GarangeInventory.Storage;
using GarangeInventory.Storage.Shelf;

namespace GarangeInventory
{
    internal class Search
    {

        public static void DisplaySearchResult(List<StorageUnit> storages)
        {
            Console.WriteLine("Good Luck Searching");
            string searchTerm = Console.ReadLine();
            List<Item> foundResults = Search.SearchItemsByName(Expiry.GetAlltemsLinq(storages), searchTerm);
            foreach (Item foundItem in foundResults)
            {
                Console.WriteLine(foundItem.Name);
            }
        }

        public static List<Item> SearchItemsByName(List<Item> items, string searchWord)
        {
            return items.FindAll(item => item.Name
                                                .ToLower()
                                                .Contains(searchWord.ToLower()))
                                                .ToList();
        }



    }
}
