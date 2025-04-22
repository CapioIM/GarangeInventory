namespace GarangeInventory.Storage
{
    public class StorageUnit : StorageObject
    {
		public StorageUnit() { }

	
		private List<ShelfUnit> _shelfUnits = new();

		public List<ShelfUnit> ShelfUnits
        {
			get { return _shelfUnits; }
			set { _shelfUnits = value; }
		}

		private List<User> _users = new();

        public List<User> Users 
        {
            get { return _users; }
            set { _users = value; }
        }
		public StorageUnit(string name)
		{
			Name = name;
			ShelfUnit shelfUnit = new ShelfUnit("Floor",1);
			_shelfUnits.Add(shelfUnit);
		}
    }
}
