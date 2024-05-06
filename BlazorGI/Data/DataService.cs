using GarangeInventory;
using GarangeInventory.Storage;

namespace BlazorGI.Data
{
    public class DataService
    {
        private List<User> _users = new List<User>();

        public List<User> Users
        {
            get { return _users; }
        }


        private bool GetUserAccess(string userName)
        {
            _users = TestData.TestDataUsers();
            bool sucess = false;
            foreach (User u in _users)
            {
                if (u.Name == userName)
                {
                    sucess = true;
                }
            }
            return sucess;
        }

        public bool GetUserCheck(string userTypedName)
        {
            bool isUser = false;
            isUser = GetUserAccess(userTypedName);
            return isUser;
        }

    }
}
