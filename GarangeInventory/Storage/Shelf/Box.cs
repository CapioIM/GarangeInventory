using GarangeInventory.Common;
using GarangeInventory.Enum;


namespace GarangeInventory.Storage.Shelf
{
    public class Box
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private SizeType _type;

        public SizeType Type
        {
            get { return _type; }
            set { _type = value; }
        }
        private Notes _note;

        public Notes Note
        {
            get { return _note; }
            set { _note = value; }
        }

        private string _definitiveFeature;

        public string DefinitiveFeature
        {
            get { return _definitiveFeature; }
            set { _definitiveFeature = value; }
        }

        private PictureFilePath _path;

        public PictureFilePath Path
        {
            get { return _path; }
            set { _path = value; }
        }
        public Box(string name)
        {
            _name = name;
        }

        private List<Item> _items = new();

        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }


    }
}
