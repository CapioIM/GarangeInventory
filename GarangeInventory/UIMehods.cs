using GarangeInventory.Storage;

namespace GarangeInventory
{
    public class UIMehods
    {

        /// <summary>
        /// Creates storage object and returns storage object
        /// </summary>
        /// <returns> Returns new storage object </returns>
        public static Storage.Storage MakeNewStorage(List<Storage.Storage> storageList)
        {
            Console.WriteLine("Please type name of storage");
            var storage = new Storage.Storage(Console.ReadLine());
            storageList.Add(storage);
            return storage;
        }

        public static int GetUserOptionChoice()
        {
            int userStorageOption;
            while (true)
            {
                bool storageOptionChoice = int.TryParse(Console.ReadLine(), out userStorageOption);
                if (storageOptionChoice)
                {
                    if (userStorageOption > 0 && userStorageOption <= 2)
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Your Options are 1 or 2, try to not miss this time.");
                }
            }
            return userStorageOption;
        }

        /// <summary>
        /// loop with tryParse to return number only
        /// </summary>
        /// <returns>Returns int number</returns>
        public static int GetCheckedNumber()
        {
            int number = 0;
            while (true)
            {
                bool isNumber = int.TryParse(Console.ReadLine(), out number);
                if (isNumber)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Try to type number");
                }
            }
            return number;
        }
        /// <summary>
        /// Loop to return number not greater than maxValue and more than 0
        /// </summary>
        /// <param name="maxValue"> return int to not be more than maxValue </param>
        /// <returns> Returns int less than maxValue </returns>
        public static int GetCheckedNumber(int maxValue)
        {
            while (maxValue < 0)
            {
                Console.WriteLine("Type number higher than 0");
                maxValue = GetCheckedNumber();
            }
            int number = 0;
            while (true)
            {
                bool isNumber = int.TryParse(Console.ReadLine(), out number);
                if (isNumber && number <= maxValue && number > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Try to type number");
                }
            }
            return number;
        }



    }
}
