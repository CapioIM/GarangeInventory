using GarangeInventory.Storage;

namespace GarangeInventory.DataOperations
{
    public class SaveData
    {
        public List<User> users { get; set; }
        public List<StorageUnit> storageUnits { get; set; }
        private static int _ID = 1;
        public static int Id
        {
            get { return _ID; }
            set { _ID = value; }
        }


        public static int GenerateID()
        {
            Id++;
            return _ID;
        }
    }
}
