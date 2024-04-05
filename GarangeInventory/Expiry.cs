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
        ShelfUnit
        Shelf
        Box
        
         */



        public static List<Item> GetExpiredItems(List<StorageUnit> storages)
        {
            List<Item> result = new List<Item>();
            foreach (StorageUnit storageUnit in storages)
            {
                foreach (ShelfUnit shelfUnit in storageUnit.ShelfUnits)
                {
                    result.AddRange(GetItems(shelfUnit.Items));
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