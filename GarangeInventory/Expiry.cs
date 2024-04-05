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

            for (int i = 0; i < storages.Count; i++)
            {
                for (int j = 0; j < storages[i].ShelfUnits.Count; j++)
                {
                    for (int k = 0; k < storages[i].ShelfUnits[j].Shelfs.Count; k++)
                    {
                        var shelfexpired = GetItems(storages[i].ShelfUnits[j].Shelfs[k].Items);
                        foreach (var item in shelfexpired)
                        {
                            result.Add(item);
                        }

                        for (int l = 0; l < storages[i].ShelfUnits[j].Shelfs[j].Boxes.Count; l++)
                        {

                        }
                    }
                }
            }
            return result;
        }

        private static List<Item> GetItems(List<Item> items)
        {
            List<Item> result = new List<Item>();
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
            return result;
        }
    }
}