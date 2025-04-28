using GarangeInventory.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarangeInventory.Storage
{
    public class StorageObject
    {
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
        private string picturePath;

        public string PicturePath
        {
            get { return picturePath; }
            set { picturePath = value; }
        }
        private Note _note = new();

        public Note Note
        {
            get { return _note; }
            set { _note = value; }
        }
        public override string ToString()
        {
            return ID + " " + Name;
        }
    }
}
