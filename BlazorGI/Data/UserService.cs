using GarangeInventory.Storage;
using GarangeInventory.XmlData;

namespace BlazorGI.Data
{
    public class UserService
    {
        private List<User> _users = new List<User>();

        public List<User> Users
        {
            get { return _users; }
            set { _users = value; }
        }

        private User? _user;
        public User User
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
            Users = GetListOfUsersFromXml();
            bool sucess = false;
            foreach (User userInputCheckForExistingUser in _users)
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

        public List<User> GetListOfUsersFromXml()
        {
            List<StorageUnit> storageUnits = Serialize.DeserializeStorageUnitList                                                                           (GarangeInventory.Enum.AppFilePath.BlazorGI);
            foreach (StorageUnit storageUnit in storageUnits)
            {
                foreach (User user in storageUnit.Users)
                {
                    Users.Add(user);
                }
            }
            return Users;
        }
    }
}
