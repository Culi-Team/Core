using EQX.Core.Common.Navigation;

namespace EQX.Core.Common
{
    public class UserStore
    {
        public event Action? UserChanged;

        private EPermission _permission = EPermission.Operator;
        private string _userName = "Operator";
        private UserAccount _currentUser = new UserAccount
        {
            UserName = "Operator",
            Permission = EPermission.Operator
        };

        public EPermission Permission => _permission;

        public string UserName => _userName;

        public UserAccount CurrentUser => _currentUser.CloneWithoutPassword();

        public bool IsLoggedIn => _permission != EPermission.Operator || !string.Equals(_userName, "Operator", StringComparison.OrdinalIgnoreCase);

        public bool IsSuperUser => _permission == EPermission.SuperUser;

        public void SetUser(UserAccount account)
        {
            if (account == null)
            {
                throw new ArgumentNullException(nameof(account));
            }

            _permission = account.Permission;
            _userName = account.UserName;
            _currentUser = account.CloneWithoutPassword();

            UserChanged?.Invoke();
        }

        public void Reset()
        {
            SetUser(new UserAccount
            {
                UserName = "Operator",
                Permission = EPermission.Operator
            });
        }
    }

}
