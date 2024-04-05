
using GarangeInventory.Storage;
using GarangeInventory.Storage.Shelf;

namespace GarangeInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var testDataList = TestData.GenerateItems();
            List<Item> expiredItems = Expiry.GetExpiryItemsLinq(testDataList);

            foreach (Item item in expiredItems)
            {
                Console.WriteLine(expiredItems.IndexOf(item) + " " + item.Name);
            }

            Console.ReadLine();
        }
    }
}
