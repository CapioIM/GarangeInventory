﻿
namespace GarangeInventory.Storage.Shelf.Items
{
    public class ItemIdCounter
    {
		private int _itemID;

		public int ItemID
		{
			get { return _itemID++; }
			set { _itemID = value; }
		}



	}
}
