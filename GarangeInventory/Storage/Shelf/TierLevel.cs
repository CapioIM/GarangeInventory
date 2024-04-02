using GarangeInventory.Common;


namespace GarangeInventory.Storage.Shelf
{
    public class TierLevel
    {

        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private List<Box> _containsBoxes = new();

        public List<Box> ContainsBoxes
        {
            get { return _containsBoxes; }
            set { _containsBoxes = value; }
        }
        private List<Item> _items = new();

        public List<Item> Items

        {
            get { return _items; }
            set { _items = value; }
        }
        private Notes _note;

        public Notes Notes
        {
            get { return _note; }
            set { _note = value; }
        }


    }
}
