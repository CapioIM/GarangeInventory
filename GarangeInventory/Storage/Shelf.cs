using GarangeInventory.Common;


namespace GarangeInventory.Storage
{
    public class Shelf : StorageObject
    {
        public Shelf() { }
        public Shelf(string shelfNumber)
        {
            Name = shelfNumber;
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


    }
}
