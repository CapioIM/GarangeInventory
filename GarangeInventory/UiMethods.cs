using GarangeInventory.Enum;

namespace GarangeInventory
{
    public class UiMethods
    {
        public static int GetUserChoice()
        {
            int result = 0;
            bool isNumber = false;
            while (!isNumber)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {

                    isNumber = int.TryParse(input, out result);
                    if (isNumber)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Try number this time");
                        isNumber = false;
                    }
                }
                else
                {
                    Console.WriteLine("Try to not miss any key this time");
                }
            }
            return result;
        }

        public static SearchOptions GetSearchOptions(int choice)
        {
            SearchOptions options = new SearchOptions();
            switch (choice)
            {
                case 1:
                    options = SearchOptions.ExpiryDate;
                    break;
                case 2:
                    options = SearchOptions.ContainsName;
                    break;
            }
            return options;
        }
    }
}
