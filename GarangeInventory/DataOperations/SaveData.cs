using GarangeInventory.Storage;

namespace GarangeInventory.DataOperations
{
    public class SaveData
    {
        public List<User> users { get; set; }
        public List<StorageUnit> storageUnits { get; set; }
        private static int _id = 1;
        public static int ID
        {
            get {
                if (_id == 0)
                    Serialize.LoadSaveData(Enum.SerializationAppFilePath.GarageInventory);
                return _id; 
            }
            set { _id = value; }
        }


        public static int GetID()
        {
            ID++;
            return _id;
        }
    }
}
