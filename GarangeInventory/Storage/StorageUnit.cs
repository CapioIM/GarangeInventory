using GarangeInventory.Storage.Shelf;

namespace GarangeInventory.Storage
{
    public class StorageUnit
    {
		public StorageUnit() { }

		private int _id;

		public int ID
		{
			get { return _id; }
			set { _id = value; }
		}

		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
		private List<ShelfUnit> _shelfUnits = new();

		public List<ShelfUnit> ShelfUnits
        {
			get { return _shelfUnits; }
			set { _shelfUnits = value; }
		}

		private string picturePath;

		public string PicturePath
		{
			get { return picturePath; }
			set { picturePath = value; }
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
