using GarangeInventory.Storage;
using GarangeInventory.DataOperations;

namespace BlazorGI.Data
{
    public class UserService
    {
        private List<User>? _users;

        public List<User>? Users
        {
            get
            {
                if (_users == null)
                {
                    _users = new List<User>();
                    GetUsersFromFile();
                }
                return _users;
            }
            set { _users = value; }
        }

        private User? _user;
        public User? User
        {
            get
            {
                if (_user != null)
                {
                    return _user;
                }
                return _user = new User();
            }
            set { _user = value; }
        }

        public void CreateUser(string? name)
        {

            var u = new User();
            u.Name = name;

            int maxID = Users.Max(u => u.ID);
            u.ID = maxID + 1;

            Users.Add(u);
        }

        private bool GetUserAccess(string userName)
        {
            bool sucess = false;
            if (Users == null)
            {
                GetUsersFromFile();
            }
            foreach (User userInputCheckForExistingUser in Users)
            {
                if (userInputCheckForExistingUser.Name.ToLower() == userName.ToLower())
                {
                    sucess = true;
                    User = userInputCheckForExistingUser;
                    break;
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

        public void GetUsersFromFile()
        {
            SaveData saveData = Serialize.DeserializeStorageUnitList(GarangeInventory.Enum.SerializationAppFilePath.BlazorGI);
            Users = saveData.users;
        }
    }
}
