using GarangeInventory.DataOperations;
using GarangeInventory.Enum;
using GarangeInventory.Storage;

namespace GarangeInventory
{
    public class TestData
    {
        public static List<StorageUnit> TestDataStorageUnits()
        {
            List<StorageUnit> storageUnits = new List<StorageUnit>();
            return storageUnits = GenerateItems();
        }

        private static List<StorageUnit> GenerateItems()
        {

            List<StorageUnit> storageUnitList = new List<StorageUnit>();

            StorageUnit emptyStorageUnit = CreateStorageUnit("EmptyStorageUnit", storageUnitList);
            emptyStorageUnit.ID = 0;
            emptyStorageUnit.ShelfUnits[0].ID = 54;
            emptyStorageUnit.ShelfUnits[0].Shelfs[0].ID = 55;
            int emptyShelfUnitShelfAmount = 2;
            ShelfUnit emptyShelfUnit = new ShelfUnit("EmptyShelfUnit", emptyShelfUnitShelfAmount);
            emptyShelfUnit.ID = 10;
            emptyShelfUnit.Shelfs[0].ID = 13;
            emptyShelfUnit.Shelfs[1].ID = 14;
            emptyStorageUnit.ShelfUnits.Add(emptyShelfUnit);
            Box emptyBox = new Box("EmptyBox");
            emptyBox.ID = 11;
            emptyShelfUnit.Boxes.Add(emptyBox);
            Item emptyItem = new Item("EmptyItem", 0, Category.CarParts);
            emptyItem.ID = 12;
            emptyBox.Items.Add(emptyItem);

            StorageUnit storageOne = CreateStorageUnit("2nd Floor left room", storageUnitList);
            storageOne.ShelfUnits[0].ID = 56;
            storageOne.ShelfUnits[0].Shelfs[0].ID = 57;
            storageOne.ID = 1;
            ShelfUnit shelfUnitOne = new ShelfUnit("Floor",1);
            shelfUnitOne.ID = 15;
            shelfUnitOne.Shelfs[0].ID = 16;
            storageOne.ShelfUnits.Add(shelfUnitOne);
            ShelfUnit shelfUnitTwo = new ShelfUnit("wooden shelf unit on right", 5);
            shelfUnitTwo.ID = 17;
            shelfUnitTwo.Shelfs[0].ID = 18;
            shelfUnitTwo.Shelfs[1].ID = 19;
            shelfUnitTwo.Shelfs[2].ID = 20;
            shelfUnitTwo.Shelfs[3].ID = 21;
            shelfUnitTwo.Shelfs[4].ID = 22;
            storageOne.ShelfUnits.Add(shelfUnitTwo);

            Box box = new Box("Blue stackable box");
            box.ID = 23;
            shelfUnitOne.Boxes.Add(box);

            Item item1 = new Item("4 pin A and B connectors", 3, Category.SolderingAccessories);
            item1.ID = 2;
            box.Items.Add(item1);

            Item item2 = new Item("3 pin A and B connectors", 2, Category.SolderingAccessories);
            item2.ID = 3;
            box.Items.Add(item2);

            Item item3 = new Item("2 pin A and B connectors", 2, Category.SolderingAccessories);
            item3.ID = 4;
            box.Items.Add(item3);

            Item item4 = new Item("1.5cm width double sided tape", 1, Category.SolderingAccessories);
            item4.ID = 5;
            box.Items.Add(item4);

            Item item5 = new Item("2cm width masking tape", 1, Category.Other);
            item5.ID = 6;
            box.Items.Add(item5);

            Item item6 = new Item("5cm width some kind rubbish tape", 1, Category.Other);
            item6.ID = 7;
            box.Items.Add(item6);

            Item item7 = new Item("1mm solder wire with flux", 1, Category.SolderingAccessories);   
            item7.ID = 8;
            box.Items.Add(item7);

            Item item8 = new Item("sponges to clean solder tip", 4, Category.SolderingAccessories);
            item8.ID = 9;
            box.Items.Add(item8);

            Shelf shelfTwoTierFour = shelfUnitTwo.Shelfs[4];
            Box boxOrange = new Box("Orange box");
            boxOrange.ID = 24;
            shelfTwoTierFour.Boxes.Add(boxOrange);

            Item item9 = new Item("crocodile wire clamps", 15, Category.Other);
            item9.ID = 25;
            item9.ItemCategory = Category.ElectricalEquipment;
            boxOrange.Items.Add(item9);

            Box box3 = new Box("Transparent box");
            box3.ID = 26;
            shelfTwoTierFour.Boxes.Add(box3);

            Item item10 = new Item("270 green o-ring assortment set", 1, Category.Other);
            item10.ID = 27;
            box3.Items.Add(item10);

            Item item11 = new Item("18650 VTC6 3000 mah Li-ion batteries", 9, Category.Other);
            item11.ID = 28;
            box3.Items.Add(item11);

            Item item12 = new Item("Blank remote car key", 4, Category.CarElecticalEquipment);
            item12.ID = 29;
            item12.Note = "no chip,no blade,no battery";
            box3.Items.Add(item12);

            Item item13 = new Item("Volvo rear Number Plate Light with camera", 1, Category.CarElecticalEquipment);
            item13.ID = 30;
            box3.Items.Add(item13);

            Item item14 = new Item("remote car key tool", 1, Category.CarElecticalEquipment);
            item14.ID = 31;
            item14.Note = "Device generates remote keys";
            box3.Items.Add(item14);

            Item item15 = new Item("Blank remote car key", 7, Category.CarElecticalEquipment);
            item15.ID = 32;
            item15.Note = "universal remote, no chip, no blade";
            box3.Items.Add(item15);

            Item item16 = new Item("Various car interior Led Lights bag", 1, Category.CarElecticalEquipment);
            item16.ID = 33;
            box3.Items.Add(item16);

            Item item17 = new Item("Old Laptop", 1, Category.ElectricalEquipment);
            item17.ID = 34;
            shelfTwoTierFour.Items.Add(item17);

            Item item18 = new Item("Pickled gerkins", 2, Category.Food);
            item18.ID = 34;
            shelfTwoTierFour.Items.Add(item18);
            item18.Expiry = new DateTime(2025, 12, 30);

            Box box4 = new Box("carton box");
            box4.ID = 35;
            shelfUnitOne.Boxes.Add(box4);

            Item item19 = new Item("wire split connector (1 in to 3)", 9, Category.SolderingAccessories);
            item19.ID = 36;
            box4.Items.Add(item19);

            Item item20 = new Item("wire split connector (1 in to 4)", 9, Category.SolderingAccessories);
            item20.ID = 37;
            box4.Items.Add(item20);

            Item item21 = new Item("wire split connector (2 in to 4", 2, Category.SolderingAccessories);
            item21.ID = 38;
            box4.Items.Add(item21);

            Item item22 = new Item("wire split connector(2 in to 6)", 2, Category.SolderingAccessories);
            item22.ID = 39;
            box4.Items.Add(item22);

            Item item23 = new Item("box of small alligator clips", 1, Category.SolderingAccessories);
            item23.ID = 40;
            box4.Items.Add(item23);

            Box box5 = new Box("AppleBox");
            box5.ID = 41;
            shelfUnitOne.Boxes.Add(box5);

            Item item24 = new Item("Apples", 6, Category.Food);
            item24.ID = 42;
            box5.Items.Add(item24);
            item24.Expiry = new DateTime(2024, 4, 1);

            Box box6 = new Box("Bag With Tools");
            box6.ID = 43;
            shelfUnitOne.Boxes.Add(box6);
            Item item25 = new Item("Volvo s80 Wishbone(both sides)", 1, Category.CarParts);
            item25.ID = 44;
            box6.Items.Add(item25);
            Item item26 = new Item("Electric Ratchet Power Tool 12V", 1, Category.ElectricTools);
            item26.ID = 45;
            box6.Items.Add(item26);
            Item Item27 = new Item("Impact Driver 20v", 1, Category.ElectricTools);
            Item27.ID = 46;
            box6.Items.Add(Item27);

            Item item28onTheShelfUnit = new Item("Item 28, ShelfUnit.Items",
                                1, Category.Other);
            item28onTheShelfUnit.ID = 47;
            item28onTheShelfUnit.Expiry = new DateTime(2020, 1, 1);
            shelfUnitOne.Items.Add(item28onTheShelfUnit);

            StorageUnit Storage2GardenShed = CreateStorageUnit("Garden Shed", storageUnitList);
            Storage2GardenShed.ID = 48;
            Storage2GardenShed.ShelfUnits[0].ID = 58;
            Storage2GardenShed.ShelfUnits[0].Shelfs[0].ID = 59;
            ShelfUnit gardenShedLeft = new ShelfUnit("Left Unit", 4);
            gardenShedLeft.ID = 49;
            gardenShedLeft.Shelfs[0].ID = 50;
            gardenShedLeft.Shelfs[1].ID = 51;
            gardenShedLeft.Shelfs[2].ID = 52;
            gardenShedLeft.Shelfs[3].ID = 53;
            Storage2GardenShed.ShelfUnits.Add(gardenShedLeft);

            return storageUnitList;
        }

