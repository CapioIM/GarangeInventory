using GarangeInventory.Storage;
using GarangeInventory;
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

        private  User _user;
        public  User User
        {
            get { return _user; }
            set { _user = value; }
        }

        private bool GetUserAccess(string userName)
        {
            Users = GetListOfUsersFromXml();
            bool sucess = false;
            foreach (User u in _users)
            {
                if (u.Name == userName)
                {
                    sucess = true;
                    User = u;
                    break;
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

        public List<User> GetListOfUsersFromXml()
        {
            List<StorageUnit> storageUnits = Serialize.DeserializeStorageUnitList(@"..\TestData\StorageUnitList.xml");
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
