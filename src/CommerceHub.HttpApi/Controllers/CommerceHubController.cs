using CommerceHub.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CommerceHub.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CommerceHubController : AbpControllerBase
{
    protected CommerceHubController()
    {
        LocalizationResource = typeof(CommerceHubResource);
    }
}
