using GarangeInventory.Common;
using GarangeInventory.Enum;
using GarangeInventory.Storage.Shelf;


namespace GarangeInventory.Storage
{
    public class Box : StorageObject
    {
        public Box() { }

        public Box(string name)
        {
           Name = name;
        }

        private SizeType _type;

        public SizeType Type
        {
            get { return _type; }
            set { _type = value; }
        }
        private Note _note;

        public Note Note
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

        private List<Item> _items = new();

        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

    }
}
