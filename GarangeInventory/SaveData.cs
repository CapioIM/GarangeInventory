using GarangeInventory.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarangeInventory
{
    public class SaveData
    {
        public List<User> Users { get; set; }
        public List<StorageUnit> storageUnits { get; set; }
    }
}
