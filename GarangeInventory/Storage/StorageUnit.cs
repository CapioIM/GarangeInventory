﻿using GarangeInventory.Storage.Shelf;

namespace GarangeInventory.Storage
{
    public class StorageUnit
    {
		private int _idNumber;

		public int IdNumber
		{
			get { return _idNumber; }
			set { _idNumber = value; }
		}

		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
		private List<ShelfUnit> _shelfUnits = new();

		public List<ShelfUnit> ShelfUnits
        {
			get { return _shelfUnits; }
			set { _shelfUnits = value; }
		}

        private List<UserName> _users = new();

        public List<UserName> Users 
        {
            get { return _users; }
            set { _users = value; }
        }
		public StorageUnit(string name)
		{
			Name = name;
		}
    }
}