        public static List<User> TestDataUsers()
        {
            int userIDTest = 0;
            List<User> users = new List<User>();
            users.Add(AddUser("Jurijs", userIDTest));
            userIDTest++;
            users.Add(AddUser("Igor", userIDTest));
            return users;
        }

        private static User AddUser(string name, int idNumber)
        {
            User user = new User();
            user.Name = name;
            user.ID = idNumber;
            return user;
        }

        private static StorageUnit CreateStorageUnit(string name, List<StorageUnit> storages)
        {
            StorageUnit newUnit = new StorageUnit(name);
            storages.Add(newUnit);
            return newUnit;
        }


        public static void ShowNames(List<StorageUnit> storages)
        {
            for (int i = 0; i < storages.Count; i++)
            {
                StorageUnit storage = storages[i];
                Console.Write("Storage: ");
                Console.WriteLine(storage.Name);
                for (int j = 0; j < storage.ShelfUnits.Count; j++)
                {
                    ShelfUnit shelfUnit = storage.ShelfUnits[j];
                    Console.Write("ShelfUnit: ");
                    Console.WriteLine(shelfUnit.Name);
                    for (int p = 0; p < shelfUnit.Shelfs.Count; p++)
                    {
                        Shelf shelf = shelfUnit.Shelfs[p];
                        Console.Write($"Shelf: +{shelf.ID} ");
                        Console.WriteLine(shelf.Name);
                    }
                }
            }
        }

    }
}
