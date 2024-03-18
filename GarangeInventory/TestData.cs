using GarangeInventory.Storage.Shelf.Items;
using GarangeInventory.Storage.Shelf;
using GarangeInventory.Storage;
namespace GarangeInventory
{
    public class TestData
    {
        public List<Item> GenerateItems()
        {
            List<StorageUnit> storageList = new List<StorageUnit>();
            StorageUnit storageOne = new StorageUnit("2nd Floor left room");
            storageList.Add(storageOne);
            ShelvingUnit shelfOne = new ShelvingUnit("Floor");
            ShelvingUnit shelfTwo = new ShelvingUnit("wooden shelving on right");
            shelfOne.ShelfLevels = 1;
            shelfTwo.ShelfLevels = 5;
            List<TierLevel> levelListShelfOne = new List<TierLevel>();

            storageOne.ShelfsInStorage.Add(shelfOne);
            storageOne.ShelfsInStorage.Add(shelfTwo);
          
            foreach (ShelvingUnit c in storageOne.ShelfsInStorage)
            {
                for (int i = 0; i <= c.ShelfLevels; i++)
                {
                    TierLevel tierLevel = new TierLevel();
                    levelListShelfOne.Add(tierLevel);
                    tierLevel.TierLevelId = i;
                }
            }



            



            throw new NotImplementedException();
        }
    }
}
