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
            ShelvingUnit shelfUnitOne = new ShelvingUnit("Floor");
            ShelvingUnit shelfUnitTwo = new ShelvingUnit("wooden shelving on right");
            shelfUnitOne.ShelfLevels = 1;
            shelfUnitTwo.ShelfLevels = 5;
            List<TierLevel> levelListShelfOne = new List<TierLevel>();

            storageOne.ShelfUnitsInStorage.Add(shelfUnitOne);
            storageOne.ShelfUnitsInStorage.Add(shelfUnitTwo);
          
            foreach (ShelvingUnit shelfUnit in storageOne.ShelfUnitsInStorage)
            {
                for (int i = 0; i < shelfUnit.ShelfLevels; i++)
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
