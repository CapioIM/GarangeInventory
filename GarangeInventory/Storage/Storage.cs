using GarangeInventory.Storage.Shelf;

namespace GarangeInventory.Storage
{
    public class Storage
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
		private List<ShelvingUnit> _shelfs;

		public List<ShelvingUnit> Shelfs
        {
			get { return _shelfs; }
			set { _shelfs = value; }
		}

        private List<UserName> _containsUsers;

        public List<UserName> ContainsUsers
        {
            get { return _containsUsers; }
            set { _containsUsers = value; }
        }
		public Storage(string name)
		{
			Name = name;
		}
    }
}
