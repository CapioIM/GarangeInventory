using GarangeInventory.Storage;
using GarangeInventory.XmlData;

namespace BlazorGI.Data
{
    public class DataService
    {
        private List<StorageUnit>? _storages ;

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

        private StorageUnit? _storage;

        public StorageUnit? Storage
        {
            get
            {
                if (_storage == null)
                {
                    return _storage;
                }
                return _storage;
            }
            set { _storage = value; }
        }

        private void LoadStoragesFromFile()
        {
            _storages = Serialize.DeserializeStorageUnitList(GarangeInventory.Enum.AppFilePath.BlazorGI);
        }

    }

}
