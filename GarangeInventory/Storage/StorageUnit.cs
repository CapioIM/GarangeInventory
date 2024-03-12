using GarangeInventory.Storage;
using GarangeInventory.Storage.ShelvingUnit;

namespace GarangeInventory.StorageUnit
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
    }
}
