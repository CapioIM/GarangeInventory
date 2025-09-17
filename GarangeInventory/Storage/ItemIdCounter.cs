namespace GarangeInventory.Storage
{
    public class ItemIdCounter
    {
        private int _id = 0;

        public int ID
        {
            get { return _id; }
  
        }

        public void IncreaseID()
        {
            _id++;
        }

    }
}
