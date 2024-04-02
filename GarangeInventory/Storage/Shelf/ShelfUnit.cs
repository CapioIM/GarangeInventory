using GarangeInventory.Common;

namespace GarangeInventory.Storage.Shelf
{
    public class ShelfUnit
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public int ShelfLevelCount
        {
            get { return _containsLevels.Count; }

        }

        private List<TierLevel> _containsLevels = new();

        public List<TierLevel> ContainsLevels
        {
            get { return _containsLevels; }
            set { _containsLevels = value; }
        }

 
        private Notes _note = new();

        public Notes Notes
        {
            get { return _note; }
            set { _note = value; }
        }
        public ShelfUnit(string name)
        {
            _name = name;
        }
    }
}
