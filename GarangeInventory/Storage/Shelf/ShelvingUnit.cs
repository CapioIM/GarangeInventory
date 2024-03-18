﻿using GarangeInventory.Common;

namespace GarangeInventory.Storage.Shelf
{
    public class ShelvingUnit
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private int _shelfLevels;

        public int ShelfLevels
        {
            get { return _shelfLevels; }
            set { _shelfLevels = value; }
        }

        private List<TierLevel> _containsLevels;

        public List<TierLevel> ContainsLevels
        {
            get { return _containsLevels; }
            set { _containsLevels = value; }
        }

        private string _user;

        public string User
        {
            get { return _user; }
            set { _user = value; }
        }

        private Notes _note;

        public Notes Notes
        {
            get { return _note; }
            set { _note = value; }
        }

    }
}
