using GarangeInventory.Storage;
using GarangeInventory.XmlData;

namespace BlazorGI.Data
{
    public class DataService
    {
        private List<StorageUnit>? _storages;

        public List<StorageUnit>? Storages
        {
            get
            {
                if (_storages == null)
                {
                    _storages = new List<StorageUnit>();
                    LoadStoragesFromFile();
                }
                return _storages;
            }
        }

        public void LoadStoragesFromFile()
        {
            _storages = Serialize.DeserializeStorageUnitList(GarangeInventory.Enum.AppFilePath.BlazorGI);
        }

        public void AddStorageUnit(string storageUnitName, User user)
        {
            StorageUnit storageUnit = new StorageUnit();
            storageUnit.Name = storageUnitName;
            storageUnit.Users.Add(user);
            Storages.Add(storageUnit);
        }


    }
}
