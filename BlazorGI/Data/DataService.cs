using GarangeInventory.Storage;
using GarangeInventory.XmlData;

namespace BlazorGI.Data
{
    public class DataService
    {
        private List<StorageUnit>? _storages = new List<StorageUnit>();

        public List<StorageUnit> Storages 
        {
            get
            {
                if (_storages == null)
                {
                    return _storages = new List<StorageUnit>();
                }
                return _storages;
            }
            set
            {
                _storages = GetStorages();
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

        private List<StorageUnit> GetStorages()
        {
            return Storages = Serialize.DeserializeStorageUnitList(GarangeInventory.Enum.AppFilePath.BlazorGI);
        }


    }
}
