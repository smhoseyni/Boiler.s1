using Abp.Authorization;
using boiler.s1.Authorization.Roles;
using boiler.s1.Authorization.Users;

namespace boiler.s1.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
