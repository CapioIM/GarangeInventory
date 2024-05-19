using GarangeInventory.Storage;
using GarangeInventory.XmlData;

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

        private bool GetUserAccess(string userName)
        {
            bool sucess = false;
            foreach (User userInputCheckForExistingUser in Users)
            {
                if (userInputCheckForExistingUser.Name == userName)
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
            List<StorageUnit> storageUnits = Serialize.DeserializeStorageUnitList(GarangeInventory.Enum.SerializationAppFilePath.BlazorGI);
            foreach (StorageUnit storageUnit in storageUnits)
            {
                foreach (User user in storageUnit.Users)
                {
                    Users.Add(user);
                }
            }
        }
    }
}
