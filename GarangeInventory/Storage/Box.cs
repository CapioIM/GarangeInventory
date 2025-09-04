using GarangeInventory.Common;
using GarangeInventory.Enum;


namespace GarangeInventory.Storage
{
    public class Box : StorageObject
    {
        public Box() { }

        private SizeType _type;

        public SizeType Type
        {
            get { return _type; }
            set { _type = value; }
        }
        private string _definitiveFeature;

        public string DefinitiveFeature
        {
            get { return _definitiveFeature; }
            set { _definitiveFeature = value; }
        }

        private List<Item> _items = new();

        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }
        public Box(string name)
        {
           Name = name;
        }


    }
}
