using GarangeInventory.Storage;
using GarangeInventory.Storage.Shelf;
using GarangeInventory.DataOperations;
using GarangeInventory.Enum;

namespace WebGI.Data
{
    public class DataService
    {
        private SaveData? _saveData = new SaveData();

        public SaveData saveData
        {
            get { return _saveData; }
            set { _saveData = value; }
        }

        private List<StorageUnit>? _storages;

        public List<StorageUnit> Storages
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
            set { _storages = value; }
        }

        /// <summary>
        /// deserialize from SaveData in to _storages
        /// </summary>
        public void LoadStoragesFromFile()
        {
            _saveData = Serialize.LoadSaveData(SerializationAppFilePath.BlazorGI);
            _storages = _saveData.storageUnits;
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
            int assignID = Storages.Max(s => s.ID);
            storageUnit.ID = assignID + 1;
            Storages.Add(storageUnit);
            SaveStorageUnits();
        }

        public void RemoveStorageUnit(int storageUnitID)
        {
            StorageUnit storageUnit = Storages.Where(s => s.ID == storageUnitID).First();
            Storages.Remove(storageUnit);
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
        public void SaveStorageUnits()
        {
            Serialize.SaveData(_saveData, SerializationAppFilePath.BlazorGI);
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
            SaveStorageUnits();
        }

        /// <summary>
        /// add New Box to shelf
        /// </summary>
        /// <param name="shelf">Shelf where to add new box</param>
        /// <param name="name"> Name of box </param>
        public void AddBoxToShelf(Shelf shelf, string name)
        {
            Box box = new Box(name);
            shelf.Boxes.Add(box);
        }

        /// <summary>
        /// Add Box to ShelfUnit
        /// </summary>
        /// <param name="shelfUnit"> Unit where to add box </param>
        /// <param name="name"> Name of box </param>
        public void AddBoxToShelfUnit(ShelfUnit shelfUnit, string name)
        {
            Box box = new Box(name);
            shelfUnit.Boxes.Add(box);
        }
    }
}
