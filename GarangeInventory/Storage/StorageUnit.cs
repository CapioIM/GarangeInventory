using GarangeInventory.Storage.Shelf;

namespace GarangeInventory.Storage
{
    public class StorageUnit
    {
		private int _idNumber;

		public int IdNumber
		{
			get { return _idNumber; }
			set { _idNumber = value; }
		}

		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
		private List<ShelvingUnit> _shelfUnitsInStorage;

		public List<ShelvingUnit> ShelfUnitsInStorage
        {
			get { return _shelfUnitsInStorage; }
			set { _shelfUnitsInStorage = value; }
		}

        private List<UserName> _containsUsers;

        public List<UserName> ContainsUsers
        {
            get { return _containsUsers; }
            set { _containsUsers = value; }
        }
		public StorageUnit(string name)
		{
			Name = name;
		}
    }
}
