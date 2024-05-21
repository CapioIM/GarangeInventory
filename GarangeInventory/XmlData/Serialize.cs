using GarangeInventory.Storage;
using System.Xml.Serialization;

namespace GarangeInventory.XmlData
{
    public class Serialize
    {
        private const string _DATA_FOLDER_PATH = @"..\..\..\..\TestData";
        private const string _DATA_FILE_NAME = @"\StorageUnitList.xml";
        private const string _DATA_FILE_PATH = _DATA_FOLDER_PATH + _DATA_FILE_NAME;
        public const string _BLAZOR_FILE_PATH = @"..\TestData\StorageUnitList.xml";

        /// <summary>
        /// creates file in text format with values including in List of object
        /// </summary>
        /// <param name="storageUnits"> List of object </param>
        public static void SaveData(List<StorageUnit> storageUnits, Enum.SerializationAppFilePath blazorGiOrGarageInventory)
        {
            string path = GetDataFilePath(blazorGiOrGarageInventory);
            try
            {
                XmlSerializer writer = new XmlSerializer(typeof(List<StorageUnit>));
                using (FileStream file = File.Create(path))
                {
                    writer.Serialize(file, storageUnits);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        /// <summary>
        /// Deserialize file as List<StorageUnit>
        /// </summary>
        /// <param name="blazorGiOrGarageInventory">choose file path of app BlazorGi or GarageInventory -  GarageInventory.Enum.AppFilePath </param>
        /// <returns> List<StorageUnit> </returns>
        public static List<StorageUnit> DeserializeStorageUnitList(Enum.SerializationAppFilePath blazorGiOrGarageInventory)
        {
            string path = GetDataFilePath(blazorGiOrGarageInventory);
            XmlSerializer serializer = new XmlSerializer(typeof(List<StorageUnit>));
            List<StorageUnit> storageUnit = new List<StorageUnit>();
            using (FileStream file = File.OpenRead(path))
            {
                storageUnit = serializer.Deserialize(file) as List<StorageUnit>;
            }
            return storageUnit;
        }

        /// <summary>
        /// method to return string, with relative path , based on which programm is calling for method / Blazor or C#
        /// </summary>
        /// <param name="blazorGiOrGarageInventory"></param>
        /// <returns>return string, with relative path</returns>
        private static string GetDataFilePath(Enum.SerializationAppFilePath blazorGiOrGarageInventory)
        {
            string path = "";
            switch (blazorGiOrGarageInventory)
            {
                case Enum.SerializationAppFilePath.BlazorGI:
                    path = _BLAZOR_FILE_PATH;
                    break;
                case Enum.SerializationAppFilePath.GarageInventory:
                    path = _DATA_FILE_PATH;
                    break;
            }
            return path;
        }
    }
}
