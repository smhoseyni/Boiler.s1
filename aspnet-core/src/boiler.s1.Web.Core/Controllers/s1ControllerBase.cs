using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace boiler.s1.Controllers
{
    public abstract class s1ControllerBase: AbpController
    {
        protected s1ControllerBase()
        {
            LocalizationSourceName = s1Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
