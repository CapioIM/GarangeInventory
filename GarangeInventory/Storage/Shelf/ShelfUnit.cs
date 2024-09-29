using GarangeInventory.Common;

namespace GarangeInventory.Storage.Shelf
{
    public class ShelfUnit
    {
        public ShelfUnit() { }
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
        private string picturePath;

        public string PicturePath
        {
            get { return picturePath; }
            set { picturePath = value; }
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

        /// <summary>
        /// Constructor adds shelfs to Unit
        /// </summary>
        /// <param name="name"> ShelfUnit name </param>
        /// <param name="amountOfShelfs"> How many shelfs in ShelfUnit </param>
        public ShelfUnit(string name,int amountOfShelfs)
        {
            _name = name;
            for (int i = 1; i <= amountOfShelfs; i++)
            {
                string shelfNumber = i.ToString();
                if (i == 1)
                {
                    shelfNumber = "Bottom/Floor Shelf";
                }
                if (i == amountOfShelfs )
                {
                    shelfNumber = "Top Shelf";
                }
                Shelf shelf = new Shelf(shelfNumber);
                Shelfs.Add(shelf);
            }
        }
    }
}
