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

        private string UserNameSucess(bool userAccess)
        {
            string message;
            if (userAccess)
            {
                message = "Yess";
            }
            else
            {
                message = "Try Again";
            }
            return message;
        }

        private bool GetUserAccess(string userName)
        {
            _users = TestData.Users();
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

        public string GetUserCheck(string userTypedName)
        {
            bool isUser = false;
            return UserNameSucess(isUser = GetUserAccess(userTypedName));
        }

    }
}
