using Abp.Authorization;
using MyAbpStudy.Authorization.Roles;
using MyAbpStudy.Authorization.Users;

namespace MyAbpStudy.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
