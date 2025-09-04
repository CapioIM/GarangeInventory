namespace GarangeInventory.Storage
{
    public class ShelfUnit : StorageObject
    {
        public ShelfUnit() { }


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
            Name = name;
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
