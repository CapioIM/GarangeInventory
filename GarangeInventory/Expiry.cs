using GarangeInventory.Storage.Shelf;
using GarangeInventory.Storage;


namespace GarangeInventory
{
    internal class Expiry
    {
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

        public static List<Item> GetAlltemsLinq(List<StorageUnit> storages)
        {
            return storages
                  .SelectMany(storage => storage.ShelfUnits)
                  .SelectMany(shelfUnit => shelfUnit.Shelfs)
                  .SelectMany(shelf => shelf.Items)
                  .Concat(storages
                      .SelectMany(storage => storage.ShelfUnits)
                      .SelectMany(shelfUnit => shelfUnit.Shelfs)
                      .SelectMany(shelf => shelf.Boxes)
                      .SelectMany(box => box.Items)
                      .Concat(storages
                          .SelectMany(storage => storage.ShelfUnits)
                          .SelectMany(shelfUnit => shelfUnit.Boxes)
                          .SelectMany(box => box.Items)
                          .Concat(storages
                                .SelectMany(storage => storage.ShelfUnits)
                                .SelectMany(shelfUnit => shelfUnit.Items))))
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
    }
}