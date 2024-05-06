using GarangeInventory.Storage;
using GarangeInventory;

namespace BlazorGI.Data
{
    public class UserData
    {
        private List<User> _users = new List<User>();

        public List<User> Users
        {
            get { return _users; }
        }

        private User _user;

        public User User
        {
            get { return _user; }
            set { _user = value; }
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
            if (isUser)
            {
                
            }
            return isUser;
        }

    }
}
