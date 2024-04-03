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
            get { return _shelfs.Count; }

        }

        private List<Shelf> _shelfs = new();

        public List<Shelf> Shelfs
        {
            get { return _shelfs; }
            set { _shelfs = value; }
        }
 
        private Note _note = new();

        public Note Note
        {
            get { return _note; }
            set { _note = value; }
        }

        private List<Box> _boxes;

        public List<Box> Boxes
        {
            get { return _boxes; }
            set { _boxes = value; }
        }

        private List<Item> _items;

        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        public ShelfUnit(string name)
        {
            _name = name;
        }

    }
}
