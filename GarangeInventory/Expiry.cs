using GarangeInventory.Storage.Shelf;
using GarangeInventory.Storage;


namespace GarangeInventory
{
    internal class Expiry
    {
        /*  // provide list with expired items
          take storageUnit list > check for items > take all shelfUnits > check for items > take all shelfs > check for items > take all boxes > check for items
        check for items with expiry date < now 

        List of items has:

        ShelfUnit => Item
        ShelfUnit => box => item
        ShelfUnit => shelf => Item
        ShelfUnit => Shelf => Box => item
        
         */

        
        public static List<Item> GetExpiryItemsLinq(List<StorageUnit> storages)
        {
          return  storages
                 .SelectMany(storageUnit => storageUnit.ShelfUnits)
                 .SelectMany(shelfUnit => shelfUnit.Boxes)
                 .SelectMany(box => box.Items)
                 .Concat(storages
                                 .SelectMany(storageUnit => storageUnit.ShelfUnits)
                                 .SelectMany(shelfUnit => shelfUnit.Shelfs)
                                 .SelectMany(shelf => shelf.Boxes)
                                 .SelectMany(box => box.Items)

                 .Where(expCheck => expCheck?.Expiry < DateTime.Now))
                 .ToList();
             
        }

        


        public static List<Item> GetExpiredItems(List<StorageUnit> storages)
        {
            List<Item> result = new List<Item>();
            foreach (StorageUnit storageUnit in storages)
            {
                foreach (ShelfUnit shelfUnit in storageUnit.ShelfUnits)
                {
                    result.AddRange(GetItems(shelfUnit.Items));
                    foreach (Shelf shelf in shelfUnit.Shelfs)
                    {

                    }
                    foreach (Box box in shelfUnit.Boxes)
                    {
                        result.AddRange(GetItems(box.Items));
                    }
                }

            }
            return result;
        }


        private static List<Item> GetItems(List<Item> items)
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