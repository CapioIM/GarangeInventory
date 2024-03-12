using GarangeInventory.Common;

namespace GarangeInventory.Storage.ShelvingUnit
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

        private Notes _note;

        public Notes Notes
        {
            get { return _note; }
            set { _note = value; }
        }

    }
}
