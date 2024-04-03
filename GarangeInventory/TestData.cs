using GarangeInventory.Enum;
using GarangeInventory.Storage.Shelf;
using GarangeInventory.Storage;
using GarangeInventory.Common;

namespace GarangeInventory
{
    public class TestData
    {
        public List<StorageUnit> GenerateItems()
        {
            List<StorageUnit> storageUnitList = new List<StorageUnit>();
            StorageUnit storageOne = new StorageUnit("2nd Floor left room");
            storageUnitList.Add(storageOne);

            ShelfUnit shelfUnitOne = new ShelfUnit("Floor");
            storageOne.ShelfUnits.Add(shelfUnitOne);

            ShelfUnit shelfUnitTwo = new ShelfUnit("wooden shelf unit on right");
            storageOne.ShelfUnits.Add(shelfUnitTwo);

            Shelf tierLevel1 = shelfUnitOne.Shelfs[0];
            Box box = new Box("Blue stackable box");
            tierLevel1.Boxes.Add(box);

            Item item1 = new Item("4 pin A and B connectors", 3, Category.SolderingAccessories);
            box.Items.Add(item1);

            Item item2 = new Item("3 pin A and B connectors", 2, Category.SolderingAccessories);
            box.Items.Add(item2);

            Item item3 = new Item("2 pin A and B connectors", 2, Category.SolderingAccessories);
            box.Items.Add(item3);

            Item item4 = new Item("1.5cm width double sided tape", 1, Category.SolderingAccessories);
            box.Items.Add(item4);

            Item item5 = new Item("2cm width masking tape", 1, Category.Other);
            box.Items.Add(item5);

            Item item6 = new Item("5cm width some kind rubbish tape", 1, Category.Other);
            box.Items.Add(item6);

            Item item7 = new Item("1mm solder wire with flux", 1, Category.SolderingAccessories);
            box.Items.Add(item7);

            Item item8 = new Item("sponges to clean solder tip", 4, Category.SolderingAccessories);
            box.Items.Add(item8);

            var shelfTwoTierFour = shelfUnitTwo.Shelfs[4];
            var boxOrange = new Box("Orange box");
            shelfTwoTierFour.Boxes.Add(boxOrange);

            Item item9 = new Item("crocodile wire clamps", 15, Category.Other);
            item9.ItemCategory = Category.ElectricalEquipment;
            boxOrange.Items.Add(item9);

            var box3 = new Box("Transparent box");
            shelfTwoTierFour.Boxes.Add(box3);

            Item item10 = new Item("270 green o-ring assortment set", 1, Category.Other);
            box3.Items.Add(item10);

            Item item11 = new Item("18650 VTC6 3000 mah Li-ion batteries", 9, Category.Other);
            box3.Items.Add(item11);

            Item item12 = new Item("Blank remote car key", 4, Category.CarElecticalEquipment);
            item12.Note.Text = "no chip,no blade,no battery";
            box3.Items.Add(item12);

            Item item13 = new Item("Volvo rear Number Plate Light with camera", 1, Category.CarElecticalEquipment);
            box3.Items.Add(item13);

            Item item14 = new Item("remote car key tool", 1, Category.CarElecticalEquipment);
            item14.Note.Text = "Device generates remote keys";
            box3.Items.Add(item14);

            Item item15 = new Item("Blank remote car key", 7, Category.CarElecticalEquipment);
            item15.Note.Text = "universal remote, no chip, no blade";
            box3.Items.Add(item15);

            Item item16 = new Item("Various car interior Led Lights bag", 1, Category.CarElecticalEquipment);
            box3.Items.Add(item16);

            Item item17 = new Item("Old Laptop", 1, Category.ElectricalEquipment);
            shelfTwoTierFour.Items.Add(item17);

            Item item18 = new Item("Pickled gerkins", 2, Category.Food);
            shelfTwoTierFour.Items.Add(item18);
            item18.Expiry = new DateTime(2025, 12, 30);

            Box box4 = new Box("carton box");
            tierLevel1.Boxes.Add(box4);

            Item item19 = new Item("wire split connector (1 in to 3)", 9, Category.SolderingAccessories);
            box4.Items.Add(item19);

            Item item20 = new Item("wire split connector (1 in to 4)", 9, Category.SolderingAccessories);
            box4.Items.Add(item20);

            Item item21 = new Item("wire split connector (2 in to 4", 2, Category.SolderingAccessories);
            box4.Items.Add(item21);

            Item item22 = new Item("wire split connector(2 in to 6)", 2, Category.SolderingAccessories);
            box4.Items.Add(item22);

            Item item23 = new Item("box of small alligator clips", 1, Category.SolderingAccessories);
            box4.Items.Add(item23);


            Box box5 = new Box("AppleBox");
            shelfUnitOne.Boxes.Add(box5);

            Item item24 = new Item("Apples", 6, Category.Food);
            box5.Items.Add(item24);
            item24.Expiry = new DateTime(2024, 4, 1);

            Box box6 = new Box("Bag With Tools");
            shelfUnitOne.Boxes.Add(box6);
            Item item25 = new Item("Volvo s80 Wishbone(both sides)", 1, Category.CarParts);
            box6.Items.Add(item25);
            Item item26 = new Item("Electric Ratchet Power Tool 12V", 1, Category.ElectricTools);
            box6.Items.Add(item26);
            Item Item27 = new Item("Impact Driver 20v", 1, Category.ElectricTools);
            box6.Items.Add(Item27);


            throw new NotImplementedException();
        }
    }
}
