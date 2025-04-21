using GarangeInventory.Storage;

namespace GarangeInventory.DataOperations
{
    public class SaveData
    {
        public List<User> users { get; set; }
        public List<StorageUnit> storageUnits { get; set; }
        public List<Item> items { get; set; }
    }
}
