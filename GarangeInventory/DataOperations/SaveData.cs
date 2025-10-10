using GarangeInventory.Storage;

namespace GarangeInventory.DataOperations
{
    public class SaveData
    {
        public List<User> users { get; set; }
        public List<StorageUnit> storageUnits { get; set; }

        public int MaxID
        {
            get
            {
                int maxId = 0;
                foreach (StorageUnit su in storageUnits)
                {
                    if (maxId < su.ID)
                        maxId = su.ID;
                    foreach (ShelfUnit shelfUnit in su.ShelfUnits)
                    {
                        if (maxId < shelfUnit.ID)
                            maxId = shelfUnit.ID;
                        foreach (Box box in shelfUnit.Boxes)
                        {
                            if (maxId < box.ID)
                                maxId = box.ID;
                            foreach (Item item in box.Items)
                            {
                                if (maxId < item.ID)
                                    maxId = item.ID;
                            }
                        }
                        foreach (Item item in shelfUnit.Items)
                        {
                            if (maxId < item.ID)
                                maxId = item.ID;
                        }
                        foreach (Shelf shelf in shelfUnit.Shelfs)
                        {
                            if (maxId < shelf.ID)
                                maxId = shelf.ID;
                            foreach (Box box in shelf.Boxes)
                            {
                                if (maxId < box.ID)
                                    maxId = box.ID;
                                foreach (Item item in box.Items)
                                {
                                    if (maxId < item.ID)
                                        maxId = item.ID;
                                }
                            }
                            foreach (Item item in shelf.Items)
                            {
                                if (maxId < item.ID)
                                    maxId = item.ID;
                            }
                        }
                    }
                }
                return maxId + 1;
            }
        }


    }
}
