using GarangeInventory.Storage.Shelf;
using GarangeInventory.Storage;


namespace GarangeInventory
{
    internal class Expiry
    {
        /// <summary>
        /// get items using foreach loops , check if expired , return list of expired items
        /// </summary>
        /// <param name="storages"> List of storages to check items in </param>
        /// <returns> List of Expired items </returns>
        public static List<Item> GetAllItems(List<StorageUnit> storages)
        {
            List<Item> result = new List<Item>();
            foreach (StorageUnit storage in storages)
            {
                foreach (ShelfUnit shelfUnit in storage.ShelfUnits)
                {
                    result.AddRange((shelfUnit.Items));
                    foreach (Shelf shelf in shelfUnit.Shelfs)
                    {
                        result.AddRange((shelf.Items));
                        foreach (Box box in shelf.Boxes)
                        {
                            result.AddRange((box.Items));
                        }
                    }
                    foreach (Box box in shelfUnit.Boxes)
                    {
                        result.AddRange((box.Items));
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// shortens 3 lines from GetAllItemsLinq method
        /// </summary>
        /// <param name="storages"> List of storages </param>
        /// <returns> returns List of ShelfUnits in storages </returns>
        private static List<ShelfUnit> GetShelfUnits(List<StorageUnit> storages)
        {
            return storages
                .SelectMany(storage => storage.ShelfUnits)
                .ToList();
        }

        public static List<Item> GetAllExpiredItems(List<Item> items)
        {
            return items.Where(item => item.Expiry.Date < DateTime.Now).ToList();
        }

        private static List<Item> GetItemsExpiryCheck(List<Item> items)
        {
            List<Item> result = new List<Item>();
            if (items != null)
            {
                foreach (Item item in items)
                {
                    if (item != null)
                    {
                        if (item.Expiry.Date < DateTime.Now)
                        {
                            result.Add(item);
                        }
                    }
                }
            }
            return result;
        }

        public static void DisplayExpiredItems(List<StorageUnit> storages)
        {
            Console.WriteLine("Heres list of expired items");
            List<Item> items = new List<Item>();
            items = GetAllExpiredItems(GetAllItems(storages));
            foreach (Item item in items)
            {
                Console.WriteLine(items.IndexOf(item) + 1 + " " + item.Name);
            }
        }
    }
}