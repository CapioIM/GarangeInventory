using GarangeInventory.Common;


namespace GarangeInventory.Storage.Shelf
{
    public class Shelf
    {

        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private List<Box> _boxes = new();

        public List<Box> Boxes
        {
            get { return _boxes; }
            set { _boxes = value; }
        }
        private List<Item> _items = new();

        public List<Item> Items

        {
            get { return _items; }
            set { _items = value; }
        }
        private Note _note;

        public Note Notes
        {
            get { return _note; }
            set { _note = value; }
        }


    }
}
