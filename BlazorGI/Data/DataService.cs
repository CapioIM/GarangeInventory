using GarangeInventory.Storage;
using GarangeInventory.Storage.Shelf;
using GarangeInventory.XmlData;
using GarangeInventory.Enum;

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
            _storages = Serialize.DeserializeStorageUnitList(GarangeInventory.Enum.SerializationAppFilePath.BlazorGI);
        }

        /// <summary>
        /// Add new storageUnit to list of _storages
        /// </summary>
        /// <param name="storageUnitName">What you want to name this storage unit</param>
        /// <param name="user"> User who have access to this storage unit </param>
        public void AddStorageUnit(string storageUnitName, User user)
        {
            StorageUnit storageUnit = new StorageUnit();
            storageUnit.Name = storageUnitName;
            storageUnit.Users.Add(user);
            Storages.Add(storageUnit);
            Save();
        }

        public void AddUserToStorageUnit(User user, StorageUnit storageUnit)
        {
            storageUnit.Users.Add(user);
        }

        /// <summary>
        /// Add new ShelfUnit 
        /// </summary>
        /// <param name="shelfUnitName"> What is Name of ShelfUnit ( wooden rack on left) </param>
        /// <param name="storageUnit"> In which StorageUnit shelfUnit is located </param>
        /// <param name="amountOfShelfsInShelfUnit"> How many shelfs Unit has </param>
        public void AddShelfUnit(string shelfUnitName, StorageUnit storageUnit, int amountOfShelfsInShelfUnit)
        {
            ShelfUnit shelfUnit = new ShelfUnit(shelfUnitName, amountOfShelfsInShelfUnit);
            storageUnit.ShelfUnits.Add(shelfUnit);
        }

        /// <summary>
        /// Serialize data
        /// </summary>
        public void Save()
        {
            Serialize.SaveData(_storages, SerializationAppFilePath.BlazorGI);
        }

        /// <summary>
        /// Add new Shelf Unit
        /// </summary>
        /// <param name="storage"> which storage to add this shelf unit </param>
        /// <param name="name"> What shelfUnit will be named as </param>
        /// <param name="amountOfShelfs"> How many shelfs are there </param>
        public void AddShelfUnit(StorageUnit storage, string name, int amountOfShelfs)
        {
            ShelfUnit shelfUnit = new ShelfUnit(name, amountOfShelfs);
            storage.ShelfUnits.Add(shelfUnit);
            Save();
        }
        /*
        public void AddBox(string boxName,NewBoxNavigation newBoxNavigation)
        {
            Box box = new Box(boxName);

        }
        */
    }
}
