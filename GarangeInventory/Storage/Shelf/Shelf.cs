using GarangeInventory.Common;


namespace GarangeInventory.Storage.Shelf
{
    public class Shelf
    {
        public Shelf() { }
        public Shelf(string shelfNumber)
        {
            Name = shelfNumber;
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
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
