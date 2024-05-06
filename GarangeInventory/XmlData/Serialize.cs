using GarangeInventory.Storage;
using System.Xml;
using System.Xml.Serialization;

namespace GarangeInventory.XmlData
{
    internal class Serialize
    {

        public static void SaveData(List<StorageUnit> storageUnits)
        {
            XmlSerializer writer = new XmlSerializer(typeof(List<StorageUnit>));
            string path = @"/../../StorageUnitList.xml";

            using (FileStream file = File.Create(path))
            {
                writer.Serialize(file, storageUnits);
            }
        }


    }
}
