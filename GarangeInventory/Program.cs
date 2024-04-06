﻿
using GarangeInventory.Storage;
using GarangeInventory.Storage.Shelf;

namespace GarangeInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var testDataList = TestData.GenerateItems();
            /*

            List<Item> expiredItems = Expiry.GetExpiredItems(testDataList);

            foreach (Item item in expiredItems)
            {
                Console.WriteLine(expiredItems.IndexOf(item) + " " + item.Name + " " + item.Expiry);
            }

            var allItems = new List<Item>();
            allItems = TestData.GetAllItems(testDataList);
            foreach (Item item in allItems)
            {
                Console.WriteLine(allItems.IndexOf(item) + 1 + " " + item.Name);
            }
            */

            List<Item> allItemsLinq = new List<Item>();
            allItemsLinq = Expiry.GetAlltemsLinq(testDataList);
            foreach (Item item in allItemsLinq)
            {
                Console.WriteLine(allItemsLinq.IndexOf(item) + 1 + " " + item.Name);
            }

            Console.WriteLine(DateTime.Now);
            Console.ReadLine();
        }
    }
}
