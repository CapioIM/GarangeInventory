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
        public static List<Item> GetExpiredItems(List<StorageUnit> storages)
        {
            List<Item> result = new List<Item>();
            foreach (StorageUnit storage in storages)
            {
                foreach (ShelfUnit shelfUnit in storage.ShelfUnits)
                {
                    result.AddRange(GetItemsExpiryCheck(shelfUnit.Items));
                    foreach (Shelf shelf in shelfUnit.Shelfs)
                    {
                        result.AddRange(GetItemsExpiryCheck(shelf.Items));
                        foreach (Box box in shelf.Boxes)
                        {
                            result.AddRange(GetItemsExpiryCheck(box.Items));
                        }
                    }
                    foreach (Box box in shelfUnit.Boxes)
                    {
                        result.AddRange(GetItemsExpiryCheck(box.Items));
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Get all items (LINQ)from ShelfUnit=>items ,ShelfUnit=> shelf =>items, shelfUnit=>shelf=>box=>items , ShelfUnit=>box=>items.
        /// </summary>
        /// <param name="storages"> Top Level of List of storage</param>
        /// <returns> List with all Items </returns>
        public static List<Item> GetAlltemsLinq(List<StorageUnit> storages)
        {
            if (storages == null)
            {
                return new List<Item>();
            }

            try
            {
                List<ShelfUnit> shelfUnit = new List<ShelfUnit>(GetShelfUnits(storages));
                return shelfUnit
                      .SelectMany(shelfUnit => shelfUnit.Shelfs)
                      .SelectMany(shelf => shelf.Items)
                          .Concat(shelfUnit
                          .SelectMany(shelfUnit => shelfUnit.Shelfs)
                          .SelectMany(shelf => shelf.Boxes)
                          .SelectMany(box => box.Items)
                              .Concat(shelfUnit
                              .SelectMany(shelfUnit => shelfUnit.Boxes)
                              .SelectMany(box => box.Items)
                                    .Concat(shelfUnit
                                    .SelectMany(shelfUnit => shelfUnit.Items))))
                      .ToList();
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
                return new List<Item>();
            }
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
            items = GetAllExpiredItems(GetAlltemsLinq(storages));
            foreach (Item item in items)
            {
                Console.WriteLine(items.IndexOf(item) + 1 + " " + item.Name);
            }
        }
    }
}