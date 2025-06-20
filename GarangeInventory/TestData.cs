﻿using GarangeInventory.Enum;
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

            ItemIdCounter iDCounter = new ItemIdCounter();
            List<StorageUnit> storageUnitList = new List<StorageUnit>();

            StorageUnit emptyStorageUnit = CreateStorageUnit("EmptyStorageUnit", storageUnitList);
            emptyStorageUnit.ID = 0;
            int emptyShelfUnitShelfAmount = 1;
            ShelfUnit emptyShelfUnit = new ShelfUnit("EmptyShelfUnit", emptyShelfUnitShelfAmount);
            emptyStorageUnit.ShelfUnits.Add(emptyShelfUnit);
            Box emptyBox = new Box("EmptyBox");
            emptyShelfUnit.Boxes.Add(emptyBox);
            Item emptyItem = new Item("EmptyItem", 0, Category.CarParts, iDCounter);
            emptyBox.Items.Add(emptyItem);

            StorageUnit storageOne = CreateStorageUnit("2nd Floor left room", storageUnitList);
            storageOne.ID = 1;
            ShelfUnit shelfUnitOne = storageOne.ShelfUnits[0];
            ShelfUnit shelfUnitTwo = new ShelfUnit("wooden shelf unit on right", 5);
            storageOne.ShelfUnits.Add(shelfUnitTwo);

            Box box = new Box("Blue stackable box");
            shelfUnitOne.Boxes.Add(box);

            Item item1 = new Item("4 pin A and B connectors", 3, Category.SolderingAccessories, iDCounter);
            box.Items.Add(item1);

            Item item2 = new Item("3 pin A and B connectors", 2, Category.SolderingAccessories, iDCounter);
            box.Items.Add(item2);

            Item item3 = new Item("2 pin A and B connectors", 2, Category.SolderingAccessories, iDCounter);
            box.Items.Add(item3);

            Item item4 = new Item("1.5cm width double sided tape", 1, Category.SolderingAccessories, iDCounter);
            box.Items.Add(item4);

            Item item5 = new Item("2cm width masking tape", 1, Category.Other, iDCounter);
            box.Items.Add(item5);

            Item item6 = new Item("5cm width some kind rubbish tape", 1, Category.Other, iDCounter);
            box.Items.Add(item6);

            Item item7 = new Item("1mm solder wire with flux", 1, Category.SolderingAccessories, iDCounter);
            box.Items.Add(item7);

            Item item8 = new Item("sponges to clean solder tip", 4, Category.SolderingAccessories, iDCounter);
            box.Items.Add(item8);

            var shelfTwoTierFour = shelfUnitTwo.Shelfs[4];
            var boxOrange = new Box("Orange box");
            shelfTwoTierFour.Boxes.Add(boxOrange);

            Item item9 = new Item("crocodile wire clamps", 15, Category.Other, iDCounter);
            item9.ItemCategory = Category.ElectricalEquipment;
            boxOrange.Items.Add(item9);

            var box3 = new Box("Transparent box");
            shelfTwoTierFour.Boxes.Add(box3);

            Item item10 = new Item("270 green o-ring assortment set", 1, Category.Other, iDCounter);
            box3.Items.Add(item10);

            Item item11 = new Item("18650 VTC6 3000 mah Li-ion batteries", 9, Category.Other, iDCounter);
            box3.Items.Add(item11);

            Item item12 = new Item("Blank remote car key", 4, Category.CarElecticalEquipment, iDCounter);
            item12.Note.Text = "no chip,no blade,no battery";
            box3.Items.Add(item12);

            Item item13 = new Item("Volvo rear Number Plate Light with camera", 1, Category.CarElecticalEquipment, iDCounter);
            box3.Items.Add(item13);

            Item item14 = new Item("remote car key tool", 1, Category.CarElecticalEquipment, iDCounter);
            item14.Note.Text = "Device generates remote keys";
            box3.Items.Add(item14);

            Item item15 = new Item("Blank remote car key", 7, Category.CarElecticalEquipment, iDCounter);
            item15.Note.Text = "universal remote, no chip, no blade";
            box3.Items.Add(item15);

            Item item16 = new Item("Various car interior Led Lights bag", 1, Category.CarElecticalEquipment, iDCounter);
            box3.Items.Add(item16);

            Item item17 = new Item("Old Laptop", 1, Category.ElectricalEquipment, iDCounter);
            shelfTwoTierFour.Items.Add(item17);

            Item item18 = new Item("Pickled gerkins", 2, Category.Food, iDCounter);
            shelfTwoTierFour.Items.Add(item18);
            item18.Expiry = new DateTime(2025, 12, 30);

            Box box4 = new Box("carton box");
            shelfUnitOne.Boxes.Add(box4);

            Item item19 = new Item("wire split connector (1 in to 3)", 9, Category.SolderingAccessories, iDCounter);
            box4.Items.Add(item19);

            Item item20 = new Item("wire split connector (1 in to 4)", 9, Category.SolderingAccessories, iDCounter);
            box4.Items.Add(item20);

            Item item21 = new Item("wire split connector (2 in to 4", 2, Category.SolderingAccessories, iDCounter);
            box4.Items.Add(item21);

            Item item22 = new Item("wire split connector(2 in to 6)", 2, Category.SolderingAccessories, iDCounter);
            box4.Items.Add(item22);

            Item item23 = new Item("box of small alligator clips", 1, Category.SolderingAccessories, iDCounter);
            box4.Items.Add(item23);

            Box box5 = new Box("AppleBox");
            shelfUnitOne.Boxes.Add(box5);

            Item item24 = new Item("Apples", 6, Category.Food, iDCounter);
            box5.Items.Add(item24);
            item24.Expiry = new DateTime(2024, 4, 1);

            Box box6 = new Box("Bag With Tools");
            shelfUnitOne.Boxes.Add(box6);
            Item item25 = new Item("Volvo s80 Wishbone(both sides)", 1, Category.CarParts, iDCounter);
            box6.Items.Add(item25);
            Item item26 = new Item("Electric Ratchet Power Tool 12V", 1, Category.ElectricTools, iDCounter);
            box6.Items.Add(item26);
            Item Item27 = new Item("Impact Driver 20v", 1, Category.ElectricTools, iDCounter);
            box6.Items.Add(Item27);

            Item item28onTheShelfUnit = new Item("Item 28, ShelfUnit.Items",
                                1, Category.Other, iDCounter);
            item28onTheShelfUnit.Expiry = new DateTime(2020, 1, 1);
            shelfUnitOne.Items.Add(item28onTheShelfUnit);

            StorageUnit storageTwo = CreateStorageUnit("Garden Shed", storageUnitList);
            storageTwo.ID = 2;
            ShelfUnit gardenShedLeft = new ShelfUnit("Left Unit", 4);

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

        public static List<Item> GetAllItems(List<StorageUnit> storages)
        {
            List<Item> result = new List<Item>();
            foreach (StorageUnit storage in storages)
            {
                foreach (ShelfUnit shelfUnits in storage.ShelfUnits)
                {
                    result.AddRange(AddItems(shelfUnits.Items));
                    foreach (Shelf shelf in shelfUnits.Shelfs)
                    {
                        result.AddRange(AddItems(shelf.Items));
                        foreach (Box box in shelf.Boxes)
                        {
                            result.AddRange(AddItems(box.Items));
                        }
                    }
                    foreach (Box box in shelfUnits.Boxes)
                    {
                        result.AddRange(AddItems(box.Items));
                    }
                }
            }
            return result;
        }

        private static List<Item> AddItems(List<Item> items)
        {
            List<Item> result = new List<Item>();
            if (items != null)
            {
                foreach (Item item in items)
                {
                    if (item != null)
                    {
                        result.Add(item);
                    }
                }
            }
            return result;
        }

    }
}
