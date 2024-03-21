﻿using GarangeInventory.Storage.Shelf.Items;
using GarangeInventory.Storage.Shelf;
using GarangeInventory.Storage;
using GarangeInventory.Storage.Shelf.Boxes;
using GarangeInventory.Common;
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

            Item item4 = new Item("1.5cm double sided tape", 1);
            box.ItemsList.Add(item4);

            Item item5 = new Item("2cm masking tape", 1);
            box.ItemsList.Add(item5);

            Item item6 = new Item("5cm some kind rubbish tape", 1);
            box.ItemsList.Add(item6);

            Item item7 = new Item("1mm solder wire with flux",1);
            box.ItemsList.Add(item7);

            Item item8 = new Item("sponges to clean solder tip", 4);
            box.ItemsList.Add(item8);

            var tierLevel2 = shelfUnitTwo.ContainsLevels[4];
            var boxOrange = new Box("Orange box");
            tierLevel2.ContainsBoxes.Add(boxOrange);

            Item item9 = new Item("crocodile wire clamps", 15);
            boxOrange.ItemsList.Add(item9);

            var box3 = new Box("Transparent box");
            tierLevel2.ContainsBoxes.Add(box3);

            Item item10 = new Item("270 green o-ring assortment set", 1);
            box3.ItemsList.Add(item10);

            Item item11 = new Item("18650 VTC6 3000 mah Li-ion batteries", 9);
            box3.ItemsList.Add(item11);

            Item item12 = new Item("Blank remote car key", 4);
            item12.Notes.Note = "no chip,no blade,no battery";
            item12.ItemCategory = Category.CarElecticalEquipment;
            box3.ItemsList.Add(item12);

            Item item13 = new Item("Volvo rear Number Plate Light with camera", 1);
            item13.ItemCategory = Category.CarElecticalEquipment;
            box3.ItemsList.Add(item13);

            Item item14 = new Item("remote car key tool", 1);
            item14.ItemCategory = Category.CarElecticalEquipment;
            item14.Notes.Note = "Device generates remote keys";
            box3.ItemsList.Add(item14);

            Item item15 = new Item("Blank remote car key", 7);
            item15.ItemCategory = Category.CarElecticalEquipment;
            item15.Notes.Note = "universal remote, no chip, no blade";
            box3.ItemsList.Add(item15);

            Item item16 = new Item("Various car interior Led Lights bag", 1);
            item16.ItemCategory = Category.CarElecticalEquipment;
            box3.ItemsList.Add(item16);


            throw new NotImplementedException();
        }
    }
}
