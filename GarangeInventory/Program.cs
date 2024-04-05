
namespace GarangeInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var testDataList = TestData.GenerateItems();
            Expiry.GetExpiredItems(testDataList);
            foreach (var item in testDataList)
            {
                Console.WriteLine(item);  
            }


        }
    }
}
