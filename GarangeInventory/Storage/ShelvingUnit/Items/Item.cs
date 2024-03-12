using GarangeInventory.Common;

namespace GarangeInventory.Storage.ShelvingUnit.Items
{
    public class Item
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
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
        private WeightType _type;

        public WeightType Type
        {
            get { return _type; }
            set { _type = value; }
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
        private SizeType _size;

        public SizeType Size
        {
            get { return _size; }
            set { _size = value; }
        }
        private Notes _note;

        public Notes Note
        {
            get { return _note; }
            set { _note = value; }
        }

        private PictureFilePath _path;

        public PictureFilePath Path
        {
            get { return _path; }
            set { _path = value; }
        }


    }
}
