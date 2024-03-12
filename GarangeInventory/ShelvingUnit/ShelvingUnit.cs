using GarangeInventory.Common;

namespace GarangeInventory.ShelvingUnit
{
    public class ShelvingUnit
    {
		private int _id;

		public int ID
		{
			get { return _id; }
			set { _id = value; }
		}
		private int _quantityOfTiers;

		public int QuantityOfTiers
		{
			get { return _quantityOfTiers; }
			set { _quantityOfTiers = value; }
		}
		private List<TierLevel> _containsTiers;

		public List<TierLevel> ContainsTiers
		{
			get { return _containsTiers; }
			set { _containsTiers = value; }
		}
		private string _user;

		public string User
		{
			get { return _user; }
			set { _user = value; }
		}

		private List<UserName> _containsUsers;

		public List<UserName> ContainsUsers
		{
			get { return _containsUsers; }
			set { _containsUsers = value; }
		}
		private Notes _note;

		public Notes Notes
		{
			get { return _note; }
			set { _note = value; }
		}

	}
}
