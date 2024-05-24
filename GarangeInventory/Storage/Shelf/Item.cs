using GarangeInventory.Common;
using GarangeInventory.Enum;
namespace GarangeInventory.Storage.Shelf
{
    public class Item
    {
        public Item() { }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _iD;

        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }


        private int _quantity;

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        private decimal _cost;

        public decimal Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        private float _weight;

        public float Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        private DateTime _expiry;

        public DateTime Expiry
        {
            get { return _expiry; }
            set { _expiry = value; }
        }
        private DateTime _purchaseDate;

        public DateTime PurchaseDate
        {
            get { return _purchaseDate; }
            set { _purchaseDate = value; }
        }

        private DateTime _itemCreationDate;

        public DateTime ItemCreationDate
        {
            get { return _itemCreationDate; }
        }

        private SizeType _size;

        public SizeType Size
        {
            get { return _size; }
            set { _size = value; }
        }
        private Note _note = new();

        public Note Note
        {
            get { return _note; }
            set { _note = value; }
        }

        private PictureFilePath _path = new();

        public PictureFilePath Path
        {
            get { return _path; }
            set { _path = value; }
        }

        private Category _itemCategory;
        public Category ItemCategory
        {
            get { return _itemCategory; }
            set { _itemCategory = value; }
        }

        private WeightType weightType;

        public WeightType WeightType
        {
            get { return weightType; }
            set { weightType = value; }
        }


        public Item(string name, int quantity, Category category,ItemIdCounter itemIdCounter)
        {
            _quantity = quantity;
            _name = name;
            _itemCreationDate = DateTime.Now;
            _itemCategory = category;
            _expiry = new DateTime(2099, 12, 30);
            _iD = itemIdCounter.ID;
            itemIdCounter.IncreaseID();
        }



    }
}
