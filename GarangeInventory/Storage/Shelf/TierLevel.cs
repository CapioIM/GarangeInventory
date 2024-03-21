using GarangeInventory.Common;
using GarangeInventory.Storage.Shelf.Boxes;
using GarangeInventory.Storage.Shelf.Items;


namespace GarangeInventory.Storage.Shelf
{
    public class TierLevel
    {

        private int _tierLevelId;

        public int TierLevelId
        {
            get { return _tierLevelId; }
            set { _tierLevelId = value; }
        }

        private List<Box> _containsBoxes = new();

        public List<Box> ContainsBoxes
        {
            get { return _containsBoxes; }
            set { _containsBoxes = value; }
        }
        private List<Item> _containsItem;

        public List<Item> ContainsItem
        {
            get { return _containsItem; }
            set { _containsItem = value; }
        }
        private Notes _note;

        public Notes Notes
        {
            get { return _note; }
            set { _note = value; }
        }


    }
}
