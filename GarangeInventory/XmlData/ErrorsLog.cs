using GarangeInventory.Storage;
using System.Xml.Serialization;

namespace GarangeInventory.XmlData
{
    /*
    internal class ErrorsLog
    {
        private const string _DATA_FOLDER_PATH = @"..\..\..\..\ErrorData";
        private const string _DATA_FILE_NAME = @"\UnhandledExceptions.xml";
        private const string _DATA_FILE_PATH = _DATA_FOLDER_PATH + _DATA_FILE_NAME;
        public const string _BLAZOR_FILE_PATH = @"..\ErrorData\UnhandledExceptions.xml";


        public static void SaveData()
        {
            try
            {
                CreateDataFolder(Directory.Exists(_DATA_FOLDER_PATH));
                XmlSerializer writer = new XmlSerializer(typeof());
                string path = _DATA_FILE_PATH;
                using (FileStream file = File.Create(path))
                {
                    writer.Serialize(file, );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        /// <summary>
        /// Creates Directory if doesn't exist
        /// </summary>
        /// <param name="doesExist"></param>
        private static void CreateDataFolder(bool doesExist)
        {
            if (!doesExist)
            {
                Directory.CreateDirectory(_DATA_FOLDER_PATH);
            }
        }
    }

    */
}
