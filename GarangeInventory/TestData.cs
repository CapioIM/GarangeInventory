using GarangeInventory.Storage.Shelf.Items;
using GarangeInventory.Storage.Shelf;
using GarangeInventory.Storage;
using GarangeInventory.Storage.Shelf.Boxes;
namespace GarangeInventory
{
    public class TestData
    {
        public List<Item> GenerateItems()
        {
            List<StorageUnit> storageUnitList = new List<StorageUnit>();
            StorageUnit storageOne = new StorageUnit("2nd Floor left room");
            storageUnitList.Add(storageOne);

            ShelfUnit shelfUnitOne = new ShelfUnit("Floor");
            shelfUnitOne.ShelfLevels = 1;
            storageOne.ShelfUnitsInStorage.Add(shelfUnitOne);

            ShelfUnit shelfUnitTwo = new ShelfUnit("wooden shelf unit on right");
            shelfUnitTwo.ShelfLevels = 5;
            storageOne.ShelfUnitsInStorage.Add(shelfUnitTwo);

            foreach (StorageUnit storageUnit in storageUnitList)
            {
                foreach (ShelfUnit rack in storageUnit.ShelfUnitsInStorage)
                {
                    for (int i = 0; i < rack.ShelfLevels; i++)
                    {
                        TierLevel tierLevel = new TierLevel();
                        tierLevel.TierLevelId = i;
                        rack.ContainsLevels.Add(tierLevel);
                    }
                }
            }

            TierLevel tierLevel1 = shelfUnitOne.ContainsLevels[0];
            Box box = new Box("Blue stackable box");
            tierLevel1.ContainsBoxes.Add(box);

            Item item1 = new Item("4 pin A and B connectors", 3);
            box.ItemsList.Add(item1);

            Item item2 = new Item("3 pin A and B connectors", 2);
            box.ItemsList.Add(item2);

            Item item3 = new Item("2 pin A and B connectors", 2);
            box.ItemsList.Add(item3);

            throw new NotImplementedException();
        }
    }
}
